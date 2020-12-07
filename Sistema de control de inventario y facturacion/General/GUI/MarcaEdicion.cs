using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class MarcaEdicion : Form
    {
        private Boolean VerificarDatos()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbNombre.TextLength == 0)
            {
                Notificador.SetError(txbNombre, "Este campo no puede quedar vacio");
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
                    CLS.Marca oMarca = new CLS.Marca();
                    oMarca.IDMarca = txbIDMarca.Text;
                    oMarca.Nombre = txbNombre.Text;

                    if (txbIDMarca.Text.Length > 0)
                    {
                        if (oMarca.Actualizar())
                        {
                            Close();
                        }
                    }
                    else
                    {
                        if (oMarca.Guardar())
                        {
                            Close();
                        }
                    }
                }
            }
            catch
            {
                
            }
        }

        public MarcaEdicion()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void pbMarca_Click(object sender, EventArgs e)
        {

        }
    }
}
