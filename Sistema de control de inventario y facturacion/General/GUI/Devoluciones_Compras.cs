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
    public partial class Devoluciones_Compras : Form
    {
        private BindingSource _DATOSDETALLE = new BindingSource();
        private BindingSource _DATOSDEVOLUCIONES = new BindingSource();

        public Devoluciones_Compras()
        {
            InitializeComponent();
            CargarDetalle();
        }

        private void CargarDetalle()
        {
            try
            {
                _DATOSDETALLE.DataSource = CacheManager.CLS.Cache.TODOS_LOS_DETALLES_COMPRAS_POR_ID(lblIDDEVCOMPRAS.Text);
                dtgDetallesCompras.DataSource = _DATOSDETALLE;
            }
            catch
            {

            }
        }

        private void CargarDevolucionesCompras()
        {
            try
            {
                _DATOSDEVOLUCIONES.DataSource = CacheManager.CLS.Cache.DEVOLUCIONES_CON_DETALLES_POR_MOVIMIENTO_COMPRAS(lblIDDEVCOMPRAS.Text);
                dtgDevoluciones.DataSource = _DATOSDEVOLUCIONES;
            }
            catch
            {
            }
        }

        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCantidad_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblIDDEVCOMPRAS_TextChanged(object sender, EventArgs e)
        {
            CargarDetalle();
        }

        private void dtgDetallesCompras_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow Row = dtgDetallesCompras.CurrentRow;


            foreach (DataGridViewRow row2 in dtgDevoluciones.Rows)
            {
                if (row2.Cells["idd"].Value.ToString().Equals(Row.Cells["iddetalle"].Value.ToString()))
                {
                    MessageBox.Show("no se puede relizar mas de una devolucion de este producto, unicamente una devolucion por producto", "Aviso Devolucion existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
            }


            if (Convert.ToDouble(Row.Cells["cantidadEntrada"].Value) > 0)
            {
                txbPrecio.Text = Row.Cells["costo"].Value.ToString();
                txbIDDetalle.Text = Row.Cells["iddetalle"].Value.ToString();
                txbProducto.Text = Row.Cells["producto"].Value.ToString();
                txbCantidad.Focus();
            }
        }
    }
}
