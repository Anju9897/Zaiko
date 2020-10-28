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
    public partial class InfoClienteCompra : Form
    {
        public InfoClienteCompra()
        {
            InitializeComponent();
        }

        private void InfoClienteCompra_Load(object sender, EventArgs e)
        {
            cbbTipoDoc.SelectedIndex = 0;
            cbbFactura.SelectedIndex = 0;
            cbbEstado.SelectedIndex = 0;
            cbbCondPago.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
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
            oMovimiento.Transaccion = "Compra";
            oMovimiento.Estado = cbbEstado.Text;

            if (txbIDMov.Text.Length > 0)
            {
                oMovimiento.Actualizar();
            }
            else
            {
                oMovimiento.Guardar();
            }

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
