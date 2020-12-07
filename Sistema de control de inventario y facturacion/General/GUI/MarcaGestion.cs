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
    public partial class MarcaGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        SessionManager.CLS.Sesion _Instancia = SessionManager.CLS.Sesion.Instancia;
        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODAS_LAS_MARCAS();
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
                if (txbFiltrar.Text.Length > 0)
                {
                    _DATOS.Filter = @"mnombre LIKE '%" + txbFiltrar.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgMarcas.AutoGenerateColumns = false;
                dtgMarcas.DataSource = _DATOS;
                lblMarcas.Text = dtgMarcas.Rows.Count.ToString() + " Marcas Encontradas";
            }
            catch
            {
            }
        }

        public MarcaGestion()
        {
            InitializeComponent();
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MarcaEdicion f = new MarcaEdicion();
            f.ShowDialog();
            Cargar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ProductoEdicion f = new ProductoEdicion();
            f.txbMarca.Text = dtgMarcas.CurrentRow.Cells["IDMarca"].Value.ToString();
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MarcaEdicion f = new MarcaEdicion();
            f.txbIDMarca.Text = dtgMarcas.CurrentRow.Cells["idmarca"].Value.ToString();
            f.txbNombre.Text = dtgMarcas.CurrentRow.Cells["mnombre"].Value.ToString();
            f.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Seguro que Desea ELIMINAR este registro?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Marca oMarca= new CLS.Marca();
                    oMarca.IDMarca = dtgMarcas.CurrentRow.Cells["idmarca"].Value.ToString();
                    oMarca.Eliminar();
                    Cargar();
                }
            }
            catch
            {
                
            }
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            Cargar();
            if (txbFiltrar.Text.Length > 0)
            {
                FiltrarLocalmente();
            }
            
        }

        private void MarcaGestion_Load(object sender, EventArgs e)
        {
            if (_Instancia.Informacion.Rol.ToUpper().Equals("CAJERO".ToUpper()))
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }
    }
}
