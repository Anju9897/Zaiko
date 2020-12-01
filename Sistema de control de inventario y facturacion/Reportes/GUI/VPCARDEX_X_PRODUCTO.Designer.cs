namespace Reportes.GUI
{
    partial class VPCARDEX_X_PRODUCTO
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
            this.crvCARDEX_PRODUCTO = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCARDEX_PRODUCTO
            // 
            this.crvCARDEX_PRODUCTO.ActiveViewIndex = -1;
            this.crvCARDEX_PRODUCTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCARDEX_PRODUCTO.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCARDEX_PRODUCTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCARDEX_PRODUCTO.Location = new System.Drawing.Point(0, 0);
            this.crvCARDEX_PRODUCTO.Name = "crvCARDEX_PRODUCTO";
            this.crvCARDEX_PRODUCTO.Size = new System.Drawing.Size(699, 639);
            this.crvCARDEX_PRODUCTO.TabIndex = 0;
            this.crvCARDEX_PRODUCTO.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VPCARDEX_X_PRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 639);
            this.Controls.Add(this.crvCARDEX_PRODUCTO);
            this.Name = "VPCARDEX_X_PRODUCTO";
            this.Text = "VPCARDEX_X_PRODUCTO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VPCARDEX_X_PRODUCTO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCARDEX_PRODUCTO;
    }
}