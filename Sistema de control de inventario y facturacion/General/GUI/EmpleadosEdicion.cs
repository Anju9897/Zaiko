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
    public partial class EmpleadosEdicion : Form
    {

        private Boolean VerificarDatos()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txtNombres.TextLength == 0)
            {
                Notificador.SetError(txtNombres, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (txtApellidos.TextLength == 0)
            {
                Notificador.SetError(txtApellidos, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (txtDUI.TextLength == 0)
            {
                Notificador.SetError(txtDUI, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (txtNIT.TextLength == 0)
            {
                Notificador.SetError(txtNIT, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (txtDireccion.TextLength == 0)
            {
                Notificador.SetError(txtDireccion, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (txtTelefono.TextLength == 0)
            {
                Notificador.SetError(txtTelefono, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            return Verificado;
        }

        private void Procesar()
        {
            try
            {
                if (VerificarDatos())
                {

                    CLS.Empleado oEmpleado = new CLS.Empleado();
                    CLS.Usuario oUser = new CLS.Usuario();
                    //Sincronizar
                    oEmpleado.IdEmpleado = txtIDEmpleado.Text;
                    oEmpleado.Nombre = txtNombres.Text;
                    oEmpleado.Apellidos = txtApellidos.Text;
                    oEmpleado.DUI = txtDUI.Text;
                    oEmpleado.NIT = txtNIT.Text;
                    oEmpleado.Direccion = txtDireccion.Text;
                    oEmpleado.Telefono = txtTelefono.Text;
                    oEmpleado.Genero = cbbGenero.Text;
                    oEmpleado.FechaNacimiento = dtpFechaNac.Text;

                    if (txtIDEmpleado.Text.Length > 0)
                    {
                        //Actualizar
                        if (oEmpleado.Actualizar())
                        {
                            Close();
                        }
                    }
                    else
                    {
                        //Insertar
                        if (oEmpleado.Guardar())
                        {
                            
                            if (MessageBox.Show("Ahora Registre los Datos de Sesion", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                               
                                Close();
                            }
                            
                        }
                    }
                    
                }
            }
            catch
            {
            }
        }




        public EmpleadosEdicion()
        {
            InitializeComponent();
            cbbGenero.SelectedIndex = 0;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                Procesar();
                CLS.Empleado emp = new CLS.Empleado();
                UsuariosEdicion f = new UsuariosEdicion();
                f.lblEmpleado.DataSource = emp.getIDempleado(txtDUI.Text);
                f.lblEmpleado.ValueMember = "IDEmpleado";
                f.lblEmpleado.DisplayMember = "IDEmpleado";
                f.lblEmpleado.SelectedIndex = 0;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe completar los campos requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }   
        }

        private void btnAceptaar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }



       
    }
}
