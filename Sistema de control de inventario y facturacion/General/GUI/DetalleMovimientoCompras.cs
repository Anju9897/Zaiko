﻿using System;
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
            dm.CEntrada = Convert.ToDouble(txbCantidad.Text);
            dm.Costo = Convert.ToDouble(txbPrecio.Text);
            dm.Gravado = Convert.ToDouble(txbSubtotal.Text);
            dm.SubTotal = Convert.ToDouble(txbSubtotal.Text);
            dm.IVA = Convert.ToDouble(txbIVA.Text);
            dm.Fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            dm.Guardar_Compra();
        }

        private void actualilzar_existencias()
        {
            CLS.Inventario oInventario = new CLS.Inventario();
            Double cantidad = 0.00;
            Double inventario = 0.00;
            Double aux = 0.00;
            try
            {

                cantidad = Convert.ToDouble(txbCantidad.Text);
                inventario = Convert.ToDouble(dtgProductos.Rows[dtgProductos.CurrentRow.Index].Cells["Existencias"].Value);
                aux = inventario + cantidad;
                oInventario.IdProducto = txbIDProducto.Text;
                oInventario.Existencias = Convert.ToString(aux);
                oInventario.Actualizar_Existencias();

                Cargar();
            }
            catch
            {

                throw;
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
                SetDefault();
                txbCantidad.Focus();
        }

        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txbCantidad.Text.Length > 0)
                {
                    txbSubtotal.Text = Convert.ToString(Convert.ToDouble(txbCantidad.Text) * Convert.ToDouble(txbPrecio.Text));
                    txbIVA.Text = Convert.ToString(Convert.ToDouble(txbSubtotal.Text) * 0.13);
                }
                else
                {
                    SetDefault();
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
        }

        private void txbCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
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
            }
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
                    oMov.Actualizar_Total();
                }
            }
            catch
            {
            }
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
            lblIVAsuma.Text = Convert.ToString(iva);
            lblsubtotalSuma.Text = Convert.ToString(total);
            Cargar();
        }
    }
    }
