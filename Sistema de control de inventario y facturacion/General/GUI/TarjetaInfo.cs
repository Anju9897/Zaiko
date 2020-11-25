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
    public partial class TarjetaInfo : Form
    {
        public TarjetaInfo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cancelar esta operacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VALIDAR_INFORMACION())
            {
                this.Close();
            }
        }


        private bool VALIDAR_INFORMACION()
        {
            bool VERIFICADO = true;
            if (txbBanco.Text.Equals(""))
            {
                VERIFICADO = false;
                errorTarjeta.SetError(txbBanco, "Este Campo debe es obligatorio");
            }else if(txbPropietario.Text.Equals(""))
            {
                VERIFICADO = false;
                errorTarjeta.SetError(txbPropietario, "Este Campo debe es obligatorio");
            }
            else if (txbNumero.Text.Equals(""))
            {
                VERIFICADO = false;
                errorTarjeta.SetError(txbNumero, "Este Campo debe es obligatorio");
            }

            return VERIFICADO;
        }
    }
}
