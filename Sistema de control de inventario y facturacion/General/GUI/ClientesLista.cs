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
    public partial class ClientesLista : Form
    {
        BindingSource _DATOS = new BindingSource();
        SessionManager.CLS.Sesion _Instancia = SessionManager.CLS.Sesion.Instancia;

        public ClientesLista()
        {
            InitializeComponent();
            Cargar();
        }

        private void btnAgregarCLiente_Click(object sender, EventArgs e)
        {
            ClientesEdicion frm = new ClientesEdicion();
            frm.ShowDialog();
            Cargar();
        }


        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_CLIENTES();
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
                if (txbFiltro.TextLength > 0)
                {
                    _DATOS.Filter = "concat(nombres,apellidos) as 'Nombres' LIKE '%" + txbFiltro.Text + "%' OR tipoPersona LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgClientes.AutoGenerateColumns = false;
                dtgClientes.DataSource = _DATOS;
                lblRegistros.Text = dtgClientes.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch
            {

            }
        }

        private void txbFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                txbFiltro.Focus();
            }
        }

        private void ClientesLista_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgClientes_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            ClientesEdicion f = new ClientesEdicion();
            f.txbIDCliente.Text = dtgClientes.CurrentRow.Cells["idpersonas"].Value.ToString();
            if (dtgClientes.CurrentRow.Cells["tipopersona"].Value.ToString().ToUpper().Equals("PERSONA NATURAL")) {
                String nombreCompleto = dtgClientes.CurrentRow.Cells["nombres"].Value.ToString();
                String[] subnombres = nombreCompleto.Split(' ');
                f.cbbTipoPersona.SelectedIndex = 1;
                f.txbNombres.Text = subnombres[0];
                f.txbApellidos.Text = subnombres[1];
            }
            else if (dtgClientes.CurrentRow.Cells["tipopersona"].Value.ToString().ToUpper().Equals("PERSONA JURIDICA"))
            {
                f.cbbTipoPersona.SelectedIndex = 2;
                f.txbNombres.Text = dtgClientes.CurrentRow.Cells["nombres"].Value.ToString();
            }
            
            f.txbDUI.Text = dtgClientes.CurrentRow.Cells["DUI"].Value.ToString();
            f.txbNIT.Text = dtgClientes.CurrentRow.Cells["NIT"].Value.ToString();
            f.txbNRC.Text = dtgClientes.CurrentRow.Cells["NRC"].Value.ToString();
            f.txbDireccion.Text = dtgClientes.CurrentRow.Cells["Direccion"].Value.ToString();
            f.txbCategoria.Text = dtgClientes.CurrentRow.Cells["Categoria"].Value.ToString();
            f.txbGiro.Text = dtgClientes.CurrentRow.Cells["Giro"].Value.ToString();
            f.ShowDialog();
            Cargar();
        }

        private void dtgClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.X)
            {
                btnEliminarCliente_Click(sender, e);
            }
            if (e.KeyData == Keys.A)
            {
                btnAgregarCLiente_Click(sender, e);
            }
            if (e.KeyData == Keys.E)
            {
                btnModificarCliente_Click(sender, e);
            }
            if (e.KeyData == Keys.F1)
            {
                txbFiltro.Focus();
            }
            if (e.KeyData == Keys.F2)
            {
                btnSeleccionar_Click(sender, e);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("","Aviso Eliminar Persona",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Personas oPersonas = new CLS.Personas();
                    oPersonas.IDPersonas = dtgClientes.CurrentRow.Cells["idpersonas"].Value.ToString();
                    oPersonas.Eliminar();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
