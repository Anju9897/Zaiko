using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaiko.GUI
{
    public partial class Login : Form
    {
        SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;
        Boolean _Autorizado = false;

        public Boolean Autorizado
        {
            get { return _Autorizado; }
        }

        private void Validar()
        {
            try
            {
                String consulta =
                            @"SELECT a.idUsuario, a.usuario, a.credencial, a.idRol, b.rol, a.idEmpleado, concat(c.nombre, ' ', c.apellidos) as 'Empleado', c.genero
                            FROM usuario a, rol b, empleados c
                            WHERE a.usuario='" + txbUsuario.Text + 
                            @"' AND a.credencial= md5(sha1('" + txbPassword.Text + @"')) AND a.idRol=b.idRol AND a.idEmpleado = c.idEmpleado;";

                DataTable Datos = new DataTable();
                DataManager.CLS.DBOperacion Consultor = new DataManager.CLS.DBOperacion();
                Datos = Consultor.Consultar(consulta);

                if (Datos.Rows.Count == 1)
                {
                    _SESION.Informacion.IDUsuario = Datos.Rows[0]["IDUsuario"].ToString();
                    _SESION.Informacion.Usuario = Datos.Rows[0]["Usuario"].ToString();
                    _SESION.Informacion.IDRol = Datos.Rows[0]["IDRol"].ToString();
                    _SESION.Informacion.Rol = Datos.Rows[0]["Rol"].ToString();
                    _Autorizado = true;
                    this.Close();
                }
                else
                {
                    lblValidar.Text = "USUARIO O CONTRASEÑA ERRONEOS";
                }

            }
            catch
            {
                lblValidar.Text = "Error de Conexion";
            }
            
        }


        public Login()
        {
            InitializeComponent();
            txbUsuario.Focus();
        }

        private void lblValidar_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void lblValidar_Click_1(object sender, EventArgs e)
        {

        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Validar();
            }
        }

        
    }
}
