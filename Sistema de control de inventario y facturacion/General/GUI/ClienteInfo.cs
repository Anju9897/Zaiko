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
        public ClienteInfo()
        {
            InitializeComponent();
            cbbFactura.SelectedIndex = 0;
            cbbTransaccion.SelectedIndex = 0;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txbCliente.Text = "CLIENTES VARIOS";
            cbbTipoDoc.SelectedIndex = 0;
            txbDocumento.Text = "N/A";
            txbDireccion.Text = "N/A";
            txbGiro.Text = "N/A";
            cbbCondPago.SelectedIndex = 0;
            cbbEstado.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLS.Movimiento oMovimiento = new CLS.Movimiento();
            oMovimiento.IDMovimiento = txbIDMov.Text;
            oMovimiento.IDUsuario = SessionManager.CLS.Sesion.Instancia.Informacion.IDUsuario;
            oMovimiento.Fecha = dtpFecha.Text;
            oMovimiento.Cliente = txbCliente.Text;
            oMovimiento.Direccion = txbDireccion.Text;
            oMovimiento.CondPago = cbbCondPago.Text;
            oMovimiento.TDoc = cbbTipoDoc.Text;
            oMovimiento.NDoc = txbDocumento.Text;
            oMovimiento.Giro = txbGiro.Text;
            oMovimiento.TComprobante = cbbFactura.Text;
            oMovimiento.NComprobante = txbNFactura.Text;
            oMovimiento.Transaccion = cbbTransaccion.Text;
            oMovimiento.Estado = cbbEstado.Text;
            oMovimiento.Subtotal = Convert.ToString(Convert.ToDouble(lblSubtotal.Text));
            oMovimiento.IvaTotal = Convert.ToString(Convert.ToDouble(lblIVA.Text));
            oMovimiento.Total = Convert.ToString(Convert.ToDouble(lblTotal.Text));

            if (txbIDMov.Text.Length > 0)
            {
                oMovimiento.Actualizar();
                oMovimiento.Actualizar_Total();
            }
            else
            {
                oMovimiento.Guardar();
            }
            Close();
        }

        private void cbbFactura_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbbTransaccion.SelectedIndex != 1)
            {
                //venta
                
                if (cbbFactura.SelectedIndex == 0)
                //consumidor final o cotizacion
                {
                    lblTotal.Text = lblSubtotal.Text;
                }

                else if (cbbFactura.SelectedIndex == 1)
                //credito fiscal
                {
                    lblTotal.Text = Convert.ToString(Convert.ToDouble(lblSubtotal.Text) + Convert.ToDouble(lblIVA.Text));
                }
                else if (cbbFactura.SelectedIndex == 2)
                {
                    MessageBox.Show("Este tipo de documentos no es valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbFactura.SelectedIndex = 0;
                }

            }
            else
            {
                //cotizacion
                if (cbbFactura.SelectedIndex != 2)
                {
                    MessageBox.Show("Este tipo de documentos no es valido","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    cbbFactura.SelectedIndex = 2;
                }
                lblTotal.Text = lblSubtotal.Text;
            }
        }

        private void cbbTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTransaccion.SelectedIndex == 0)
            {
                cbbFactura.SelectedIndex = 0;
            }
            else if (cbbTransaccion.SelectedIndex == 1)
            {
                cbbFactura.SelectedIndex = 2;
            }
        }
    }
}
