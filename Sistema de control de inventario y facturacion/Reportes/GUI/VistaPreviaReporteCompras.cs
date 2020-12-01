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
    public partial class Compras : Form
    {
        DataTable _SaveConsulta;

      //public void Generar(DataTable ConsultaRe, int Bandera)
      //  {
      //      if (Bandera == 1)
      //      {
      //      REP.VentaCreditoFiscal oReporte = new REP.VentaCreditoFiscal();
           

      //      }
      //      else if (Bandera == 2)
      //      {
      //          REP.VentaConsumidorFinal oReporte = new REP.VentaConsumidorFinal();
      //          oReporte.SetDataSource(ConsultaRe);
      //          crvCompras.ReportSource = oReporte;

      //      }
      //      else
      //      {
      //          REP.ReporteCompras oReporte = new REP.ReporteCompras();
      //          oReporte.SetDataSource(ConsultaRe);
      //          crvCompras.ReportSource = oReporte;

      //      }
      //  }

        public Compras()
        {
            InitializeComponent();
            cbbTipoReporte.SelectedIndex = 0;
            cbbComrobante.SelectedIndex = 0;
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                // REPORTES VENNTAS CONTRIBUYENTE - CREDITOS FISCALES 1
                if (cbbTipoReporte.Text.Equals("Venta"))
                {
                    if (cbbComrobante.Text.Equals("Comprobante de Credito fiscal"))
                    {
                        REP.VentaCreditoFiscal oReporte = new REP.VentaCreditoFiscal();
                        _SaveConsulta = CacheManager.CLS.Cache.VentaCreditoFiscal(dtpInicial.Text, dtpFinal.Text);
                        oReporte.SetDataSource(_SaveConsulta);
                        crvCompras.ReportSource = oReporte;
                        oReporte.SetParameterValue("FA", DateTime.Now.ToString("yyyy-MM-dd"));
                        oReporte.SetParameterValue("pFechaInicial", dtpInicial.Text);
                        oReporte.SetParameterValue("pFechaFinal", dtpFinal.Text);
                        Show();
                    }
                    // REPORTES VENNTAS CONSUMIDOR FINAL 2
                    else if (cbbComrobante.Text.Equals("Factura consumidor final"))
                    {
                        REP.VentaConsumidorFinal oReporte = new REP.VentaConsumidorFinal();
                        _SaveConsulta = CacheManager.CLS.Cache.VentaConsumidorFinal(dtpInicial.Text, dtpFinal.Text);
                        oReporte.SetDataSource(_SaveConsulta);
                        crvCompras.ReportSource = oReporte;
                        oReporte.SetParameterValue("FA", DateTime.Now.ToString("yyyy-MM-dd"));
                        oReporte.SetParameterValue("pFechaInicial", dtpInicial.Text);
                        oReporte.SetParameterValue("pFechaFinal", dtpFinal.Text);
                        Show();

                    }
                }
                // REPORTES COMPRAS  - CREDITOS FISCALES 3
                else if (cbbTipoReporte.Text.Equals("Compra") && cbbComrobante.Text.Equals("Comprobante de Credito fiscal"))
                {
                    REP.ReporteCompras oReporte = new REP.ReporteCompras();

                    _SaveConsulta = CacheManager.CLS.Cache.CompraCreditoFiscal(dtpInicial.Text, dtpFinal.Text);
                    oReporte.SetDataSource(_SaveConsulta);
                    crvCompras.ReportSource = oReporte;
                    oReporte.SetParameterValue("FA", DateTime.Now.ToString("yyyy-MM-dd"));
                    oReporte.SetParameterValue("pFechaInicial", dtpInicial.Text);
                    oReporte.SetParameterValue("pFechaFinal", dtpFinal.Text);
                    Show();
                }
                else if (cbbTipoReporte.Text.Equals("Productos mas Vendidos"))
                {
                    REP.ReporteProductosMasVendidos oReporte = new REP.ReporteProductosMasVendidos();

                    _SaveConsulta = CacheManager.CLS.Cache.SQL_PRODUCTOS_MAS_VENDIDOS(dtpInicial.Text, dtpFinal.Text);
                    oReporte.SetDataSource(_SaveConsulta);
                    crvCompras.ReportSource = oReporte;
                   //oReporte.SetParameterValue("FA", DateTime.Now.ToString("yyyy-MM-dd"));
                   oReporte.SetParameterValue("pFechaInicial", dtpInicial.Text);
                   oReporte.SetParameterValue("pFechaFinal", dtpFinal.Text);
                    Show();
                   
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

        private void cbbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTipoReporte.SelectedIndex == 1)
            {
                cbbComrobante.SelectedIndex = 1;
            }
        }

        private void cbbComrobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTipoReporte.SelectedIndex == 1 && cbbComrobante.SelectedIndex == 0)
            {
                    MessageBox.Show("Este tipo de documento no es permitido para el reporte de " + cbbTipoReporte.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbComrobante.SelectedIndex = 1;
            }
        }

        private void crvCompras_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
