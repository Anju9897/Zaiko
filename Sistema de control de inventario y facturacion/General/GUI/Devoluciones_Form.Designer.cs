namespace General.GUI
{
    partial class Devoluciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devoluciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtgDetalles = new System.Windows.Forms.DataGridView();
            this.iddetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitadsalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gravado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botones = new System.Windows.Forms.ToolStrip();
            this.tsTipoNota = new System.Windows.Forms.ToolStripLabel();
            this.tsMovimiento = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditarDev = new System.Windows.Forms.ToolStripButton();
            this.tsDocumento = new System.Windows.Forms.ToolStripLabel();
            this.tsIDDEVOLUCION = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminarDev = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFinDev = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
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
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.dtgDevoluciones = new System.Windows.Forms.DataGridView();
            this.iddevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_Dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devGravado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).BeginInit();
            this.botones.SuspendLayout();
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
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtgDetalles);
            this.splitContainer1.Panel1.Controls.Add(this.botones);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1049, 753);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 0;
            // 
            // dtgDetalles
            // 
            this.dtgDetalles.AllowUserToAddRows = false;
            this.dtgDetalles.AllowUserToDeleteRows = false;
            this.dtgDetalles.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddetalle,
            this.cantitadsalida,
            this.producto,
            this.idp,
            this.inventario,
            this.exi,
            this.fecha,
            this.unidades,
            this.precio,
            this.gravado,
            this.montoiva,
            this.subtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDetalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDetalles.Location = new System.Drawing.Point(0, 28);
            this.dtgDetalles.MultiSelect = false;
            this.dtgDetalles.Name = "dtgDetalles";
            this.dtgDetalles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDetalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDetalles.RowHeadersVisible = false;
            this.dtgDetalles.RowTemplate.Height = 24;
            this.dtgDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalles.Size = new System.Drawing.Size(1049, 226);
            this.dtgDetalles.TabIndex = 1;
            this.dtgDetalles.DoubleClick += new System.EventHandler(this.dtgDetalles_DoubleClick);
            this.dtgDetalles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgDetalles_KeyDown);
            // 
            // iddetalle
            // 
            this.iddetalle.DataPropertyName = "iddetalle";
            this.iddetalle.HeaderText = "ID";
            this.iddetalle.Name = "iddetalle";
            this.iddetalle.ReadOnly = true;
            this.iddetalle.Visible = false;
            this.iddetalle.Width = 5;
            // 
            // cantitadsalida
            // 
            this.cantitadsalida.DataPropertyName = "cantitadsalida";
            this.cantitadsalida.HeaderText = "U. Salida";
            this.cantitadsalida.Name = "cantitadsalida";
            this.cantitadsalida.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.producto.DataPropertyName = "producto";
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // idp
            // 
            this.idp.DataPropertyName = "idp";
            this.idp.HeaderText = "idp";
            this.idp.Name = "idp";
            this.idp.ReadOnly = true;
            this.idp.Visible = false;
            // 
            // inventario
            // 
            this.inventario.DataPropertyName = "inventario";
            this.inventario.HeaderText = "inventario";
            this.inventario.Name = "inventario";
            this.inventario.ReadOnly = true;
            this.inventario.Visible = false;
            // 
            // exi
            // 
            this.exi.DataPropertyName = "exi";
            this.exi.HeaderText = "exi";
            this.exi.Name = "exi";
            this.exi.ReadOnly = true;
            this.exi.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Visible = false;
            // 
            // unidades
            // 
            this.unidades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unidades.DataPropertyName = "unidades";
            this.unidades.HeaderText = "Unidad";
            this.unidades.Name = "unidades";
            this.unidades.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // gravado
            // 
            this.gravado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.montoiva.Visible = false;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            this.subtotal.HeaderText = "subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Visible = false;
            // 
            // botones
            // 
            this.botones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.botones.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.botones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTipoNota,
            this.tsMovimiento,
            this.toolStripSeparator1,
            this.btnEditarDev,
            this.tsDocumento,
            this.tsIDDEVOLUCION,
            this.toolStripSeparator2,
            this.btnEliminarDev,
            this.toolStripSeparator3,
            this.btnFinDev});
            this.botones.Location = new System.Drawing.Point(0, 0);
            this.botones.Name = "botones";
            this.botones.Size = new System.Drawing.Size(1049, 28);
            this.botones.TabIndex = 0;
            this.botones.Text = "toolStrip1";
            // 
            // tsTipoNota
            // 
            this.tsTipoNota.ForeColor = System.Drawing.Color.White;
            this.tsTipoNota.Name = "tsTipoNota";
            this.tsTipoNota.Size = new System.Drawing.Size(70, 25);
            this.tsTipoNota.Text = "DEBITO";
            // 
            // tsMovimiento
            // 
            this.tsMovimiento.ForeColor = System.Drawing.Color.White;
            this.tsMovimiento.Name = "tsMovimiento";
            this.tsMovimiento.Size = new System.Drawing.Size(127, 25);
            this.tsMovimiento.Text = "MOVIMIENTO";
            this.tsMovimiento.Visible = false;
            this.tsMovimiento.TextChanged += new System.EventHandler(this.tsMovimiento_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btnEditarDev
            // 
            this.btnEditarDev.ForeColor = System.Drawing.Color.White;
            this.btnEditarDev.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarDev.Image")));
            this.btnEditarDev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarDev.Name = "btnEditarDev";
            this.btnEditarDev.Size = new System.Drawing.Size(207, 25);
            this.btnEditarDev.Text = "Editar Devolucion (E)";
            this.btnEditarDev.Click += new System.EventHandler(this.btnEditarDev_Click);
            // 
            // tsDocumento
            // 
            this.tsDocumento.ForeColor = System.Drawing.Color.White;
            this.tsDocumento.Name = "tsDocumento";
            this.tsDocumento.Size = new System.Drawing.Size(126, 25);
            this.tsDocumento.Text = "DOCUMENTO";
            this.tsDocumento.Visible = false;
            // 
            // tsIDDEVOLUCION
            // 
            this.tsIDDEVOLUCION.Name = "tsIDDEVOLUCION";
            this.tsIDDEVOLUCION.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // btnEliminarDev
            // 
            this.btnEliminarDev.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDev.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarDev.Image")));
            this.btnEliminarDev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarDev.Name = "btnEliminarDev";
            this.btnEliminarDev.Size = new System.Drawing.Size(220, 25);
            this.btnEliminarDev.Text = "Eliminar Devolucion (X)";
            this.btnEliminarDev.Click += new System.EventHandler(this.btnEliminarDev_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // btnFinDev
            // 
            this.btnFinDev.ForeColor = System.Drawing.Color.White;
            this.btnFinDev.Image = ((System.Drawing.Image)(resources.GetObject("btnFinDev.Image")));
            this.btnFinDev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinDev.Name = "btnFinDev";
            this.btnFinDev.Size = new System.Drawing.Size(230, 25);
            this.btnFinDev.Text = "Finalizar Devolucion (F2)";
            this.btnFinDev.Click += new System.EventHandler(this.btnFinDev_Click);
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
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
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
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip2);
            this.splitContainer2.Panel2.Controls.Add(this.dtgDevoluciones);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1049, 495);
            this.splitContainer2.SplitterDistance = 131;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblIDDevolucion
            // 
            this.lblIDDevolucion.AutoSize = true;
            this.lblIDDevolucion.Enabled = false;
            this.lblIDDevolucion.Location = new System.Drawing.Point(264, 38);
            this.lblIDDevolucion.Name = "lblIDDevolucion";
            this.lblIDDevolucion.Size = new System.Drawing.Size(0, 17);
            this.lblIDDevolucion.TabIndex = 33;
            this.lblIDDevolucion.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(790, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Gravado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(790, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "IVA (13%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(459, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Precio Unitario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(769, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(769, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "$";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(622, 98);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(0, 20);
            this.lblUnidad.TabIndex = 25;
            // 
            // txbPrecio
            // 
            this.txbPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPrecio.Enabled = false;
            this.txbPrecio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecio.Location = new System.Drawing.Point(463, 32);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(153, 26);
            this.txbPrecio.TabIndex = 24;
            this.txbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbIVA
            // 
            this.txbIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIVA.Enabled = false;
            this.txbIVA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIVA.Location = new System.Drawing.Point(794, 32);
            this.txbIVA.Name = "txbIVA";
            this.txbIVA.Size = new System.Drawing.Size(163, 26);
            this.txbIVA.TabIndex = 23;
            this.txbIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbSubtotal
            // 
            this.txbSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSubtotal.Enabled = false;
            this.txbSubtotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubtotal.Location = new System.Drawing.Point(794, 93);
            this.txbSubtotal.Name = "txbSubtotal";
            this.txbSubtotal.Size = new System.Drawing.Size(163, 26);
            this.txbSubtotal.TabIndex = 22;
            this.txbSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbCantidad
            // 
            this.txbCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(463, 96);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(153, 26);
            this.txbCantidad.TabIndex = 21;
            this.txbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCantidad.TextChanged += new System.EventHandler(this.txbCantidad_TextChanged);
            this.txbCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCantidad_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID Detalle";
            // 
            // txbProducto
            // 
            this.txbProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProducto.Enabled = false;
            this.txbProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProducto.Location = new System.Drawing.Point(96, 93);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.Size = new System.Drawing.Size(210, 26);
            this.txbProducto.TabIndex = 18;
            this.txbProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbIDDetalle
            // 
            this.txbIDDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIDDetalle.Enabled = false;
            this.txbIDDetalle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDDetalle.Location = new System.Drawing.Point(96, 32);
            this.txbIDDetalle.Name = "txbIDDetalle";
            this.txbIDDetalle.Size = new System.Drawing.Size(100, 26);
            this.txbIDDetalle.TabIndex = 17;
            this.txbIDDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Location = new System.Drawing.Point(0, 338);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1049, 22);
            this.statusStrip2.TabIndex = 1;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // dtgDevoluciones
            // 
            this.dtgDevoluciones.AllowUserToAddRows = false;
            this.dtgDevoluciones.AllowUserToDeleteRows = false;
            this.dtgDevoluciones.AllowUserToResizeColumns = false;
            this.dtgDevoluciones.AllowUserToResizeRows = false;
            this.dtgDevoluciones.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDevoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevoluciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddevolucion,
            this.idd,
            this.idm,
            this.fecha_Dev,
            this.DevProducto,
            this.PrecioVenta,
            this.cEntrada,
            this.devGravado,
            this.DevIVA,
            this.DevSubtotal});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDevoluciones.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgDevoluciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDevoluciones.Location = new System.Drawing.Point(0, 0);
            this.dtgDevoluciones.MultiSelect = false;
            this.dtgDevoluciones.Name = "dtgDevoluciones";
            this.dtgDevoluciones.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDevoluciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgDevoluciones.RowHeadersVisible = false;
            this.dtgDevoluciones.RowTemplate.Height = 24;
            this.dtgDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDevoluciones.Size = new System.Drawing.Size(1049, 360);
            this.dtgDevoluciones.TabIndex = 0;
            this.dtgDevoluciones.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDevoluciones_CellContentDoubleClick);
            this.dtgDevoluciones.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgDevoluciones_RowsAdded);
            this.dtgDevoluciones.DoubleClick += new System.EventHandler(this.dtgDevoluciones_DoubleClick);
            this.dtgDevoluciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgDevoluciones_KeyDown);
            // 
            // iddevolucion
            // 
            this.iddevolucion.DataPropertyName = "iddevolucion";
            this.iddevolucion.HeaderText = "ID";
            this.iddevolucion.Name = "iddevolucion";
            this.iddevolucion.ReadOnly = true;
            this.iddevolucion.Width = 5;
            // 
            // idd
            // 
            this.idd.DataPropertyName = "idd";
            this.idd.HeaderText = "Detalle";
            this.idd.Name = "idd";
            this.idd.ReadOnly = true;
            this.idd.Visible = false;
            // 
            // idm
            // 
            this.idm.DataPropertyName = "idm";
            this.idm.HeaderText = "idmovimiento";
            this.idm.Name = "idm";
            this.idm.ReadOnly = true;
            this.idm.Visible = false;
            // 
            // fecha_Dev
            // 
            this.fecha_Dev.DataPropertyName = "fecha_Dev";
            this.fecha_Dev.HeaderText = "Fecha";
            this.fecha_Dev.Name = "fecha_Dev";
            this.fecha_Dev.ReadOnly = true;
            this.fecha_Dev.Visible = false;
            // 
            // DevProducto
            // 
            this.DevProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DevProducto.DataPropertyName = "DevProducto";
            this.DevProducto.HeaderText = "Producto";
            this.DevProducto.Name = "DevProducto";
            this.DevProducto.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "PrecioVenta";
            this.PrecioVenta.HeaderText = "Precio";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // cEntrada
            // 
            this.cEntrada.DataPropertyName = "cEntrada";
            this.cEntrada.HeaderText = "Cant. Entrada";
            this.cEntrada.Name = "cEntrada";
            this.cEntrada.ReadOnly = true;
            // 
            // devGravado
            // 
            this.devGravado.DataPropertyName = "devGravado";
            this.devGravado.HeaderText = "Gravado";
            this.devGravado.Name = "devGravado";
            this.devGravado.ReadOnly = true;
            // 
            // DevIVA
            // 
            this.DevIVA.DataPropertyName = "DevIVA";
            this.DevIVA.HeaderText = "IVA";
            this.DevIVA.Name = "DevIVA";
            this.DevIVA.ReadOnly = true;
            // 
            // DevSubtotal
            // 
            this.DevSubtotal.DataPropertyName = "DevSubtotal";
            this.DevSubtotal.HeaderText = "Subtotal";
            this.DevSubtotal.Name = "DevSubtotal";
            this.DevSubtotal.ReadOnly = true;
            // 
            // Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1049, 753);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Devoluciones";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones_Form";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).EndInit();
            this.botones.ResumeLayout(false);
            this.botones.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevoluciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        public System.Windows.Forms.ToolStripLabel tsMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitadsalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idp;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn exi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn gravado;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.TextBox txbIDDetalle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripLabel tsDocumento;
        private System.Windows.Forms.ToolStripLabel tsIDDEVOLUCION;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tsTipoNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idm;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_Dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn devGravado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevSubtotal;
        private System.Windows.Forms.ToolStripButton btnEditarDev;
        private System.Windows.Forms.ToolStripButton btnEliminarDev;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnFinDev;
        public System.Windows.Forms.DataGridView dtgDetalles;
        public System.Windows.Forms.ToolStrip botones;
        public System.Windows.Forms.DataGridView dtgDevoluciones;
        public System.Windows.Forms.TextBox txbCantidad;
    }
}