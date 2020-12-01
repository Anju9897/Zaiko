using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class ClienteInfo : Form
    {
        public static String tipoDoc;
        public static double subtotal, iva, total;
        public ClienteInfo()
        {
            InitializeComponent();
            cbbFactura.SelectedIndex = 0;
            cbbTransaccion.SelectedIndex = 0;
            cbbEstado.SelectedIndex = 0;
            cbbCondPago.SelectedIndex = 0;
            lblSubtotal.Text = "0.00";
            lblIVA.Text = "0.00";
            lblTotal.Text = "0.00";
        }

        public Boolean validarCampos()
        {
            Boolean validado = true;
            errorMovimiento.Clear();

            if (txbIDCliente.Text.Length == 0)
            {
                validado = false;
                errorMovimiento.SetError(txbIDCliente,"Este campo debe ir con valores");
            }
            if (txbNFactura.Text.Length == 0)
            {
                validado = false;
                errorMovimiento.SetError(txbNFactura, "Este campo debe ir con valores");
            }

            if (cbbCondPago.SelectedIndex == 1)
            {
                if (lblBanco.Text.Length == 0)
                {
                    validado = false;
                    errorMovimiento.SetError(lblBanco, "Este campo debe ir con valores");
                }
                if (lblCuenta.Text.Length == 0)
                {
                    validado = false;
                    errorMovimiento.SetError(lblCuenta, "Este campo debe ir con valores");
                }
                if (lblPropietario.Text.Length == 0)
                {
                    validado = false;
                    errorMovimiento.SetError(lblPropietario, "Este campo debe ir con valores");
                }
            }

            return validado;
        }

        private void calcularValores()
        {
            double subtotalAUX = 0.00;
            double IVAAUX = 0.00;
            double totalAux = 0.00;

            try
            {
            //FCF
            if (cbbFactura.SelectedIndex == 0)
            {
                //si la factura coincide con el tipo de documento, quiere decir que es el valor que estaba anteriormente
                if (cbbFactura.Text.ToUpper().Equals("FACTURA CONSUMIDOR FINAL"))
                {
                    if (cbbFactura.Text.ToUpper().Equals(tipoDoc.ToUpper()))
                    {
                        subtotalAUX = subtotal;
                        IVAAUX = iva;
                        totalAux = subtotal + iva;
                        lblSubtotal.Text = Convert.ToString(subtotalAUX);
                        lblIVA.Text = Convert.ToString(IVAAUX);
                        lblTotal.Text = Convert.ToString(totalAux);
                    }
                    else
                    {
                        subtotalAUX = Math.Round(subtotal / 1.13, 2);
                        IVAAUX = Math.Round(subtotalAUX * 0.13, 2);
                        totalAux = subtotalAUX + IVAAUX;
                        lblSubtotal.Text = Convert.ToString(subtotalAUX);
                        lblIVA.Text = Convert.ToString(IVAAUX);
                        lblTotal.Text = Convert.ToString(totalAux);
                    }
                }
            }//CCF
            else if (cbbFactura.SelectedIndex == 1)
            {
                if (cbbFactura.Text.ToUpper().Equals("COMPROBANTE DE CREDITO FISCAL"))
                {
                    if (cbbFactura.Text.ToUpper().Equals(tipoDoc.ToUpper()))
                    {
                        subtotalAUX = subtotal;
                        IVAAUX = iva;
                        totalAux = subtotal + iva;
                        lblSubtotal.Text = Convert.ToString(subtotalAUX);
                        lblIVA.Text = Convert.ToString(IVAAUX);
                        lblTotal.Text = Convert.ToString(totalAux);
                    }
                    else
                    {
                        subtotalAUX = Math.Round(subtotal * 1.13, 2);
                        IVAAUX = Math.Round(subtotalAUX * 0.13, 2);
                        totalAux = subtotalAUX + IVAAUX;
                        lblSubtotal.Text = Convert.ToString(subtotalAUX);
                        lblIVA.Text = Convert.ToString(IVAAUX);
                        lblTotal.Text = Convert.ToString(totalAux);
                    }
                }
            }
            
            }
            
            catch (Exception)
            {
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txbIDCliente.Text = "12";
            txbCliente.Text = "CLIENTES VARIOS";
            txbDUI.Text = "N/A";
            txbNIT.Text = "N/A";
            txbNRC.Text = "N/A";
            txbDireccion.Text = "N/A";
            cbbCondPago.SelectedIndex = 0;
            cbbEstado.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbEstado.SelectedIndex == 0)
            {
                crearCliente();
            }
            if (cbbEstado.SelectedIndex == 1)
            {
                if (!txbNFactura.Text.ToUpper().Equals("PENDIENTE".ToUpper())) 
                {
                    crearCliente();
                }
                else
                {
                    MessageBox.Show("No se pueden concluir a CANCELADO porque el numero de factura esta en PENDIENTE, debe de tener un numero factura","ERROR ESTADO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

        }

        private void crearCliente()
        {
            if (validarCampos())
            {
                CLS.Movimiento oMovimiento = new CLS.Movimiento();
                oMovimiento.IDMovimiento = txbIDMov.Text;
                oMovimiento.IDUsuario = SessionManager.CLS.Sesion.Instancia.Informacion.IDUsuario;
                oMovimiento.Fecha = dtpFecha.Text;
                oMovimiento.IDPersona = txbIDCliente.Text;
                oMovimiento.CondPago = cbbCondPago.Text;
                oMovimiento.TComprobante = cbbFactura.Text;
                oMovimiento.NComprobante = txbNFactura.Text;
                oMovimiento.Transaccion = cbbTransaccion.Text;
                oMovimiento.Estado = cbbEstado.Text;
                oMovimiento.Subtotal = Convert.ToString(Convert.ToDouble(lblSubtotal.Text));
                oMovimiento.IvaTotal = Convert.ToString(Convert.ToDouble(lblIVA.Text));
                oMovimiento.Total = Convert.ToString(Convert.ToDouble(lblTotal.Text));

                if (cbbCondPago.SelectedIndex == 1)
                {
                    oMovimiento.BANCO = lblBanco.Text;
                    oMovimiento.PROPIETARIO = lblPropietario.Text;
                    oMovimiento.NCUENTA = lblCuenta.Text;
                }
                else if (cbbCondPago.SelectedIndex == 0)
                {
                    oMovimiento.BANCO = "";
                    oMovimiento.PROPIETARIO = "";
                    oMovimiento.NCUENTA = "";
                }

                if (txbIDMov.Text.Length > 0)
                {
                    if (oMovimiento.Actualizar())
                    {
                        if (oMovimiento.Actualizar_Total())
                        {
                            Close();
                        }
                    }
                }
                else
                {
                    if (oMovimiento.Guardar()) { Close(); }

                }
            }
        }

        private void cbbFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTransaccion.SelectedIndex != 1)
            {
                //venta o compra
                
                if (cbbFactura.SelectedIndex == 0)
                //consumidor final o cotizacion
                {
                    calcularValores();
                }

                else if (cbbFactura.SelectedIndex == 1)
                //credito fiscal
                {
                    calcularValores();
                }

            }
            else
            {
                //cotizacion
                calcularValores();
            }
        }

        private void cbbTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ventas
            if (cbbTransaccion.SelectedIndex == 0)
            {
                calcularValores();
            }//cotizacion
            else if (cbbTransaccion.SelectedIndex == 1)
            {
                calcularValores();
            }//compras
            else if (cbbTransaccion.SelectedIndex == 2)
            {
                calcularValores();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClientesLista f = new ClientesLista();
            f.ShowDialog();
            try
            {
                txbIDCliente.Text = f.dtgClientes.CurrentRow.Cells["idpersonas"].Value.ToString();
                txbCliente.Text = f.dtgClientes.CurrentRow.Cells["Nombres"].Value.ToString();

                if (!f.dtgClientes.CurrentRow.Cells["DUI"].Value.ToString().Equals(""))
                {
                    txbDUI.Text = f.dtgClientes.CurrentRow.Cells["DUI"].Value.ToString();
                }
                else
                {
                    txbDUI.Text = "N/A";
                }

                if (!f.dtgClientes.CurrentRow.Cells["NIT"].Value.ToString().Equals(""))
                {
                    txbNIT.Text = f.dtgClientes.CurrentRow.Cells["NIT"].Value.ToString();
                }
                else
                {
                    txbNIT.Text = "N/A";
                }

                if (!f.dtgClientes.CurrentRow.Cells["NRC"].Value.ToString().Equals(""))
                {
                    txbNRC.Text = f.dtgClientes.CurrentRow.Cells["NRC"].Value.ToString();
                }
                else
                {
                    txbNRC.Text = "N/A";
                }

                if (!f.dtgClientes.CurrentRow.Cells["Direccion"].Value.ToString().Equals(""))
                {
                    txbDireccion.Text = f.dtgClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                }
                else
                {
                    txbDireccion.Text = "N/A";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado ningun elemento","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double Subtotal = 0.00;
            Double Total = 0.00;
            Double IVA = 0.00;
            if(cbbEstado.SelectedIndex == 0)
            {
                //Pendiente

            }
            else if (cbbEstado.SelectedIndex == 1)
            {
                //Cancelado
                
            }
            else if (cbbEstado.SelectedIndex == 2)
            {
                //Anulado
                
            }
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            TarjetaInfo f = new TarjetaInfo();
            f.ShowDialog();

            lblBanco.Text = f.txbBanco.Text;
            lblCuenta.Text = f.txbNumero.Text;
            lblPropietario.Text = f.txbPropietario.Text;
        }

        private void cbbCondPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCondPago.SelectedIndex == 1)
            {
                btnTarjeta.Enabled = true;
                btnTarjeta.Visible = true;
                lblBanco.Visible = true;
                lblPropietario.Visible = true;
                lblCuenta.Visible = true;
                txtBanco.Visible = true;
                txtCuenta.Visible = true;
                txtPropietario.Visible = true;
            }
            else
            {
                btnTarjeta.Enabled = false;
                btnTarjeta.Visible = false;
                lblBanco.Visible = false;
                lblPropietario.Visible = false;
                lblCuenta.Visible = false;
                txtBanco.Visible = false;
                txtCuenta.Visible = false;
                txtPropietario.Visible = false;
            } 
        }
    }
}
