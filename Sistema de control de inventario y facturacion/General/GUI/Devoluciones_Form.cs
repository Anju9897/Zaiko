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
    public partial class Devoluciones : Form
    {

        private BindingSource _DATOS_DETALLES = new BindingSource();
        private BindingSource _DATOS_DEVOLUCIONES = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS_DETALLES.DataSource = CacheManager.CLS.Cache.TODOS_LOS_DETALLES_POR_ID(tsMovimiento.Text);
                dtgDetalles.AutoGenerateColumns = false;
                dtgDetalles.DataSource = _DATOS_DETALLES;
                
            }
            catch (Exception)
            {
               
            }
        }

        private void CargarDevoluciones()
        {
            try
            {
                _DATOS_DEVOLUCIONES.DataSource = CacheManager.CLS.Cache.DEVOLUCIONES_CON_DETALLES_POR_MOVIMIENTO(tsMovimiento.Text);
                dtgDevoluciones.AutoGenerateColumns = false;
                dtgDevoluciones.DataSource = _DATOS_DEVOLUCIONES;

            }
            catch
            {

            }
        }

        public Devoluciones()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsMovimiento_TextChanged(object sender, EventArgs e)
        {
            CargarDevoluciones();
            Cargar();
        }

        private void dtgDetalles_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow Row = dtgDetalles.CurrentRow;


            foreach (DataGridViewRow row2 in dtgDevoluciones.Rows)
            {
                if (row2.Cells["idd"].Value.ToString().Equals(Row.Cells["iddetalle"].Value.ToString()))
                {
                    MessageBox.Show("no se puede relizar mas de una devolucion de este producto, unicamente una devolucion por producto","Aviso Devolucion existente",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    break;
                }
            }


            if (Convert.ToDouble(Row.Cells["cantitadsalida"].Value) > 0)
            {
                txbPrecio.Text = Row.Cells["precio"].Value.ToString();
                txbIDDetalle.Text = Row.Cells["iddetalle"].Value.ToString();
                txbProducto.Text = Row.Cells["producto"].Value.ToString();
                txbCantidad.Focus();
            }
        }

        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            double iva = 0.00;
            double gravado = 0.00;
            try
            {
                if (txbCantidad.Text.Length > 0)
                {
                    if (tsDocumento.Text.ToUpper().Equals("Comprobante de Credito Fiscal".ToUpper()))
                    {
                        gravado = Math.Round(Convert.ToDouble(txbCantidad.Text) * Convert.ToDouble(txbPrecio.Text),2);
                        iva = Math.Round(gravado * 0.13,2);
                    }
                    if (tsDocumento.Text.ToUpper().Equals("Factura Consumidor Final".ToUpper()))
                    {
                        gravado = Math.Round((Convert.ToDouble(txbCantidad.Text) * Convert.ToDouble(txbPrecio.Text)) / 1.13,2);
                        iva = Math.Round(gravado * 0.13,2);
                    }

                    txbSubtotal.Text = gravado.ToString();
                    txbIVA.Text = iva.ToString();
                }
                else
                {
                    txbSubtotal.Text = "0.00";
                    txbIVA.Text = "0.00";
                }
            }
            catch
            {

            }
           
        }

        private void txbCantidad_KeyDown(object sender, KeyEventArgs e)
        {
                String cantidad = txbCantidad.Text;
                String cantidad2 = dtgDetalles.CurrentRow.Cells["cantitadSalida"].Value.ToString();
                Double cantidadEscrita = 0.00;
                if (!cantidad.Equals("")) { cantidadEscrita = Convert.ToDouble(cantidad); }
                Double cantidadPresente = Convert.ToDouble(cantidad2);
                if (e.KeyData == Keys.Enter)
                {
                    try 
	                {	        
                        if (cantidad.Length > 0)
                        {
                            if (cantidadEscrita > 0 && cantidadEscrita <= cantidadPresente)
                            {
                                // se efectuara el proceso de agregar la devolucion
                                Guardar_Devolucion();
                            }
                            else
                            {
                                MessageBox.Show("No es posible proseguir debido a que los valores son mayores a los que presenta el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No es posible proseguir debido no se encuentran datos en el campo solitado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
	                }
	                catch
	                {
	                }

                }
            }

        private void Guardar_Devolucion()
        {
            CLS.Devolucion oDevolucion = new CLS.Devolucion();
            oDevolucion.Iddevolucion = tsIDDEVOLUCION.Text;
            oDevolucion.Idmovimiento = tsMovimiento.Text;
            oDevolucion.Iddetalle = txbIDDetalle.Text;
            oDevolucion.TipoNota = tsTipoNota.Text;
            oDevolucion.Precio1 = Convert.ToDouble (txbPrecio.Text);
            oDevolucion.CEntrada = Convert.ToDouble(txbCantidad.Text);
            oDevolucion.Gravado1 = Convert.ToDouble(txbSubtotal.Text);
            oDevolucion.IVA1 = Convert.ToDouble(txbIVA.Text);

            oDevolucion.Subtotal1 = Convert.ToDouble(txbIVA.Text) + Convert.ToDouble(txbSubtotal.Text);

            if (tsIDDEVOLUCION.Text.Length == 0)
            {
                if (oDevolucion.Guardar_devolucion_venta())
                {
                    CargarDevoluciones();
                }
            }
        }

        private void btnFinDev_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("¿Desea Completar la devolucion?\nAl cerrar esta ventana las devoluciones para este documento, ya no será posible editarlo de nuevo.\n¿desea Continuar?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dR == DialogResult.Yes)
            {
                concluirDevoluciones();
            }
        }

        private void concluirDevoluciones()
        {
            DataTable dtInventarios = new DataTable();
            CLS.Inventario oInventario = new CLS.Inventario();
            try
            {
                foreach (DataGridViewRow dtgR in dtgDevoluciones.Rows)
                {
                    String idDetalle = dtgR.Cells["idd"].Value.ToString();
                    Double numNuevo = Convert.ToDouble(dtgR.Cells["cEntrada"].Value);
                    dtInventarios = CacheManager.CLS.Cache.INFORMACION_INVENTARIO_PARA_DEVOLUCION(idDetalle);

                    Double inventarioActual = 0.00;
                    Double nuevoInventario = 0.00;

                    foreach (DataRow ROW in dtInventarios.Rows)
                    {
                        oInventario.IDInventario = ROW["idinventario"].ToString();
                        oInventario.IdProducto = ROW["idproducto"].ToString();

                        inventarioActual = Convert.ToDouble(ROW["existencias"]);

                        nuevoInventario = numNuevo + inventarioActual;
                        oInventario.Existencias = nuevoInventario.ToString();

                        if (oInventario.Actualizar_Existencias())
                        {
                            this.Close();
                        }

                    }
                }


            }
            catch 
            {
            }

        }

        private void dtgDetalles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                btnFinDev_Click(sender, e);
            }
        }

        private void dtgDevoluciones_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dtgDevoluciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                btnFinDev_Click(sender, e);
            }
        }

            
        }
    }
