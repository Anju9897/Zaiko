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
    public partial class VPCARDEX_X_PRODUCTO : Form
    {

        public int ID1;

        public VPCARDEX_X_PRODUCTO()
        {
            InitializeComponent();
        }

        private void VPCARDEX_X_PRODUCTO_Load(object sender, EventArgs e)
        {
            REP.Reporte_Cardex_Prodicto f = new REP.Reporte_Cardex_Prodicto();
            f.SetDataSource(CacheManager.CLS.Cache.SQL_CARDEX_PORPRODUCTO(ID1));
            crvCARDEX_PRODUCTO.ReportSource = f;
        }
        
    }
}
