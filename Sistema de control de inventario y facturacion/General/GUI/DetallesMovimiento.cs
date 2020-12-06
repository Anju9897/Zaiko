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
    public partial class DetallesMovimiento : Form
    {
        BindingSource _DATOS = new BindingSource();
        BindingSource _DATOSDETALLE = new BindingSource();

        private void Guardar()
        {
            CLS.DetalleMovimiento dm = new CLS.DetalleMovimiento();
            dm.IDDetalle = lblIDDetalle.Text;
            dm.IDProducto = txbIDProducto.Text;
            dm.IDMovimiento = lblIDMov.Text;
            dm.CSalida = Convert.ToDouble(txbCantidad.Text);
            dm.Precio = Convert.ToDouble(txbPrecio.Text);
            dm.Gravado = Convert.ToDouble(txbSubtotal.Text);
            dm.IVA = Convert.ToDouble(txbIVA.Text);
            dm.SubTotal = dm.Gravado + dm.IVA;
            dm.Fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            if (lblIDDetalle.Text.Length > 0)
            {
                if (!lblTransaccion.Text.Equals("Cotizacion"))
                {
                    actualilzar_existencias();
                }
                dm.Actualizar_Venta();
            }
            else
            {
                if (!lblTransaccion.Text.Equals("Cotizacion"))
                {
                    actualilzar_existencias();
                }
                dm.Guardar_Venta();
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
                    double valorAnterior = Convert.ToDouble(dtgDetalle.Rows[dtgDetalle.CurrentRow.Index].Cells["cantitadsalida"].Value);
                    double nuevoValor = Convert.ToDouble(txbCantidad.Text);
                    double Existencias = Convert.ToDouble(dtgDetalle.Rows[dtgDetalle.CurrentRow.Index].Cells["exi"].Value);

                    oInventario.IDInventario = dtgDetalle.Rows[dtgDetalle.CurrentRow.Index].Cells["inventario"].Value.ToString();
                    oInventario.IdProducto = txbIDProducto.Text;
                    double aux = 0.00;
                    if (nuevoValor < valorAnterior)
                    {
                        aux = (Existencias + valorAnterior) - nuevoValor;
                    }
                    else if(nuevoValor > valorAnterior)
                    {
                        aux = Existencias - (nuevoValor - valorAnterior);
                    }
                    else if(nuevoValor == valorAnterior)
                    {
                        aux = Existencias;
                    }
                    oInventario.Existencias = Convert.ToString(aux);
                }
                else if(lblIDDetalle.Text.Length == 0)
                {
                    oInventario.IDInventario = dtgProductos.Rows[dtgProductos.CurrentRow.Index].Cells["IDINVENTARIO"].Value.ToString();
                    oInventario.IdProducto = txbIDProducto.Text;
                    double cantidad = 0.00;
                    double inventario = 0.00;
                    double aux = 0.00;
                    cantidad = Convert.ToDouble(txbCantidad.Text);
                    inventario = Convert.ToDouble(dtgProductos.Rows[dtgProductos.CurrentRow.Index].Cells["Existencias"].Value);
                    aux = inventario - cantidad;
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
                _DATOSDETALLE.DataSource = CacheManager.CLS.Cache.TODOS_LOS_DETALLES_POR_ID(lblIDMov.Text);
                dtgDetalle.AutoGenerateColumns = false;
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

        public DetallesMovimiento()
        {
            InitializeComponent();
            Cargar();
            CargarDetalle();
        }

        private void dtgProductos_DoubleClick(object sender, EventArgs e)
        {
            //PENDIENTE: NUMERO DE CAPACIDAD DE LA FACTURA DE PRODUCTOS
            if (dtgDetalle.RowCount < 5)
            {

                if (Convert.ToDouble(dtgProductos.Rows[dtgProductos.CurrentRow.Index].Cells["Existencias"].Value) > 0)
                {
                    if (!existeDetalle(dtgProductos.Rows[dtgProductos.CurrentRow.Index].Cells["idproducto"].Value.ToString()))
                    {
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
            else
            {
                MessageBox.Show("No se pueden agregar mas elementos a la factura, debido a que excede el numero de elementos permitidos por el comprobante\nSi desea agregar mas elementos debe de crear otra facturacion o movimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool existeDetalle(String idp)
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
                        
                        double valortotal = Math.Round(Convert.ToDouble(txbCantidad.Text) * Convert.ToDouble(txbPrecio.Text),2);
                        double gravado = Math.Round(valortotal / 1.13,2);
                        double iva = Math.Round(gravado * 0.13,2);
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
                        double iva = Math.Round(subtotal * 0.13,2);
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
            if (e.KeyData == Keys.F2)
            {
                btnConfirmar_Click(sender, e);
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
                                if (!lblTransaccion.Text.Equals("Cotizacion"))
                                {
                                    Guardar();
                                }
                            }
                            else
                            {
                                Double existencias = Convert.ToDouble(dtgProductos.CurrentRow.Cells["existencias"].Value);
                                Double cantidades = Convert.ToDouble(txbCantidad.Text);
                                if (existencias >= cantidades && existencias > 0)
                                {
                                    Guardar();

                                }
                                else
                                {
                                    MessageBox.Show("No es Posible llevar mas cantidad de productos de la que se tienen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

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
        }

        private void lblIDMov_TextChanged(object sender, EventArgs e)
        {
            CargarDetalle();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("¿Esta Seguro que desea Eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.DetalleMovimiento oDMovimiento = new CLS.DetalleMovimiento();
                    if (!lblTransaccion.Text.Equals("Cotizacion")) {
                        CLS.Inventario oInventario = new CLS.Inventario();
                        Double suma = 0.00;
                        Double inventario = Convert.ToDouble(dtgDetalle.CurrentRow.Cells["exi"].Value);
                        Double entrada = Convert.ToDouble(dtgDetalle.CurrentRow.Cells["cantitadsalida"].Value);
                        suma = inventario + entrada;
                        oInventario.IdProducto = dtgDetalle.CurrentRow.Cells["idp"].Value.ToString();
                        oInventario.Existencias = Convert.ToString(suma); 
                        oInventario.Actualizar_Existencias();
                        Cargar();
                    }
                    // sincronizar
                    oDMovimiento.IDDetalle = dtgDetalle.CurrentRow.Cells["iddetalle"].Value.ToString();
                    oDMovimiento.Eliminar();
                    CargarDetalle();
                }
            }
            catch
            {
            }
        }

        private void dtgDetalle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Double gravado = 0.00;
            Double total = 0.00;
            Double iva = 0.00;

            foreach (DataGridViewRow row in dtgDetalle.Rows)
            {
                iva += Convert.ToDouble(row.Cells["MontoIVA"].Value);
                gravado += Convert.ToDouble(row.Cells["gravado"].Value);
            }
            total = gravado + iva;

            txbIDProducto.Text = "";
            lblIDDetalle.Text = "";
            txbProducto.Text = "";
            txbPrecio.Text = "";
            txbSubtotal.Text = "";
            txbIVA.Text = "";
            txbCantidad.Text = "";
            lblUnidad.Text = "";

            lblIVAsuma.Text = Convert.ToString(iva);
            lblsubtotalSuma.Text = Convert.ToString(gravado);

        }

        private void DetallesMovimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void dtgDetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Double gravado = 0.00;
            Double total = 0.00;
            Double iva = 0.00;

            foreach (DataGridViewRow row in dtgDetalle.Rows)
            {
                iva += Convert.ToDouble(row.Cells["MontoIVA"].Value);
                gravado += Convert.ToDouble(row.Cells["gravado"].Value);
            }
            total = gravado + iva;

            txbIDProducto.Text = "";
            lblIDDetalle.Text = "";
            txbProducto.Text = "";
            txbPrecio.Text = "";
            txbSubtotal.Text = "";
            txbIVA.Text = "";
            txbCantidad.Text = "";
            lblUnidad.Text = "";

            lblIVAsuma.Text = Convert.ToString(iva);
            lblsubtotalSuma.Text = Convert.ToString(gravado);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
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
            {
            }
        }

        private void dtgDetalle_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int RowIndex = dtgDetalle.CurrentRow.Index;
                txbIDProducto.Text = dtgDetalle.Rows[RowIndex].Cells["idp"].Value.ToString();
                lblIDDetalle.Text = dtgDetalle.Rows[RowIndex].Cells["iddetalle"].Value.ToString();
                txbProducto.Text = dtgDetalle.Rows[RowIndex].Cells["producto"].Value.ToString();
                txbPrecio.Text = dtgDetalle.Rows[RowIndex].Cells["precio"].Value.ToString();
                lblUnidad.Text = dtgDetalle.Rows[RowIndex].Cells["unidades"].Value.ToString();
                txbIVA.Text = dtgDetalle.Rows[RowIndex].Cells["montoiva"].Value.ToString();
                txbSubtotal.Text = dtgDetalle.Rows[RowIndex].Cells["gravado"].Value.ToString();
                txbCantidad.Text = dtgDetalle.Rows[RowIndex].Cells["cantitadsalida"].Value.ToString();
                txbCantidad.Focus();
            }
            catch
            {

            }

        }

        private void txbSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || (e.KeyChar == 46) || (e.KeyChar == 8) || (e.KeyChar == 13))
            {
                
            }
            else
            {
                MessageBox.Show("Solo son permitidos numeros o puntos decimales", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dtgDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                txbBuscar.Focus();
            }
            if (e.KeyData == Keys.F2)
            {
                btnConfirmar_Click(sender, e);
            }
            if (e.KeyData == Keys.X)
            {
                toolStripButton2_Click(sender, e);
            }
        }

    }

}

