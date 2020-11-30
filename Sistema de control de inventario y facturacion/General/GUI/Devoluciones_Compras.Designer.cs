namespace General.GUI
{
    partial class Devoluciones_Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devoluciones_Compras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dtgDetallesCompras = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dtgDevoluciones = new System.Windows.Forms.DataGridView();
            this.lblIDDevolucion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbIVA = new System.Windows.Forms.TextBox();
            this.txbSubtotal = new System.Windows.Forms.TextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.txbIDDetalle = new System.Windows.Forms.TextBox();
            this.iddetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gravado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallesCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtgDetallesCompras);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(964, 669);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(964, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dtgDetallesCompras
            // 
            this.dtgDetallesCompras.AllowUserToAddRows = false;
            this.dtgDetallesCompras.AllowUserToDeleteRows = false;
            this.dtgDetallesCompras.AllowUserToResizeColumns = false;
            this.dtgDetallesCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgDetallesCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDetallesCompras.BackgroundColor = System.Drawing.Color.White;
            this.dtgDetallesCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetallesCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddetalle,
            this.inventario,
            this.idp,
            this.exi,
            this.Producto,
            this.Costo,
            this.CantidadEntrada,
            this.unidades,
            this.gravado,
            this.montoiva,
            this.subtotal,
            this.fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDetallesCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDetallesCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDetallesCompras.Location = new System.Drawing.Point(0, 25);
            this.dtgDetallesCompras.Name = "dtgDetallesCompras";
            this.dtgDetallesCompras.ReadOnly = true;
            this.dtgDetallesCompras.RowHeadersVisible = false;
            this.dtgDetallesCompras.RowTemplate.Height = 24;
            this.dtgDetallesCompras.Size = new System.Drawing.Size(964, 146);
            this.dtgDetallesCompras.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.Controls.Add(this.lblIDDevolucion);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.lblUnidad);
            this.splitContainer2.Panel1.Controls.Add(this.txbPrecio);
            this.splitContainer2.Panel1.Controls.Add(this.txbIVA);
            this.splitContainer2.Panel1.Controls.Add(this.txbSubtotal);
            this.splitContainer2.Panel1.Controls.Add(this.txbCantidad);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txbProducto);
            this.splitContainer2.Panel1.Controls.Add(this.txbIDDetalle);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dtgDevoluciones);
            this.splitContainer2.Size = new System.Drawing.Size(964, 494);
            this.splitContainer2.SplitterDistance = 163;
            this.splitContainer2.TabIndex = 0;
            // 
            // dtgDevoluciones
            // 
            this.dtgDevoluciones.AllowUserToAddRows = false;
            this.dtgDevoluciones.AllowUserToDeleteRows = false;
            this.dtgDevoluciones.AllowUserToResizeColumns = false;
            this.dtgDevoluciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgDevoluciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDevoluciones.BackgroundColor = System.Drawing.Color.White;
            this.dtgDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDevoluciones.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDevoluciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDevoluciones.Location = new System.Drawing.Point(0, 0);
            this.dtgDevoluciones.Name = "dtgDevoluciones";
            this.dtgDevoluciones.ReadOnly = true;
            this.dtgDevoluciones.RowTemplate.Height = 24;
            this.dtgDevoluciones.Size = new System.Drawing.Size(964, 327);
            this.dtgDevoluciones.TabIndex = 2;
            // 
            // lblIDDevolucion
            // 
            this.lblIDDevolucion.AutoSize = true;
            this.lblIDDevolucion.Enabled = false;
            this.lblIDDevolucion.Location = new System.Drawing.Point(222, 54);
            this.lblIDDevolucion.Name = "lblIDDevolucion";
            this.lblIDDevolucion.Size = new System.Drawing.Size(0, 17);
            this.lblIDDevolucion.TabIndex = 50;
            this.lblIDDevolucion.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(748, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Gravado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(748, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "IVA (13%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Precio Unitario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(727, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(727, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "$";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(580, 114);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(0, 20);
            this.lblUnidad.TabIndex = 42;
            // 
            // txbPrecio
            // 
            this.txbPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPrecio.Enabled = false;
            this.txbPrecio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecio.Location = new System.Drawing.Point(421, 48);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(153, 26);
            this.txbPrecio.TabIndex = 41;
            this.txbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbIVA
            // 
            this.txbIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIVA.Enabled = false;
            this.txbIVA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIVA.Location = new System.Drawing.Point(752, 48);
            this.txbIVA.Name = "txbIVA";
            this.txbIVA.Size = new System.Drawing.Size(163, 26);
            this.txbIVA.TabIndex = 40;
            this.txbIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbSubtotal
            // 
            this.txbSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSubtotal.Enabled = false;
            this.txbSubtotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubtotal.Location = new System.Drawing.Point(752, 109);
            this.txbSubtotal.Name = "txbSubtotal";
            this.txbSubtotal.Size = new System.Drawing.Size(163, 26);
            this.txbSubtotal.TabIndex = 39;
            this.txbSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbCantidad
            // 
            this.txbCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(421, 112);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(153, 26);
            this.txbCantidad.TabIndex = 38;
            this.txbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID Detalle";
            // 
            // txbProducto
            // 
            this.txbProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProducto.Enabled = false;
            this.txbProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProducto.Location = new System.Drawing.Point(54, 109);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.Size = new System.Drawing.Size(210, 26);
            this.txbProducto.TabIndex = 35;
            this.txbProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbIDDetalle
            // 
            this.txbIDDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIDDetalle.Enabled = false;
            this.txbIDDetalle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDDetalle.Location = new System.Drawing.Point(54, 48);
            this.txbIDDetalle.Name = "txbIDDetalle";
            this.txbIDDetalle.Size = new System.Drawing.Size(100, 26);
            this.txbIDDetalle.TabIndex = 34;
            this.txbIDDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iddetalle
            // 
            this.iddetalle.DataPropertyName = "iddetalle";
            this.iddetalle.HeaderText = "ID";
            this.iddetalle.Name = "iddetalle";
            this.iddetalle.ReadOnly = true;
            // 
            // inventario
            // 
            this.inventario.DataPropertyName = "inventario";
            this.inventario.HeaderText = "Inventario";
            this.inventario.Name = "inventario";
            this.inventario.ReadOnly = true;
            this.inventario.Visible = false;
            // 
            // idp
            // 
            this.idp.DataPropertyName = "idp";
            this.idp.HeaderText = "idp";
            this.idp.Name = "idp";
            this.idp.ReadOnly = true;
            this.idp.Visible = false;
            // 
            // exi
            // 
            this.exi.DataPropertyName = "exi";
            this.exi.HeaderText = "Existencias";
            this.exi.Name = "exi";
            this.exi.ReadOnly = true;
            this.exi.Visible = false;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // CantidadEntrada
            // 
            this.CantidadEntrada.DataPropertyName = "CantidadEntrada";
            this.CantidadEntrada.HeaderText = "U. Entrada";
            this.CantidadEntrada.Name = "CantidadEntrada";
            this.CantidadEntrada.ReadOnly = true;
            // 
            // unidades
            // 
            this.unidades.DataPropertyName = "unidades";
            this.unidades.HeaderText = "Unidad";
            this.unidades.Name = "unidades";
            this.unidades.ReadOnly = true;
            // 
            // gravado
            // 
            this.gravado.DataPropertyName = "gravado";
            this.gravado.HeaderText = "Gravado";
            this.gravado.Name = "gravado";
            this.gravado.ReadOnly = true;
            // 
            // montoiva
            // 
            this.montoiva.DataPropertyName = "montoiva";
            this.montoiva.HeaderText = "IVA";
            this.montoiva.Name = "montoiva";
            this.montoiva.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // Devoluciones_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 669);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Devoluciones_Compras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones_Compras";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallesCompras)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevoluciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtgDetallesCompras;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dtgDevoluciones;
        private System.Windows.Forms.Label lblIDDevolucion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.TextBox txbIVA;
        private System.Windows.Forms.TextBox txbSubtotal;
        public System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.TextBox txbIDDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idp;
        private System.Windows.Forms.DataGridViewTextBoxColumn exi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn gravado;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}