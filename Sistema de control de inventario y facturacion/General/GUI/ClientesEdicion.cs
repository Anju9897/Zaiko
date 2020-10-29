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
    public partial class ClientesEdicion : Form
    {
        public ClientesEdicion()
        {
            InitializeComponent();
        }

        private void ClientesEdicion_Load(object sender, EventArgs e)
        {
            cbbTipoPersona.SelectedIndex = 0;
        }

        private void ClientesEdicion_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Esta seguro que desea salir? los cambios no se aplicarán","Advertencia",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
