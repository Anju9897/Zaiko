namespace Reportes.GUI
{
    partial class Cotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizaciones));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cvrCotizacion = new System.Windows.Forms.Button();
            this.txbNCotizacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEncargado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.crvCotizacion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.cvrCotizacion);
            this.splitContainer1.Panel1.Controls.Add(this.txbNCotizacion);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txbEncargado);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crvCotizacion);
            this.splitContainer1.Size = new System.Drawing.Size(1244, 803);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(23, 356);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 42);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cvrCotizacion
            // 
            this.cvrCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(56)))), ((int)(((byte)(43)))));
            this.cvrCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cvrCotizacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvrCotizacion.ForeColor = System.Drawing.Color.White;
            this.cvrCotizacion.Location = new System.Drawing.Point(23, 304);
            this.cvrCotizacion.Margin = new System.Windows.Forms.Padding(5);
            this.cvrCotizacion.Name = "cvrCotizacion";
            this.cvrCotizacion.Size = new System.Drawing.Size(168, 42);
            this.cvrCotizacion.TabIndex = 84;
            this.cvrCotizacion.Text = "Vista Previa";
            this.cvrCotizacion.UseVisualStyleBackColor = false;
            this.cvrCotizacion.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // txbNCotizacion
            // 
            this.txbNCotizacion.Enabled = false;
            this.txbNCotizacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNCotizacion.Location = new System.Drawing.Point(23, 268);
            this.txbNCotizacion.Margin = new System.Windows.Forms.Padding(4);
            this.txbNCotizacion.Name = "txbNCotizacion";
            this.txbNCotizacion.Size = new System.Drawing.Size(167, 27);
            this.txbNCotizacion.TabIndex = 80;
            this.txbNCotizacion.TextChanged += new System.EventHandler(this.txbNCotizacion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Cotizacion No.";
            // 
            // txbEncargado
            // 
            this.txbEncargado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEncargado.Location = new System.Drawing.Point(23, 198);
            this.txbEncargado.Margin = new System.Windows.Forms.Padding(4);
            this.txbEncargado.Name = "txbEncargado";
            this.txbEncargado.Size = new System.Drawing.Size(167, 27);
            this.txbEncargado.TabIndex = 78;
            this.txbEncargado.TextChanged += new System.EventHandler(this.txbEncargado_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Acargo de ";
            // 
            // crvCotizacion
            // 
            this.crvCotizacion.ActiveViewIndex = -1;
            this.crvCotizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCotizacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCotizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCotizacion.Location = new System.Drawing.Point(0, 0);
            this.crvCotizacion.Margin = new System.Windows.Forms.Padding(4);
            this.crvCotizacion.Name = "crvCotizacion";
            this.crvCotizacion.Size = new System.Drawing.Size(1029, 803);
            this.crvCotizacion.TabIndex = 0;
            this.crvCotizacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 803);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRCotizacion";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCotizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button cvrCotizacion;
        public System.Windows.Forms.TextBox txbNCotizacion;
        private System.Windows.Forms.TextBox txbEncargado;
        private System.Windows.Forms.Label label4;
    }
}