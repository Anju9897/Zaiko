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
    public partial class VPFacturas_Consumidor_Final : Form
    {
        public int ID1;
       
        public VPFacturas_Consumidor_Final()
        {
            InitializeComponent();
        }
        private void generar()
        {

        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            REP.ReporteFactura_ConsumidorFinal f = new REP.ReporteFactura_ConsumidorFinal();
            f.SetDataSource(CacheManager.CLS.Cache.SQL_CONSUMIDOR_FINAL(ID1));
            crvFacturaConsumidorFINAL.ReportSource = f;
        }
    }
}
