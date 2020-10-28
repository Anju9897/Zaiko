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
    public partial class PruebaConector : Form
    {
        public PruebaConector()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataManager.CLS.DBOperacion oOperaciones = new DataManager.CLS.DBOperacion();
            dtgDatos.DataSource = oOperaciones.Consultar(txbConsulta.Text);
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            DataManager.CLS.DBOperacion oOperacion = new DataManager.CLS.DBOperacion();
            Int32 filas_afectadas = 0;
            filas_afectadas = oOperacion.Insertar(txbSentencia.Text);
            MessageBox.Show(filas_afectadas.ToString() + " Registros Afectados");
        }
    }
}
