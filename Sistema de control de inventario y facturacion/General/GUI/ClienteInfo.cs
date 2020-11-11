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
            txbIDCliente.Text = "1";
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
            CLS.Movimiento oMovimiento = new CLS.Movimiento();
            oMovimiento.IDMovimiento = txbIDMov.Text;
            oMovimiento.IDUsuario = SessionManager.CLS.Sesion.Instancia.Informacion.IDUsuario;
            oMovimiento.Fecha = dtpFecha.Text;
            oMovimiento.Cliente = txbCliente.Text;
            oMovimiento.Direccion = txbNRC.Text;
            oMovimiento.CondPago = cbbCondPago.Text;
            oMovimiento.NDoc = txbNIT.Text;
            oMovimiento.Giro = txbDireccion.Text;
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
    }
}
