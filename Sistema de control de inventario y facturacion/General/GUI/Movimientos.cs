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
    public partial class Movimientos : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_MOVIMIENTOS(cbbTransaccion.Text);
                FiltrarLocalmente();
                FiltrarPorFecha();
                
            }
            catch
            {
            }
        }

        private void FiltrarLocalmente()
        {
            try
            {
                if (txbFiltro.TextLength > 0)
                {
                    _DATOS.Filter = @"Cliente LIKE '%" + txbFiltro.Text + "%' OR tipoComprobante LIKE '%"+
                        txbFiltro.Text + "%' OR numComprobante LIKE '%" + 
                        txbFiltro.Text + "%' OR CondPago LIKE '%" +
                        txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgMovimiento.AutoGenerateColumns = false;
                dtgMovimiento.DataSource = _DATOS;
                lblRegistros.Text = dtgMovimiento.Rows.Count.ToString() + " Registros Encontrados";

            }
            catch
            {
                
            }
        }

        private void FiltrarPorFecha()
        {
            try
            {
                _DATOS.Filter = @"Fecha>='" + dtgFecha1.Text + " 00:00' AND Fecha<='" + dtgFecha2.Text + " 23:59'";
                dtgMovimiento.DataSource = _DATOS;
                lblRegistros.Text = dtgMovimiento.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch
            {
            }
        }

        public Movimientos()
        {
            InitializeComponent();
            Cargar();
            cbbTransaccion.SelectedIndex = 0;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FiltrarPorFecha();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClienteInfo f = new ClienteInfo();
            f.ShowDialog();
            Cargar();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteInfo f = new ClienteInfo();

            f.txbIDMov.Text = dtgMovimiento.CurrentRow.Cells["idmovimiento"].Value.ToString();
            f.txbCliente.Text = dtgMovimiento.CurrentRow.Cells["cliente"].Value.ToString(); 
            f.dtpFecha.Text = dtgMovimiento.CurrentRow.Cells["fecha"].Value.ToString();
            f.cbbEstado.Text = dtgMovimiento.CurrentRow.Cells["estado"].Value.ToString();
            f.cbbFactura.Text = dtgMovimiento.CurrentRow.Cells["tipocomprobante"].Value.ToString();
            f.txbNFactura.Text = dtgMovimiento.CurrentRow.Cells["numcomprobante"].Value.ToString();
            f.cbbCondPago.Text = dtgMovimiento.CurrentRow.Cells["condpago"].Value.ToString();
            f.txbDireccion.Text = dtgMovimiento.CurrentRow.Cells["giro"].Value.ToString();
            f.cbbTransaccion.Text = dtgMovimiento.CurrentRow.Cells["Transaccion"].Value.ToString();
            f.txbNRC.Text = dtgMovimiento.CurrentRow.Cells["direccion"].Value.ToString();
            f.txbNIT.Text = dtgMovimiento.CurrentRow.Cells["numdocumento"].Value.ToString();
            f.lblSubtotal.Text = dtgMovimiento.CurrentRow.Cells["subtotal"].Value.ToString();
            f.lblIVA.Text = dtgMovimiento.CurrentRow.Cells["ivatotal"].Value.ToString();
            f.lblTotal.Text = dtgMovimiento.CurrentRow.Cells["total"].Value.ToString();
            f.ShowDialog();
            Cargar();
        }

        private void Movimientos_Load(object sender, EventArgs e)
        {
        }

        private void transaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DetallesMovimiento f = new DetallesMovimiento();
                f.lblIDMov.Text = dtgMovimiento.CurrentRow.Cells["IDMovimiento"].Value.ToString();
                f.lblComprobante.Text = dtgMovimiento.CurrentRow.Cells["tipocomprobante"].Value.ToString();
                f.ShowDialog();
                Cargar();
            }
            catch (Exception)
            {
            }
            
        }

        private void dtgMovimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                txbFiltro.Focus();
            }
        }

        private void cbbTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTransaccion.SelectedIndex == 0)
            {
                btnEmitirCotizacion.Enabled = false;
                btnEmitirCotizacion.Visible = false;
                Cargar();
            }
            else if (cbbTransaccion.SelectedIndex == 1)
            {
                btnEmitirCotizacion.Enabled = true;
                btnEmitirCotizacion.Visible = true;
                Cargar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que desea anular este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Movimiento f = new CLS.Movimiento();
                    f.IDMovimiento = dtgMovimiento.CurrentRow.Cells["idmovimiento"].Value.ToString();
                    f.Estado = "Anulado";
                    f.Subtotal = "0.00";
                    f.IvaTotal = "0.00";
                    f.Total = "0.00";
                    f.Actualizar_Anulado();
                    Cargar();
                }
            }
            catch 
            {
            }
        }

        private void btnEmitirCotizacion_Click(object sender, EventArgs e)
        {
            Reportes.GUI.Cotizaciones f = new Reportes.GUI.Cotizaciones();
            f.txbNCotizacion.Text = dtgMovimiento.CurrentRow.Cells["idmovimiento"].Value.ToString();
            f.Show();
        }


    }
}
