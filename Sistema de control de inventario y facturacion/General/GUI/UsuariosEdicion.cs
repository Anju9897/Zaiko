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
    public partial class UsuariosEdicion : Form
    {
        private Boolean VerificarDatos()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbUsuario.TextLength == 0)
            {
                Notificador.SetError(txbUsuario, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (txbContra.TextLength == 0)
            {
                Notificador.SetError(txbContra, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (txbContra2.TextLength == 0)
            {
                Notificador.SetError(txbContra2, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            return Verificado;
        }

        private void CargarRoles()
        {
            DataTable Roles = new DataTable();
            Roles = CacheManager.CLS.Cache.TODOS_LOS_ROLES();
            cbbRol.DataSource = Roles;
            cbbRol.DisplayMember = "Rol";
            cbbRol.ValueMember = "IDRol";
        }

        private void Procesar()
        {
            try
            {
                if(VerificarDatos() && txbContra.Text.Equals(txbContra2.Text)){
                    CLS.Usuario oUsuario = new CLS.Usuario();
                    oUsuario.IDUsuario = lblIDUsuario.Text;
                    oUsuario.User = txbUsuario.Text;
                    oUsuario.Credencial = txbContra.Text;
                    oUsuario.IDRol = cbbRol.SelectedValue.ToString();
                    oUsuario.IDEmpleado = lblEmpleado.Text;

                    if (lblIDUsuario.Text.Length > 0)
                    {
                        if (oUsuario.Actualizar())
                        {
                            Close();
                        }
                    }
                    else
                    {
                        if (oUsuario.Guardar())
                        {
                            Close();
                        }
                    }
                    
                }else{
                    Notificador.SetError(txbContra,"Las contraseñas no coinciden");
                    Notificador.SetError(txbContra2,"Las contraseñas no coinciden");
                }
            }
            catch 
            {
            }
        }

        public UsuariosEdicion()
        {
            InitializeComponent();
            CargarRoles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Procesar();
        }



      
    }
}
