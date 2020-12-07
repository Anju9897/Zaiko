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
    public partial class EmpleadosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_EMPLEADOS();
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
                    _DATOS.Filter = "Nombre LIKE '%"+ txbFiltro.Text +"%' OR Apellidos LIKE '%"+ txbFiltro.Text +"%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgDatos.AutoGenerateColumns = false;
                dtgDatos.DataSource = _DATOS;
                lblRegistros.Text = dtgDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch
            {
                
            }
        }

        public EmpleadosGestion()
        {
            InitializeComponent();
            Cargar();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadosEdicion f = new EmpleadosEdicion();
            f.btnAceptaar.Visible = false;
            f.btnCancelar.Visible = false;
            f.btnCancelar2.Visible = true;
            f.ShowDialog();
            Cargar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea editar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EmpleadosEdicion f = new EmpleadosEdicion();
                    f.btnSiguiente.Visible = false;
                    f.btnCancelar2.Visible = false;
                    // sincronizar
                    f.txtIDEmpleado.Text = dtgDatos.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                    f.txtNombres.Text = dtgDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                    f.txtApellidos.Text = dtgDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
                    f.txtDUI.Text = dtgDatos.CurrentRow.Cells["DUI"].Value.ToString();
                    f.txtNIT.Text = dtgDatos.CurrentRow.Cells["NIT"].Value.ToString();
                    f.txtDireccion.Text = dtgDatos.CurrentRow.Cells["Direccion"].Value.ToString();
                    f.txtTelefono.Text = dtgDatos.CurrentRow.Cells["Telefono"].Value.ToString();
                    f.cbbGenero.Text = dtgDatos.CurrentRow.Cells["Genero"].Value.ToString();
                    f.dtpFechaNac.Text = dtgDatos.CurrentRow.Cells["FechaNac"].Value.ToString();
                    f.ShowDialog();
                    Cargar();
                }
            }
            catch
            {

            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea editar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UsuariosEdicion f = new UsuariosEdicion();
                    // sincronizar
                    f.lblIDUsuario.Text = dtgDatos.CurrentRow.Cells["IDUsuario"].Value.ToString();
                    f.lblEmpleado.Text = dtgDatos.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                    f.txbUsuario.Text = dtgDatos.CurrentRow.Cells["Usuario"].Value.ToString();
                    f.txbContra.Text = dtgDatos.CurrentRow.Cells["Credencial"].Value.ToString();
                    f.txbContra2.Text = dtgDatos.CurrentRow.Cells["Credencial"].Value.ToString();
                    f.cbbRol.Text = dtgDatos.CurrentRow.Cells["Rol"].Value.ToString();
                    f.ShowDialog();
                    Cargar();
                }
            }
            catch
            {

            }
        }

        private void btnEliminiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Empleado oEmpleado = new CLS.Empleado();
                    CLS.Usuario oUsuario = new CLS.Usuario();
                    // sincronizar
                    oEmpleado.IdEmpleado = dtgDatos.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                    oUsuario.IDUsuario = dtgDatos.CurrentRow.Cells["IDUsuario"].Value.ToString();

                    if (oUsuario.Eliminar())
                    {
                        oEmpleado.Eliminar();
                        Cargar();
                    }

                }
            }
            catch
            {
            }
        }

        private void dtgDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                txbFiltro.Focus();
            }
            if (e.KeyData == Keys.X)
            {
                btnEliminiar_Click(sender, e);
            }
            if (e.KeyData == Keys.A)
            {
                btnAgregar_Click(sender, e);
            }
        }



    }
}
