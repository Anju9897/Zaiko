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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cronometro.Stop();
            Close();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Cronometro.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 500)
            {
                Crono.Stop();
                this.Hide();
            }
        }

      

    }
}
