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
                    oMarca.Nombre = txbNombre.Text;
                    

                    oMarca.Guardar();
                    if (MessageBox.Show("¿Desea Agregar otra marca?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txbNombre.Clear();
                        pbMarca = null;
                    }
                    else
                    {
                        Close();
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
            CacheManager.CLS.Comandos.CrearCarpeta("Marcas");
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog seleccionar = new OpenFileDialog();
                seleccionar.Filter = "Imagen (*.jpg,*.png) | *.jpg; *.png";
                seleccionar.Title = "Selecciona Imagen";
                seleccionar.InitialDirectory = @"C:\Marcas";
                seleccionar.RestoreDirectory = true;
                DialogResult resultado = seleccionar.ShowDialog();


                if (resultado == DialogResult.OK)
                {
                    pbMarca.Image = Image.FromFile(seleccionar.FileName);
                }
                else
                {

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void pbMarca_Click(object sender, EventArgs e)
        {

        }
    }
}
