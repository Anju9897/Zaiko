namespace Reportes.GUI
{
    partial class VP_Factura_CREDITOFISCAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvFacturaCreditoFiscal = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvFacturaCreditoFiscal
            // 
            this.crvFacturaCreditoFiscal.ActiveViewIndex = -1;
            this.crvFacturaCreditoFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvFacturaCreditoFiscal.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvFacturaCreditoFiscal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvFacturaCreditoFiscal.Location = new System.Drawing.Point(0, 0);
            this.crvFacturaCreditoFiscal.Name = "crvFacturaCreditoFiscal";
            this.crvFacturaCreditoFiscal.Size = new System.Drawing.Size(793, 253);
            this.crvFacturaCreditoFiscal.TabIndex = 0;
            this.crvFacturaCreditoFiscal.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvFacturaCreditoFiscal.Load += new System.EventHandler(this.crvFacturaCreditoFiscal_Load);
            // 
            // VP_Factura_CREDITOFISCAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 253);
            this.Controls.Add(this.crvFacturaCreditoFiscal);
            this.Name = "VP_Factura_CREDITOFISCAL";
            this.Text = "VP_Factura_CREDITOFISCAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VP_Factura_CREDITOFISCAL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvFacturaCreditoFiscal;
    }
}