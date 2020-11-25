namespace General.GUI
{
    partial class ProductoEdicion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEdicion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbUnidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIDProducto = new System.Windows.Forms.Label();
            this.txbExistencias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIDInventario = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.btnMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "   DATOS DEL PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.BackColor = System.Drawing.Color.Transparent;
            this.Codigo.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(59, 85);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(60, 19);
            this.Codigo.TabIndex = 2;
            this.Codigo.Text = "Codigo";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.Location = new System.Drawing.Point(58, 108);
            this.txbCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(164, 24);
            this.txbCodigo.TabIndex = 1;
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(259, 108);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(199, 24);
            this.txbNombre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Marca";
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoria.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(187, 232);
            this.cbbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(125, 25);
            this.cbbCategoria.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Categoria";
            // 
            // cbbUnidad
            // 
            this.cbbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUnidad.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUnidad.FormattingEnabled = true;
            this.cbbUnidad.Location = new System.Drawing.Point(188, 167);
            this.cbbUnidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbUnidad.Name = "cbbUnidad";
            this.cbbUnidad.Size = new System.Drawing.Size(125, 25);
            this.cbbUnidad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unidad";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecio.Location = new System.Drawing.Point(58, 233);
            this.txbPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(89, 24);
            this.txbPrecio.TabIndex = 6;
            this.txbPrecio.Text = "0.00";
            this.txbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescripcion.Location = new System.Drawing.Point(58, 296);
            this.txbDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(255, 55);
            this.txbDescripcion.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Descripcion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(56)))), ((int)(((byte)(43)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(151, 424);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 45);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(299, 424);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 45);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar ";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.AutoSize = true;
            this.lblIDProducto.Enabled = false;
            this.lblIDProducto.Location = new System.Drawing.Point(68, 379);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(0, 17);
            this.lblIDProducto.TabIndex = 21;
            this.lblIDProducto.Visible = false;
            // 
            // txbExistencias
            // 
            this.txbExistencias.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbExistencias.Location = new System.Drawing.Point(58, 168);
            this.txbExistencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbExistencias.Name = "txbExistencias";
            this.txbExistencias.Size = new System.Drawing.Size(89, 24);
            this.txbExistencias.TabIndex = 4;
            this.txbExistencias.Text = "0.00";
            this.txbExistencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Existencias";
            // 
            // lblIDInventario
            // 
            this.lblIDInventario.AutoSize = true;
            this.lblIDInventario.Enabled = false;
            this.lblIDInventario.Location = new System.Drawing.Point(119, 379);
            this.lblIDInventario.Name = "lblIDInventario";
            this.lblIDInventario.Size = new System.Drawing.Size(0, 17);
            this.lblIDInventario.TabIndex = 24;
            this.lblIDInventario.Visible = false;
            // 
            // txbMarca
            // 
            this.txbMarca.Enabled = false;
            this.txbMarca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMarca.Location = new System.Drawing.Point(357, 168);
            this.txbMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(64, 26);
            this.txbMarca.TabIndex = 25;
            this.txbMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbMarca.TextChanged += new System.EventHandler(this.txbMarca_TextChanged);
            // 
            // btnMarca
            // 
            this.btnMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMarca.Location = new System.Drawing.Point(441, 161);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(63, 33);
            this.btnMarca.TabIndex = 26;
            this.btnMarca.Text = "...";
            this.btnMarca.UseVisualStyleBackColor = false;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // ProductoEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 496);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.lblIDInventario);
            this.Controls.Add(this.txbExistencias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblIDProducto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbUnidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductoEdicion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductoEdicion";
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txbCodigo;
        public System.Windows.Forms.TextBox txbNombre;
        public System.Windows.Forms.ComboBox cbbCategoria;
        public System.Windows.Forms.ComboBox cbbUnidad;
        public System.Windows.Forms.TextBox txbPrecio;
        public System.Windows.Forms.TextBox txbDescripcion;
        public System.Windows.Forms.TextBox txbExistencias;
        public System.Windows.Forms.Label lblIDProducto;
        public System.Windows.Forms.Label lblIDInventario;
        private System.Windows.Forms.Button btnMarca;
        public System.Windows.Forms.TextBox txbMarca;
    }
}