namespace Reportes.GUI
{
    partial class VPFacturas_Consumidor_Final
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
            this.crvFacturaConsumidorFINAL = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvFacturaConsumidorFINAL
            // 
            this.crvFacturaConsumidorFINAL.ActiveViewIndex = -1;
            this.crvFacturaConsumidorFINAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvFacturaConsumidorFINAL.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvFacturaConsumidorFINAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvFacturaConsumidorFINAL.Location = new System.Drawing.Point(0, 0);
            this.crvFacturaConsumidorFINAL.Name = "crvFacturaConsumidorFINAL";
            this.crvFacturaConsumidorFINAL.Size = new System.Drawing.Size(700, 639);
            this.crvFacturaConsumidorFINAL.TabIndex = 0;
            this.crvFacturaConsumidorFINAL.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvFacturaConsumidorFINAL.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // VPFacturas_Consumidor_Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 639);
            this.Controls.Add(this.crvFacturaConsumidorFINAL);
            this.Name = "VPFacturas_Consumidor_Final";
            this.Text = "VistaPrevia Factura Consumidor Final";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvFacturaConsumidorFINAL;
    }
}