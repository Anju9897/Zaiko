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
    public partial class GestionUnidades : Form
    {
        BindingSource _DATOS = new BindingSource();
        public void Cargar()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODAS_LAS_UNIDADES();
                dtgGestionUnidades.DataSource = _DATOS;

            }
            catch
            {
                
            }
        }

        public GestionUnidades()
        {
            InitializeComponent();
            dtgGestionUnidades.AutoGenerateColumns = false;
            Cargar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            UnidadesEdicion f = new UnidadesEdicion();
            f.ShowDialog();
            Cargar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgGestionUnidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2 && e.RowIndex >= 0)
                    //Editar
                {
                    UnidadesEdicion f = new UnidadesEdicion();
                    f.txbIDunidad.Text = dtgGestionUnidades.CurrentRow.Cells["idunidad"].Value.ToString();
                    f.txbUnidad.Text = dtgGestionUnidades.CurrentRow.Cells["Unidades"].Value.ToString();
                    f.ShowDialog();
                    Cargar();
                }
                else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
                    //eliminar
                {
                    if(MessageBox.Show("Seguro que desea ELIMINAR este registro","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CLS.Unidad oUnidad = new CLS.Unidad();
                        oUnidad.IDUnidad = dtgGestionUnidades.CurrentRow.Cells["idunidad"].Value.ToString();
                        oUnidad.Eliminar();
                        Cargar();
                    }
                }
            }
            catch
            {
            }
        }
    }
}
