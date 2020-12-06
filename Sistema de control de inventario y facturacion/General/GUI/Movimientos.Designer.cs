namespace General.GUI
{
    partial class Movimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movimientos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblComprobante = new System.Windows.Forms.Label();
            this.cbbComprobante = new System.Windows.Forms.ComboBox();
            this.btnEmitirCotizacion = new System.Windows.Forms.Button();
            this.lblfiltro3 = new System.Windows.Forms.Label();
            this.cbbTransaccion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dtgFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtgFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtgMovimiento = new System.Windows.Forms.DataGridView();
            this.idmovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPERSONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVATOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucion = new System.Windows.Forms.DataGridViewImageColumn();
            this.Imprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propietariocuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btneditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditarProductos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.txbFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dtsCompras1 = new Reportes.DAT.dtsCompras();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovimiento)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCompras1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.lblComprobante);
            this.splitContainer1.Panel1.Controls.Add(this.cbbComprobante);
            this.splitContainer1.Panel1.Controls.Add(this.btnEmitirCotizacion);
            this.splitContainer1.Panel1.Controls.Add(this.lblfiltro3);
            this.splitContainer1.Panel1.Controls.Add(this.cbbTransaccion);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblFiltro);
            this.splitContainer1.Panel1.Controls.Add(this.btnMostrar);
            this.splitContainer1.Panel1.Controls.Add(this.dtgFecha2);
            this.splitContainer1.Panel1.Controls.Add(this.dtgFecha1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgMovimiento);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1616, 730);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblComprobante
            // 
            this.lblComprobante.AutoSize = true;
            this.lblComprobante.BackColor = System.Drawing.Color.Transparent;
            this.lblComprobante.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobante.Location = new System.Drawing.Point(24, 346);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(148, 21);
            this.lblComprobante.TabIndex = 11;
            this.lblComprobante.Text = "T. Comprobante";
            // 
            // cbbComprobante
            // 
            this.cbbComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbComprobante.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbComprobante.FormattingEnabled = true;
            this.cbbComprobante.Items.AddRange(new object[] {
            "Todos",
            "Factura Consumidor Final",
            "Comprobante de Credito Fiscal"});
            this.cbbComprobante.Location = new System.Drawing.Point(25, 370);
            this.cbbComprobante.Name = "cbbComprobante";
            this.cbbComprobante.Size = new System.Drawing.Size(143, 28);
            this.cbbComprobante.TabIndex = 10;
            this.cbbComprobante.SelectedIndexChanged += new System.EventHandler(this.cbbComprobante_SelectedIndexChanged);
            // 
            // btnEmitirCotizacion
            // 
            this.btnEmitirCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(56)))), ((int)(((byte)(43)))));
            this.btnEmitirCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirCotizacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnEmitirCotizacion.Location = new System.Drawing.Point(28, 493);
            this.btnEmitirCotizacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmitirCotizacion.Name = "btnEmitirCotizacion";
            this.btnEmitirCotizacion.Size = new System.Drawing.Size(111, 61);
            this.btnEmitirCotizacion.TabIndex = 9;
            this.btnEmitirCotizacion.Text = "Emitir Cotizacion";
            this.btnEmitirCotizacion.UseVisualStyleBackColor = false;
            this.btnEmitirCotizacion.Click += new System.EventHandler(this.btnEmitirCotizacion_Click);
            // 
            // lblfiltro3
            // 
            this.lblfiltro3.AutoSize = true;
            this.lblfiltro3.BackColor = System.Drawing.Color.Transparent;
            this.lblfiltro3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltro3.Location = new System.Drawing.Point(21, 424);
            this.lblfiltro3.Name = "lblfiltro3";
            this.lblfiltro3.Size = new System.Drawing.Size(110, 21);
            this.lblfiltro3.TabIndex = 8;
            this.lblfiltro3.Text = "Transaccion";
            // 
            // cbbTransaccion
            // 
            this.cbbTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTransaccion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTransaccion.FormattingEnabled = true;
            this.cbbTransaccion.Items.AddRange(new object[] {
            "Venta",
            "Cotizacion"});
            this.cbbTransaccion.Location = new System.Drawing.Point(24, 448);
            this.cbbTransaccion.Name = "cbbTransaccion";
            this.cbbTransaccion.Size = new System.Drawing.Size(142, 28);
            this.cbbTransaccion.TabIndex = 7;
            this.cbbTransaccion.SelectedIndexChanged += new System.EventHandler(this.cbbTransaccion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(24, 101);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(147, 21);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Filtrar por fechas";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(56)))), ((int)(((byte)(43)))));
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(24, 285);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(111, 38);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dtgFecha2
            // 
            this.dtgFecha2.CustomFormat = "yyyy-MM-dd";
            this.dtgFecha2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgFecha2.Location = new System.Drawing.Point(24, 244);
            this.dtgFecha2.Name = "dtgFecha2";
            this.dtgFecha2.Size = new System.Drawing.Size(143, 28);
            this.dtgFecha2.TabIndex = 3;
            this.dtgFecha2.TabStop = false;
            // 
            // dtgFecha1
            // 
            this.dtgFecha1.CustomFormat = "yyyy-MM-dd";
            this.dtgFecha1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgFecha1.Location = new System.Drawing.Point(24, 169);
            this.dtgFecha1.Name = "dtgFecha1";
            this.dtgFecha1.Size = new System.Drawing.Size(143, 28);
            this.dtgFecha1.TabIndex = 2;
            this.dtgFecha1.TabStop = false;
            // 
            // dtgMovimiento
            // 
            this.dtgMovimiento.AllowUserToAddRows = false;
            this.dtgMovimiento.AllowUserToDeleteRows = false;
            this.dtgMovimiento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(199)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(157)))), ((int)(((byte)(42)))));
            this.dtgMovimiento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMovimiento.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMovimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMovimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmovimiento,
            this.IDPERSONA,
            this.fecha,
            this.cliente,
            this.Transaccion,
            this.tipoComprobante,
            this.numComprobante,
            this.estado,
            this.condpago,
            this.Subtotal,
            this.IVATOTAL,
            this.total,
            this.devolucion,
            this.Imprimir,
            this.banco,
            this.propietariocuenta,
            this.ncuenta});
            this.dtgMovimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMovimiento.Location = new System.Drawing.Point(0, 28);
            this.dtgMovimiento.MultiSelect = false;
            this.dtgMovimiento.Name = "dtgMovimiento";
            this.dtgMovimiento.ReadOnly = true;
            this.dtgMovimiento.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(157)))), ((int)(((byte)(42)))));
            this.dtgMovimiento.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgMovimiento.RowTemplate.Height = 24;
            this.dtgMovimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMovimiento.Size = new System.Drawing.Size(1436, 676);
            this.dtgMovimiento.TabIndex = 1;
            this.dtgMovimiento.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMovimiento_CellMouseDoubleClick);
            this.dtgMovimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgMovimiento_KeyDown);
            // 
            // idmovimiento
            // 
            this.idmovimiento.DataPropertyName = "idmovimiento";
            this.idmovimiento.HeaderText = "ID";
            this.idmovimiento.Name = "idmovimiento";
            this.idmovimiento.ReadOnly = true;
            this.idmovimiento.Width = 40;
            // 
            // IDPERSONA
            // 
            this.IDPERSONA.DataPropertyName = "IDPERSONA";
            this.IDPERSONA.HeaderText = "IDPERSONA";
            this.IDPERSONA.Name = "IDPERSONA";
            this.IDPERSONA.ReadOnly = true;
            this.IDPERSONA.Visible = false;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // Transaccion
            // 
            this.Transaccion.DataPropertyName = "Transaccion";
            this.Transaccion.HeaderText = "";
            this.Transaccion.Name = "Transaccion";
            this.Transaccion.ReadOnly = true;
            this.Transaccion.Visible = false;
            // 
            // tipoComprobante
            // 
            this.tipoComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoComprobante.DataPropertyName = "tipoComprobante";
            this.tipoComprobante.HeaderText = "Comprobante";
            this.tipoComprobante.Name = "tipoComprobante";
            this.tipoComprobante.ReadOnly = true;
            // 
            // numComprobante
            // 
            this.numComprobante.DataPropertyName = "numComprobante";
            this.numComprobante.HeaderText = "Número";
            this.numComprobante.Name = "numComprobante";
            this.numComprobante.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // condpago
            // 
            this.condpago.DataPropertyName = "condpago";
            this.condpago.HeaderText = "Condicion";
            this.condpago.Name = "condpago";
            this.condpago.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "Subtotal";
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // IVATOTAL
            // 
            this.IVATOTAL.DataPropertyName = "IVATOTAL";
            this.IVATOTAL.HeaderText = "IVA";
            this.IVATOTAL.Name = "IVATOTAL";
            this.IVATOTAL.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // devolucion
            // 
            this.devolucion.DataPropertyName = "devolucion";
            this.devolucion.HeaderText = "Devolucion";
            this.devolucion.Image = ((System.Drawing.Image)(resources.GetObject("devolucion.Image")));
            this.devolucion.Name = "devolucion";
            this.devolucion.ReadOnly = true;
            // 
            // Imprimir
            // 
            this.Imprimir.DataPropertyName = "Imprimir";
            this.Imprimir.HeaderText = "Imprimir";
            this.Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Imprimir.Image")));
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.ReadOnly = true;
            // 
            // banco
            // 
            this.banco.DataPropertyName = "banco";
            this.banco.HeaderText = "banco";
            this.banco.Name = "banco";
            this.banco.ReadOnly = true;
            this.banco.Visible = false;
            // 
            // propietariocuenta
            // 
            this.propietariocuenta.DataPropertyName = "propietariocuenta";
            this.propietariocuenta.HeaderText = "propietario";
            this.propietariocuenta.Name = "propietariocuenta";
            this.propietariocuenta.ReadOnly = true;
            this.propietariocuenta.Visible = false;
            // 
            // ncuenta
            // 
            this.ncuenta.DataPropertyName = "ncuenta";
            this.ncuenta.HeaderText = "cuenta";
            this.ncuenta.Name = "ncuenta";
            this.ncuenta.ReadOnly = true;
            this.ncuenta.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.statusStrip1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1436, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.TabStop = true;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRegistros
            // 
            this.lblRegistros.ForeColor = System.Drawing.Color.White;
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(206, 21);
            this.lblRegistros.Text = "0 Registros Encontrados";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEliminar,
            this.toolStripSeparator1,
            this.btneditar,
            this.toolStripSeparator2,
            this.btnEditarProductos,
            this.toolStripSeparator3,
            this.btnAgregar,
            this.txbFiltro,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1436, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 25);
            this.btnEliminar.Text = "Anular (X)";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btneditar
            // 
            this.btneditar.AutoSize = false;
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(150, 25);
            this.btneditar.Text = "Editar Cliente";
            this.btneditar.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // btnEditarProductos
            // 
            this.btnEditarProductos.AutoSize = false;
            this.btnEditarProductos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProductos.ForeColor = System.Drawing.Color.White;
            this.btnEditarProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProductos.Image")));
            this.btnEditarProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarProductos.Name = "btnEditarProductos";
            this.btnEditarProductos.Size = new System.Drawing.Size(225, 25);
            this.btnEditarProductos.Text = "Editar Movimientos";
            this.btnEditarProductos.Click += new System.EventHandler(this.transaccionToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 25);
            this.btnAgregar.Text = "Agregar (A)";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txbFiltro
            // 
            this.txbFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txbFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFiltro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(250, 28);
            this.txbFiltro.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbFiltro.TextChanged += new System.EventHandler(this.txbFiltro_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 25);
            this.toolStripLabel1.Text = "Filtrar (F1)";
            // 
            // dtsCompras1
            // 
            this.dtsCompras1.DataSetName = "dtsCompras";
            this.dtsCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 730);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Movimientos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Movimientos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovimiento)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCompras1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtgFecha2;
        private System.Windows.Forms.DateTimePicker dtgFecha1;
        private System.Windows.Forms.DataGridView dtgMovimiento;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox txbFiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistros;
        private Reportes.DAT.dtsCompras dtsCompras1;
        private System.Windows.Forms.ComboBox cbbTransaccion;
        private System.Windows.Forms.Label lblfiltro3;
        private System.Windows.Forms.Button btnEmitirCotizacion;
        private System.Windows.Forms.ToolStripButton btnEditarProductos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btneditar;
        private System.Windows.Forms.Label lblComprobante;
        private System.Windows.Forms.ComboBox cbbComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPERSONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn numComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn condpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVATOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn devolucion;
        private System.Windows.Forms.DataGridViewImageColumn Imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn propietariocuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncuenta;
    }
}