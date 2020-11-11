namespace General.GUI
{
    partial class ClientesEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesEdicion));
            this.lblCliente = new System.Windows.Forms.Label();
            this.txbIDCliente = new System.Windows.Forms.TextBox();
            this.cbbTipoPersona = new System.Windows.Forms.ComboBox();
            this.errorCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTIpo = new System.Windows.Forms.Label();
            this.txbNombres = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNIT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDUI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbGiro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNRC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(22, 24);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(25, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "ID";
            // 
            // txbIDCliente
            // 
            this.txbIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIDCliente.Enabled = false;
            this.txbIDCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDCliente.Location = new System.Drawing.Point(53, 24);
            this.txbIDCliente.Name = "txbIDCliente";
            this.txbIDCliente.Size = new System.Drawing.Size(100, 26);
            this.txbIDCliente.TabIndex = 1;
            this.txbIDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbTipoPersona
            // 
            this.cbbTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoPersona.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoPersona.FormattingEnabled = true;
            this.cbbTipoPersona.Items.AddRange(new object[] {
            "-- Seleccione una opcion --",
            "Persona Natural",
            "Persona Juridica"});
            this.cbbTipoPersona.Location = new System.Drawing.Point(26, 90);
            this.cbbTipoPersona.Name = "cbbTipoPersona";
            this.cbbTipoPersona.Size = new System.Drawing.Size(226, 28);
            this.cbbTipoPersona.TabIndex = 2;
            this.cbbTipoPersona.SelectedIndexChanged += new System.EventHandler(this.cbbTipoPersona_SelectedIndexChanged);
            // 
            // errorCliente
            // 
            this.errorCliente.ContainerControl = this;
            // 
            // lblTIpo
            // 
            this.lblTIpo.AutoSize = true;
            this.lblTIpo.BackColor = System.Drawing.Color.Transparent;
            this.lblTIpo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIpo.Location = new System.Drawing.Point(22, 67);
            this.lblTIpo.Name = "lblTIpo";
            this.lblTIpo.Size = new System.Drawing.Size(124, 20);
            this.lblTIpo.TabIndex = 7;
            this.lblTIpo.Text = "Tipo de Persona";
            // 
            // txbNombres
            // 
            this.txbNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNombres.Enabled = false;
            this.txbNombres.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombres.Location = new System.Drawing.Point(26, 158);
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.Size = new System.Drawing.Size(226, 26);
            this.txbNombres.TabIndex = 9;
            this.txbNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombres";
            // 
            // txbApellidos
            // 
            this.txbApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApellidos.Enabled = false;
            this.txbApellidos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellidos.Location = new System.Drawing.Point(26, 230);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(226, 26);
            this.txbApellidos.TabIndex = 11;
            this.txbApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellidos";
            // 
            // txbNIT
            // 
            this.txbNIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNIT.Enabled = false;
            this.txbNIT.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNIT.Location = new System.Drawing.Point(26, 367);
            this.txbNIT.Name = "txbNIT";
            this.txbNIT.Size = new System.Drawing.Size(226, 26);
            this.txbNIT.TabIndex = 15;
            this.txbNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNIT.TextChanged += new System.EventHandler(this.txbNIT_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "NIT";
            // 
            // txbDUI
            // 
            this.txbDUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDUI.Enabled = false;
            this.txbDUI.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDUI.Location = new System.Drawing.Point(26, 295);
            this.txbDUI.Name = "txbDUI";
            this.txbDUI.Size = new System.Drawing.Size(226, 26);
            this.txbDUI.TabIndex = 13;
            this.txbDUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbDUI.TextChanged += new System.EventHandler(this.txbDUI_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "DUI";
            // 
            // txbGiro
            // 
            this.txbGiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbGiro.Enabled = false;
            this.txbGiro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGiro.Location = new System.Drawing.Point(294, 90);
            this.txbGiro.Multiline = true;
            this.txbGiro.Name = "txbGiro";
            this.txbGiro.Size = new System.Drawing.Size(226, 65);
            this.txbGiro.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giro";
            // 
            // txbNRC
            // 
            this.txbNRC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNRC.Enabled = false;
            this.txbNRC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNRC.Location = new System.Drawing.Point(294, 31);
            this.txbNRC.Name = "txbNRC";
            this.txbNRC.Size = new System.Drawing.Size(226, 26);
            this.txbNRC.TabIndex = 17;
            this.txbNRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "NRC";
            // 
            // txbDireccion
            // 
            this.txbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDireccion.Enabled = false;
            this.txbDireccion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.Location = new System.Drawing.Point(294, 194);
            this.txbDireccion.Multiline = true;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(226, 76);
            this.txbDireccion.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Direccion";
            // 
            // txbCategoria
            // 
            this.txbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCategoria.Enabled = false;
            this.txbCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoria.Location = new System.Drawing.Point(294, 313);
            this.txbCategoria.Multiline = true;
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(226, 81);
            this.txbCategoria.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Categoria";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(56)))), ((int)(((byte)(43)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(147, 443);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 32);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(294, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 32);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ClientesEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 521);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbGiro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbNRC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbNIT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbDUI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNombres);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTIpo);
            this.Controls.Add(this.cbbTipoPersona);
            this.Controls.Add(this.txbIDCliente);
            this.Controls.Add(this.lblCliente);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientesEdicion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientesEdicion_FormClosed);
            this.Load += new System.EventHandler(this.ClientesEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ErrorProvider errorCliente;
        private System.Windows.Forms.Label lblTIpo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txbIDCliente;
        public System.Windows.Forms.ComboBox cbbTipoPersona;
        public System.Windows.Forms.TextBox txbApellidos;
        public System.Windows.Forms.TextBox txbNombres;
        public System.Windows.Forms.TextBox txbCategoria;
        public System.Windows.Forms.TextBox txbDireccion;
        public System.Windows.Forms.TextBox txbGiro;
        public System.Windows.Forms.TextBox txbNRC;
        public System.Windows.Forms.TextBox txbNIT;
        public System.Windows.Forms.TextBox txbDUI;
    }
}