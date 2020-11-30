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
    public partial class VP_Factura_CREDITOFISCAL : Form
    {
        public int ID1;
        public VP_Factura_CREDITOFISCAL()
        {
            InitializeComponent();
        }

        private void VP_Factura_CREDITOFISCAL_Load(object sender, EventArgs e)
        {
            REP.ReporteFactura_CREDITO_FISCAL f = new REP.ReporteFactura_CREDITO_FISCAL();
            f.SetDataSource(CacheManager.CLS.Cache.SQL_CREDITO_FISCAL(ID1));
            crvFacturaCreditoFiscal.ReportSource = f;
        }

        private void crvFacturaCreditoFiscal_Load(object sender, EventArgs e)
        {

        }
    }
}
