namespace General.GUI
{
    partial class ClienteInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteInfo));
            this.txbIDMov = new System.Windows.Forms.TextBox();
            this.txbNFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbbFactura = new System.Windows.Forms.ComboBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNIT = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbNRC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbCondPago = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorMovimiento = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.cbbTransaccion = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbIDCliente = new System.Windows.Forms.TextBox();
            this.txbDUI = new System.Windows.Forms.TextBox();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.txtCuenta = new System.Windows.Forms.Label();
            this.txtPropietario = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // txbIDMov
            // 
            this.txbIDMov.Enabled = false;
            this.txbIDMov.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDMov.Location = new System.Drawing.Point(119, 65);
            this.txbIDMov.Name = "txbIDMov";
            this.txbIDMov.Size = new System.Drawing.Size(100, 28);
            this.txbIDMov.TabIndex = 0;
            // 
            // txbNFactura
            // 
            this.txbNFactura.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNFactura.Location = new System.Drawing.Point(119, 262);
            this.txbNFactura.Name = "txbNFactura";
            this.txbNFactura.Size = new System.Drawing.Size(251, 28);
            this.txbNFactura.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(119, 129);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(251, 28);
            this.dtpFecha.TabIndex = 2;
            // 
            // cbbFactura
            // 
            this.cbbFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFactura.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFactura.FormattingEnabled = true;
            this.cbbFactura.Items.AddRange(new object[] {
            "Factura consumidor final",
            "Comprobante de Credito fiscal"});
            this.cbbFactura.Location = new System.Drawing.Point(119, 193);
            this.cbbFactura.Name = "cbbFactura";
            this.cbbFactura.Size = new System.Drawing.Size(251, 28);
            this.cbbFactura.TabIndex = 3;
            this.cbbFactura.SelectedIndexChanged += new System.EventHandler(this.cbbFactura_SelectedIndexChanged);
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDefault.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault.ForeColor = System.Drawing.Color.White;
            this.btnDefault.Location = new System.Drawing.Point(528, 45);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(131, 33);
            this.btnDefault.TabIndex = 10;
            this.btnDefault.Text = "Por Defecto";
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo de Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "N° Factura/Comprobante";
            // 
            // txbCliente
            // 
            this.txbCliente.Enabled = false;
            this.txbCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliente.Location = new System.Drawing.Point(580, 114);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(199, 28);
            this.txbCliente.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(524, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 21);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(524, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "DUI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(524, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "NIT";
            // 
            // txbNIT
            // 
            this.txbNIT.Enabled = false;
            this.txbNIT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNIT.Location = new System.Drawing.Point(528, 247);
            this.txbNIT.Name = "txbNIT";
            this.txbNIT.Size = new System.Drawing.Size(251, 28);
            this.txbNIT.TabIndex = 12;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Enabled = false;
            this.txbDireccion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.Location = new System.Drawing.Point(119, 321);
            this.txbDireccion.Multiline = true;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(251, 46);
            this.txbDireccion.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(115, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(524, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "NRC";
            // 
            // txbNRC
            // 
            this.txbNRC.Enabled = false;
            this.txbNRC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNRC.Location = new System.Drawing.Point(528, 318);
            this.txbNRC.Name = "txbNRC";
            this.txbNRC.Size = new System.Drawing.Size(251, 28);
            this.txbNRC.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(524, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Estado";
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "PENDIENTE",
            "CANCELADO"});
            this.cbbEstado.Location = new System.Drawing.Point(528, 393);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(251, 29);
            this.cbbEstado.TabIndex = 14;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.cbbEstado_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(115, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Condicion de Pago";
            // 
            // cbbCondPago
            // 
            this.cbbCondPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCondPago.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCondPago.FormattingEnabled = true;
            this.cbbCondPago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA DE CREDITO"});
            this.cbbCondPago.Location = new System.Drawing.Point(119, 411);
            this.cbbCondPago.Name = "cbbCondPago";
            this.cbbCondPago.Size = new System.Drawing.Size(251, 29);
            this.cbbCondPago.TabIndex = 6;
            this.cbbCondPago.SelectedIndexChanged += new System.EventHandler(this.cbbCondPago_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(56)))), ((int)(((byte)(43)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(502, 600);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 33);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(689, 600);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 33);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorMovimiento
            // 
            this.errorMovimiento.ContainerControl = this;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(564, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Subtotal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(564, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 21);
            this.label13.TabIndex = 26;
            this.label13.Text = "IVA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(564, 501);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 21);
            this.label14.TabIndex = 27;
            this.label14.Text = "Total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(665, 501);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 21);
            this.label15.TabIndex = 30;
            this.label15.Text = "$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(665, 480);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 21);
            this.label16.TabIndex = 29;
            this.label16.Text = "$";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(665, 459);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 21);
            this.label17.TabIndex = 28;
            this.label17.Text = "$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(695, 501);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 21);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "0.00";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblIVA.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(695, 480);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(42, 21);
            this.lblIVA.TabIndex = 32;
            this.lblIVA.Text = "0.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(695, 459);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(42, 21);
            this.lblSubtotal.TabIndex = 31;
            this.lblSubtotal.Text = "0.00";
            // 
            // cbbTransaccion
            // 
            this.cbbTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTransaccion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTransaccion.FormattingEnabled = true;
            this.cbbTransaccion.Items.AddRange(new object[] {
            "Venta",
            "Cotizacion",
            "Compra"});
            this.cbbTransaccion.Location = new System.Drawing.Point(274, 65);
            this.cbbTransaccion.Name = "cbbTransaccion";
            this.cbbTransaccion.Size = new System.Drawing.Size(127, 28);
            this.cbbTransaccion.TabIndex = 1;
            this.cbbTransaccion.SelectedIndexChanged += new System.EventHandler(this.cbbTransaccion_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(270, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 21);
            this.label18.TabIndex = 35;
            this.label18.Text = "Transaccion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(689, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 33);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbIDCliente
            // 
            this.txbIDCliente.Enabled = false;
            this.txbIDCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDCliente.Location = new System.Drawing.Point(528, 114);
            this.txbIDCliente.Name = "txbIDCliente";
            this.txbIDCliente.Size = new System.Drawing.Size(46, 28);
            this.txbIDCliente.TabIndex = 37;
            this.txbIDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbDUI
            // 
            this.txbDUI.Enabled = false;
            this.txbDUI.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDUI.Location = new System.Drawing.Point(528, 181);
            this.txbDUI.Name = "txbDUI";
            this.txbDUI.Size = new System.Drawing.Size(251, 28);
            this.txbDUI.TabIndex = 11;
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTarjeta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnTarjeta.Location = new System.Drawing.Point(119, 463);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(251, 76);
            this.btnTarjeta.TabIndex = 7;
            this.btnTarjeta.Text = "Agregar Informacion de Tarjeta";
            this.btnTarjeta.UseVisualStyleBackColor = false;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // txtCuenta
            // 
            this.txtCuenta.AutoSize = true;
            this.txtCuenta.BackColor = System.Drawing.Color.Transparent;
            this.txtCuenta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuenta.Location = new System.Drawing.Point(115, 600);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(104, 21);
            this.txtCuenta.TabIndex = 42;
            this.txtCuenta.Text = "N° Cuenta:";
            // 
            // txtPropietario
            // 
            this.txtPropietario.AutoSize = true;
            this.txtPropietario.BackColor = System.Drawing.Color.Transparent;
            this.txtPropietario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropietario.Location = new System.Drawing.Point(115, 579);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(105, 21);
            this.txtPropietario.TabIndex = 41;
            this.txtPropietario.Text = "Propietario:";
            // 
            // txtBanco
            // 
            this.txtBanco.AutoSize = true;
            this.txtBanco.BackColor = System.Drawing.Color.Transparent;
            this.txtBanco.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanco.Location = new System.Drawing.Point(115, 558);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(69, 21);
            this.txtBanco.TabIndex = 40;
            this.txtBanco.Text = "Banco:";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblCuenta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.Location = new System.Drawing.Point(270, 600);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(0, 21);
            this.lblCuenta.TabIndex = 45;
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.BackColor = System.Drawing.Color.Transparent;
            this.lblPropietario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropietario.Location = new System.Drawing.Point(270, 579);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(0, 21);
            this.lblPropietario.TabIndex = 44;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.BackColor = System.Drawing.Color.Transparent;
            this.lblBanco.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.Location = new System.Drawing.Point(270, 558);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(0, 21);
            this.lblBanco.TabIndex = 43;
            // 
            // ClienteInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 672);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.btnTarjeta);
            this.Controls.Add(this.txbDUI);
            this.Controls.Add(this.txbIDCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbbTransaccion);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbbCondPago);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbNRC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbNIT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.cbbFactura);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNFactura);
            this.Controls.Add(this.txbIDMov);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion del Ciente";
            ((System.ComponentModel.ISupportInitialize)(this.errorMovimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txbIDMov;
        public System.Windows.Forms.TextBox txbNFactura;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.ComboBox cbbFactura;
        public System.Windows.Forms.TextBox txbCliente;
        public System.Windows.Forms.TextBox txbNIT;
        public System.Windows.Forms.TextBox txbDireccion;
        public System.Windows.Forms.TextBox txbNRC;
        public System.Windows.Forms.ComboBox cbbEstado;
        public System.Windows.Forms.ComboBox cbbCondPago;
        private System.Windows.Forms.ErrorProvider errorMovimiento;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblIVA;
        public System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.ComboBox cbbTransaccion;
        public System.Windows.Forms.TextBox txbIDCliente;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txbDUI;
        public System.Windows.Forms.Button btnDefault;
        public System.Windows.Forms.Label lblCuenta;
        public System.Windows.Forms.Label lblPropietario;
        public System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label txtCuenta;
        private System.Windows.Forms.Label txtPropietario;
        private System.Windows.Forms.Label txtBanco;
        public System.Windows.Forms.Button btnTarjeta;
        public System.Windows.Forms.Label lblNombre;
    }
}