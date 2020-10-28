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
    public partial class UnidadesEdicion : Form
    {

        private Boolean VerificarDatos()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbUnidad.TextLength == 0)
            {
                Notificador.SetError(txbUnidad, "Este campo no puede quedar vacio");
                Verificado = false;
            }
            return Verificado;
        }
        public UnidadesEdicion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarDatos())
                {
                    CLS.Unidad oUnidad = new CLS.Unidad();
                    oUnidad.IDUnidad = txbIDunidad.Text;
                    oUnidad.Nombre = txbUnidad.Text;
                    if (txbIDunidad.Text.Length > 0)
                    {
                        oUnidad.Actualizar();
                    }
                    else
                    {
                        oUnidad.Guardar();
                    }
                    Close();
                }
            }
            catch 
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
