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
    public partial class MovimientosCompras : Form
    {
        BindingSource _DATOS = new BindingSource();
        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_MOVIMIENTOS_COMPRAS();
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
                    _DATOS.Filter = @"cliente LIKE '%"+ txbFiltro.Text +"%' OR tipoComprobante LIKE '%" +
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



        //Eventos y metodos creados por VS
        public MovimientosCompras()
        {
            InitializeComponent();
            Cargar();
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FiltrarPorFecha();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClienteInfo f = new ClienteInfo();
            f.cbbTransaccion.Enabled = false;
            f.btnDefault.Enabled = false;
            f.btnDefault.Visible = false;
            f.cbbTransaccion.SelectedIndex = 2;
            f.cbbFactura.SelectedIndex = 1;
            f.cbbFactura.Enabled = false;
            f.cbbEstado.SelectedIndex = 1;
            f.cbbEstado.Enabled = false;

            ClienteInfo.tipoDoc = "";
            ClienteInfo.subtotal = 0.00;
            ClienteInfo.iva = 0.00;
            ClienteInfo.total = 0.00;
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
            f.txbIDCliente.Text = dtgMovimiento.CurrentRow.Cells["IDPERSONA"].Value.ToString();
            f.txbCliente.Text = dtgMovimiento.CurrentRow.Cells["cliente"].Value.ToString();
            f.dtpFecha.Text = dtgMovimiento.CurrentRow.Cells["fecha"].Value.ToString();
            f.cbbEstado.Text = dtgMovimiento.CurrentRow.Cells["estado"].Value.ToString();
            f.cbbFactura.Text = dtgMovimiento.CurrentRow.Cells["tipodocumento"].Value.ToString();
            f.txbNFactura.Text = dtgMovimiento.CurrentRow.Cells["numdocumento"].Value.ToString();
            f.cbbCondPago.Text = dtgMovimiento.CurrentRow.Cells["condpago"].Value.ToString();
            f.cbbTransaccion.Text = dtgMovimiento.CurrentRow.Cells["Transaccion"].Value.ToString();
            f.cbbTransaccion.Enabled = false;
            f.cbbFactura.Enabled = false;
            f.cbbFactura.SelectedIndex = 1;
            f.cbbEstado.Enabled = false;
            f.lblSubtotal.Text = dtgMovimiento.CurrentRow.Cells["subtotal"].Value.ToString();
            f.lblIVA.Text = dtgMovimiento.CurrentRow.Cells["ivatotal"].Value.ToString();
            f.lblTotal.Text = dtgMovimiento.CurrentRow.Cells["total"].Value.ToString();
            ClienteInfo.tipoDoc = dtgMovimiento.CurrentRow.Cells["tipodocumento"].Value.ToString();
            ClienteInfo.subtotal = Convert.ToDouble(dtgMovimiento.CurrentRow.Cells["subtotal"].Value);
            ClienteInfo.iva = Convert.ToDouble(dtgMovimiento.CurrentRow.Cells["ivatotal"].Value);
            ClienteInfo.total = Convert.ToDouble(dtgMovimiento.CurrentRow.Cells["total"].Value);

            f.ShowDialog();
            Cargar();

            ClienteInfo.tipoDoc = "";
            ClienteInfo.subtotal = 0.00;
            ClienteInfo.iva = 0.00;
            ClienteInfo.total = 0.00;

            
        }


        private void Movimientos_Load(object sender, EventArgs e)
        {
        }

        private void transaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetalleMovimientoCompras f = new DetalleMovimientoCompras();
            f.lblIDMov.Text = dtgMovimiento.CurrentRow.Cells["IDMovimiento"].Value.ToString();
            f.lblComprobante.Text = dtgMovimiento.CurrentRow.Cells["tipodocumento"].Value.ToString();
            f.ShowDialog();
            Cargar();
        }

        private void dtgMovimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                txbFiltro.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que desea ELIMINAR este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Movimiento f = new CLS.Movimiento();
                    f.IDMovimiento = dtgMovimiento.CurrentRow.Cells["idmovimiento"].Value.ToString();
                    f.Eliminar();
                    Cargar();
                }
            }
            catch
            {
            }
        }

        private void dtgFecha1_ValueChanged(object sender, EventArgs e)
        {
            btnMostrar.Focus();
        }

    }
}
