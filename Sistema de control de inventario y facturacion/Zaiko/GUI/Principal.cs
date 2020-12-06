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
    public partial class Principal : Form
    {
        SessionManager.CLS.Sesion _SESION = SessionManager.CLS.Sesion.Instancia;

        private void verificar(){
            if (_SESION.Informacion.VerificarPermiso(1))
            {
                menuStrip.Visible = true;
            }
            else
            {
                menuStrip.Visible = false;
            }
        }

        public Principal()
        {
            InitializeComponent();
            verificar();
        }

        private void pruebaDeConectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _SESION.Informacion.Usuario;
            lblRol.Text = _SESION.Informacion.Rol;
        }

        private void gestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_SESION.Informacion.VerificarPermiso(3))
            {
                try
                {
                    if (Application.OpenForms["EmpleadosGestion"] != null)
                    {
                        Application.OpenForms["EmpleadosGestion"].Activate();
                    }
                    else
                    {
                        General.GUI.EmpleadosGestion f = new General.GUI.EmpleadosGestion();
                        f.MdiParent = this;
                        f.Show();
                    }
                }

                catch
                {
                }
            }
        }

        private void gestionDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.RolesGestion f = new General.GUI.RolesGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["ProductosGestion"] != null)
                {
                    Application.OpenForms["ProductosGestion"].Activate();
                }
                else
                {
                    General.GUI.ProductosGestion f = new General.GUI.ProductosGestion();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch
            {

            }
            
        }

        private void gestionDeUnidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            General.GUI.GestionUnidades f = new General.GUI.GestionUnidades();
            f.ShowDialog();
        }

        private void edicionMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.MarcaGestion f = new General.GUI.MarcaGestion();
            f.ShowDialog();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.Permisos f = new General.GUI.Permisos();
            f.ShowDialog();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["VistaPreviaReporteCompras"] != null)
                {
                    Application.OpenForms["VistaPreviaReporteCompras"].Activate();
                }
                else
                {
                    Reportes.GUI.Compras f = new Reportes.GUI.Compras();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch
            {

            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["Movimientos"] != null)
                {
                    Application.OpenForms["Movimientos"].Activate();
                }
                else
                {
                    General.GUI.Movimientos f = new General.GUI.Movimientos();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch
            {

            }
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["MovimientosCompras"] != null)
                {
                    Application.OpenForms["MovimientosCompras"].Activate();
                }
                else
                {
                    General.GUI.MovimientosCompras f = new General.GUI.MovimientosCompras();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch
            {

            }

        }

    }
}
