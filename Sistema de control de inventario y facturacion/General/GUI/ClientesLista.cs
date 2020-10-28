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

        public ClientesLista()
        {
            InitializeComponent();
        }

        private void btnAgregarCLiente_Click(object sender, EventArgs e)
        {
            ClientesEdicion frm = new ClientesEdicion();
            frm.ShowDialog();
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
                    _DATOS.Filter = "Nombre LIKE '%" + txbFiltro.Text + "%' OR tipoPersona LIKE '%" + txbFiltro.Text + "%'";
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
    }
}
