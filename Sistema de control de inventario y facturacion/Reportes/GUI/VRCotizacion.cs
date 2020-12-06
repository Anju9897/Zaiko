using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes.GUI
{
    public partial class Cotizaciones : Form
    {
        DataTable _SaveConsulta;
        public Cotizaciones()
        {
            InitializeComponent();
        }
        


        

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                REP.ReporteCotizacion oReporte = new REP.ReporteCotizacion();
                _SaveConsulta = CacheManager.CLS.Cache.CotizacionConsulta(txbNCotizacion.Text);
                oReporte.SetDataSource(_SaveConsulta);
                crvCotizacion.ReportSource = oReporte;

                oReporte.SetParameterValue("pEncargado", txbEncargado.Text);
                Show();
            }
            catch
            {
                
                throw;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbEncargado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNCotizacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
