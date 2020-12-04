using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class DetalleMovimientoCompras : Form
    {
        BindingSource _DATOS = new BindingSource();
        BindingSource _DATOSDETALLE = new BindingSource();


        private void Guardar()
        {
            CLS.DetalleMovimiento dm = new CLS.DetalleMovimiento();
            dm.IDProducto = txbIDProducto.Text;
            dm.IDMovimiento = lblIDMov.Text;
            dm.IDDetalle = lblIDDetalle.Text;
            dm.CEntrada = Convert.ToDouble(txbCantidad.Text);
            dm.Costo = Convert.ToDouble(txbPrecio.Text);
            dm.Gravado = Convert.ToDouble(txbSubtotal.Text);
            dm.SubTotal = Convert.ToDouble(txbSubtotal.Text);
            dm.IVA = Convert.ToDouble(txbIVA.Text);
            dm.Fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            if (lblIDDetalle.Text.Length > 0)
            {
                actualilzar_existencias();
                dm.Actualizar_Compra();
            }
            else
            {
                actualilzar_existencias();
                dm.Guardar_Compra();
            }

            Cargar();
            CargarDetalle();

        }

        private void actualilzar_existencias()
        {
            CLS.Inventario oInventario = new CLS.Inventario();
            try
            {
                if (lblIDDetalle.Text.Length > 0)
                {
                    double valorAnterior = Convert.ToDouble(dtgDetalle.Rows[dtgDetalle.CurrentRow.Index].Cells["cantidadEntrada"].Value);
                    double nuevoValor = Convert.ToDouble(txbCantidad.Text);
                    double Existencias = Convert.ToDouble(dtgDetalle.Rows[dtgDetalle.CurrentRow.Index].Cells["exi"].Value);

                    oInventario.IDInventario = dtgDetalle.Rows[dtgDetalle.CurrentRow.Index].Cells["inventario"].Value.ToString();
                    oInventario.IdProducto = txbIDProducto.Text;
                    double aux = 0.00;
                    if (nuevoValor < valorAnterior)
                    {
                        aux = Existencias -(valorAnterior - nuevoValor);
                    }
                    else if (nuevoValor > valorAnterior)
                    {
                        aux = Existencias + (nuevoValor - valorAnterior);
                    }
                    else if (nuevoValor == valorAnterior)
                    {
                        aux = Existencias;
                    }
                    oInventario.Existencias = Convert.ToString(aux);
                }
                else if (lblIDDetalle.Text.Length == 0)
                {
                    oInventario.IDInventario = dtgProductos.Rows[dtgProductos.CurrentRow.Index].Cells["IDINVENTARIO"].Value.ToString();
                    oInventario.IdProducto = txbIDProducto.Text;
                    double cantidad = 0.00;
                    double inventario = 0.00;
                    double aux = 0.00;
                    cantidad = Convert.ToDouble(txbCantidad.Text);
                    inventario = Convert.ToDouble(dtgProductos.Rows[dtgProductos.CurrentRow.Index].Cells["Existencias"].Value);
                    aux = inventario + cantidad;
                    oInventario.Existencias = Convert.ToString(aux);
                }

                if (oInventario.Actualizar_Existencias())
                {
                    Cargar();
                    CargarDetalle();
                }

            }
            catch
            {
            }
        }

        private void CargarDetalle()
        {
            try
            {
                _DATOSDETALLE.DataSource = CacheManager.CLS.Cache.TODOS_LOS_DETALLES_COMPRAS_POR_ID(lblIDMov.Text);
                dtgDetalle.DataSource = _DATOSDETALLE;
            }
            catch
            {

            }
        }

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_PRODUCTOS_DETALLE();
                FiltrarLocalmente();

            }
            catch
            {
            }

        }

        private void FiltrarLocalmente()
        {
            try
            {
                if (txbBuscar.Text.Length > 0)
                {
                    _DATOS.Filter = @"nombre like '%" + txbBuscar.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgProductos.AutoGenerateColumns = false;
                dtgProductos.DataSource = _DATOS;
            }
            catch
            {

                throw;
            }
        }

        private void SetDefault()
        {
            int RowIndex = dtgProductos.CurrentRow.Index;
            txbIDProducto.Text = dtgProductos.Rows[RowIndex].Cells["idproducto"].Value.ToString();
            txbProducto.Text = dtgProductos.Rows[RowIndex].Cells["nombre"].Value.ToString();
            txbPrecio.Text = dtgProductos.Rows[RowIndex].Cells["preciounitario"].Value.ToString();
            lblUnidad.Text = dtgProductos.Rows[RowIndex].Cells["unidad"].Value.ToString();
            txbIVA.Text = "0.00";
            txbSubtotal.Text = "0.00";
        }

        public DetalleMovimientoCompras()
        {
            InitializeComponent();
            Cargar();
            CargarDetalle();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ProductoEdicion f = new ProductoEdicion();
            f.txbExistencias.Enabled = false;
            f.ShowDialog();
            Cargar();
        }

        private void dtgProductos_DoubleClick(object sender, EventArgs e)
        {
            if (Convert.ToDouble(dtgProductos.Rows[dtgProductos.CurrentRow.Index].Cells["Existencias"].Value) >= 0)
            {
                if (!existeDetalle(dtgProductos.Rows[dtgProductos.CurrentRow.Index].Cells["idproducto"].Value.ToString()))
                {
                    MessageBox.Show("Instrucciones:\n1. Ingregar la cantidad en el espacio espeficiado.\n2. Al Ingresar toda la cantidad, precionar ENTER para agregar la informacion al cuadro de abajo.", "Informacion Para agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetDefault();
                    txbCantidad.Focus();
                }
                else
                {
                    MessageBox.Show("Este articulo ya existe en el detalle, si desea modificar su valor, puede seguir las siguientes instrucciones:\n1. Seleccionar el articulo existente que desea modificar y dar click al boton 'Modificar'.\n2. Dar doble click al elemento ya existente en el cuadro de abajo para activar la modificacion.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("No hay existencias de este producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool existeDetalle(string p)
         {
             bool existe = false;
             for (int i = 0; i < dtgDetalle.Rows.Count; i++)
             {
                 if (dtgDetalle.Rows[i].Cells["idp"].Value.ToString().Equals(idp))
                 {
                     existe = true;
                     break;
                 }
             }
             return existe;
         }

        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lblComprobante.Text.ToUpper().Equals("FACTURA CONSUMIDOR FINAL"))
                {
                    if (txbCantidad.Text.Length > 0)
                    {

                        double valortotal = Math.Round(Convert.ToDouble(txbCantidad.Text) * Convert.ToDouble(txbPrecio.Text), 2);
                        double gravado = Math.Round(valortotal / 1.13, 2);
                        double iva = Math.Round(gravado * 0.13, 2);
                        txbSubtotal.Text = Convert.ToString(gravado);
                        txbIVA.Text = Convert.ToString(iva);
                    }
                    else
                    {
                        if (txbIDProducto.Text.Length > 0)
                        {
                            SetDefault();
                        }
                    }
                }
                else if (lblComprobante.Text.ToUpper().Equals("COMPROBANTE DE CREDITO FISCAL"))
                {
                    if (txbCantidad.Text.Length > 0)
                    {
                        double subtotal = Math.Round(Convert.ToDouble(txbCantidad.Text) * Convert.ToDouble(txbPrecio.Text), 2);
                        double iva = Math.Round(subtotal * 0.13, 2);
                        txbSubtotal.Text = Convert.ToString(subtotal);
                        txbIVA.Text = Convert.ToString(iva);
                    }
                    else
                    {
                        if (txbIDProducto.Text.Length > 0)
                        {
                            SetDefault();
                        }
                    }
                }

            }
            catch
            {

            }
        }

        private void DetallesMovimiento_Load(object sender, EventArgs e)
        {
            txbBuscar.Focus();
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dtgProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                txbBuscar.Focus();
            }
            if (e.KeyData == Keys.A)
            {
                toolStripButton2_Click(sender, e);
            }
            if (e.KeyData == Keys.X)
            {
                btnEliminar_Click(sender, e);
            }
            if (e.KeyData == Keys.F2)
            {
                toolStripButton3_Click(sender, e);
            }
        }

        private void txbCantidad_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    if (txbIDProducto.Text.Length > 0)
                    {
                        if (txbCantidad.Text.Length > 0)
                        {
                            if (lblIDDetalle.Text.Length > 0)
                            {
                                if (!lblComprobante.Text.Equals("Cotizacion"))
                                {
                                    Guardar();
                                }
                            }
                            else
                            {
                                Double existencias = Convert.ToDouble(dtgProductos.CurrentRow.Cells["existencias"].Value);
                                Double cantidades = Convert.ToDouble(txbCantidad.Text);
                                Guardar();
                            }
                            Cargar();
                            CargarDetalle();
                        }
                        else
                        {
                            MessageBox.Show("No es posible realizar esta operacion sin datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe ningun producto seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch
                {
                }
            }

            /*if (e.KeyData == Keys.Enter)
            {
                try
                {
                    if (txbCantidad.Text.Length > 0)
                    {

                        actualilzar_existencias();
                        Guardar();
                        CargarDetalle();
                    }
                    else
                    {
                        MessageBox.Show("No es posible realizar esta operacion sin datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch
                {
                }
            }*/
        }

        private void lblIDMov_TextChanged(object sender, EventArgs e)
        {
            CargarDetalle();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Double total = 0.00;
                Double iva = 0.00;

                if (MessageBox.Show("¿Esta Seguro que desea Eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.DetalleMovimiento oDMovimiento = new CLS.DetalleMovimiento();
                    CLS.Inventario oInventario = new CLS.Inventario();
                    Double resta = 0.00;
                    Double inventario = Convert.ToDouble(dtgDetalle.CurrentRow.Cells["exi"].Value);
                    Double entrada = Convert.ToDouble(dtgDetalle.CurrentRow.Cells["cantidadentrada"].Value);
                    // sincronizar

                    oDMovimiento.IDDetalle = dtgDetalle.CurrentRow.Cells["iddetalle"].Value.ToString();
                    oInventario.IdProducto = dtgDetalle.CurrentRow.Cells["idp"].Value.ToString();
                    resta = inventario - entrada;
                    oInventario.Existencias = Convert.ToString(resta);
                    oInventario.Actualizar_Existencias();
                    oDMovimiento.Eliminar();

                    foreach (DataGridViewRow row in dtgDetalle.Rows)
                    {
                        iva += Convert.ToDouble(row.Cells["MontoIVA"].Value);
                        total += Convert.ToDouble(row.Cells["subtotal"].Value);
                    }
                    lblIVAsuma.Text = Convert.ToString(iva);
                    lblsubtotalSuma.Text = Convert.ToString(total);

                    Cargar();
                    CargarDetalle();
                }
            }
            catch
            {
            }
        }

        private void dtgDetalle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Double total = 0.00;
            Double iva = 0.00;

            foreach (DataGridViewRow row in dtgDetalle.Rows)
            {
                iva += Convert.ToDouble(row.Cells["MontoIVA"].Value);
                total += Convert.ToDouble(row.Cells["subtotal"].Value);
            }

            txbIDProducto.Text = "";
            lblIDDetalle.Text = "";
            txbProducto.Text = "";
            txbPrecio.Text = "";
            txbSubtotal.Text = "";
            txbIVA.Text = "";
            txbCantidad.Text = "";
            lblUnidad.Text = "";

            lblIVAsuma.Text = Convert.ToString(iva);
            lblsubtotalSuma.Text = Convert.ToString(total);
        }

        private void DetallesMovimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void dtgDetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Double total = 0.00;
            Double iva = 0.00;
            CLS.Inventario oInventario = new CLS.Inventario();

            foreach (DataGridViewRow row in dtgDetalle.Rows)
            {
                iva += Convert.ToDouble(row.Cells["MontoIVA"].Value);
                total += Convert.ToDouble(row.Cells["subtotal"].Value);
            }
            txbIDProducto.Text = "";
            lblIDDetalle.Text = "";
            txbProducto.Text = "";
            txbPrecio.Text = "";
            txbSubtotal.Text = "";
            txbIVA.Text = "";
            txbCantidad.Text = "";
            lblUnidad.Text = "";

            lblIVAsuma.Text = Convert.ToString(iva);
            lblsubtotalSuma.Text = Convert.ToString(total);
            Cargar();
        }

        private void dtgDetalle_DoubleClick(object sender, EventArgs e)
        {
            int RowIndex = dtgDetalle.CurrentRow.Index;
            txbIDProducto.Text = dtgDetalle.Rows[RowIndex].Cells["idp"].Value.ToString();
            lblIDDetalle.Text = dtgDetalle.Rows[RowIndex].Cells["iddetalle"].Value.ToString();
            txbProducto.Text = dtgDetalle.Rows[RowIndex].Cells["producto"].Value.ToString();
            txbPrecio.Text = dtgDetalle.Rows[RowIndex].Cells["precio"].Value.ToString();
            lblUnidad.Text = dtgDetalle.Rows[RowIndex].Cells["unidades"].Value.ToString();
            txbIVA.Text = dtgDetalle.Rows[RowIndex].Cells["montoiva"].Value.ToString();
            txbSubtotal.Text = dtgDetalle.Rows[RowIndex].Cells["gravado"].Value.ToString();
            txbCantidad.Text = dtgDetalle.Rows[RowIndex].Cells["cantidadEntrada"].Value.ToString();
            txbCantidad.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea Completar la Transaccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Movimiento oMov = new CLS.Movimiento();
                    oMov.IDMovimiento = lblIDMov.Text;
                    oMov.Subtotal = Convert.ToString(Convert.ToDouble(lblsubtotalSuma.Text));
                    oMov.IvaTotal = Convert.ToString(Convert.ToDouble(lblIVAsuma.Text));

                    if (lblComprobante.Text.Equals("Comprobante de Credito fiscal"))
                    {
                        oMov.Total = Convert.ToString(Convert.ToDouble(lblsubtotalSuma.Text) + Convert.ToDouble(lblIVAsuma.Text));
                    }
                    else if (lblComprobante.Text.Equals("Factura consumidor final"))
                    {
                        oMov.Total = Convert.ToString(Convert.ToDouble(lblsubtotalSuma.Text) + Convert.ToDouble(lblIVAsuma.Text));
                    }
                    else
                    {
                        oMov.Total = Convert.ToString(Convert.ToDouble(lblsubtotalSuma.Text));
                    }
                    oMov.Actualizar_Total();
                    Close();
                }
            }
            catch
            { }
        }
    }
}
