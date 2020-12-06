using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reportes;

namespace General.GUI
{
    public partial class Movimientos : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_MOVIMIENTOS(cbbTransaccion.Text);
                FiltrarLocalmente();
                FiltrarPorComprobante();

            }
            catch
            {
            }
        }

        private void FiltrarLocalmente()
        {
            try
            {
                if (txbFiltro.TextLength > 0)
                {
                    _DATOS.Filter = @"Cliente LIKE '%" + txbFiltro.Text + "%' OR tipoComprobante LIKE '%" +
                        txbFiltro.Text + "%' OR numComprobante LIKE '%" +
                        txbFiltro.Text + "%' OR CondPago LIKE '%" +
                        txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgMovimiento.AutoGenerateColumns = false;
                dtgMovimiento.DataSource = _DATOS;
                lblRegistros.Text = dtgMovimiento.Rows.Count.ToString() + " Registros Encontrados";

            }
            catch
            {

            }
        }

        private void FiltrarPorFecha()
        {
            try
            {
                _DATOS.Filter = @"fecha>='" + dtgFecha1.Text + " 00:00' AND fecha<='" + dtgFecha2.Text + " 23:59'";
                dtgMovimiento.DataSource = _DATOS;
                lblRegistros.Text = dtgMovimiento.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch
            {
            }
        }

        private void FiltrarPorComprobante()
        {
            try
            {
                _DATOS.Filter = @"TipoComprobante ='" + cbbComprobante.Text.ToString() + "'";
                dtgMovimiento.DataSource = _DATOS;
                lblRegistros.Text = dtgMovimiento.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch
            {
            }
        }

        public Movimientos()
        {
            InitializeComponent();
            Cargar();
            cbbTransaccion.SelectedIndex = 0;
            cbbComprobante.SelectedIndex = 0;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FiltrarPorFecha();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteInfo f = new ClienteInfo();
                ClienteInfo.tipoDoc = "";
                ClienteInfo.subtotal = 0.00;
                ClienteInfo.iva = 0.00;
                ClienteInfo.total = 0.00;
                f.ShowDialog();
                Cargar();
                FiltrarPorFecha();
            }
            catch
            {
                
            }
            
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dtgMovimiento.CurrentRow.Cells["estado"].Value.ToString().Equals("Anulado"))
            {
                try
                {
                    ClienteInfo f = new ClienteInfo();

                    f.txbIDMov.Text = dtgMovimiento.CurrentRow.Cells["idmovimiento"].Value.ToString();
                    f.txbIDCliente.Text = dtgMovimiento.CurrentRow.Cells["IDPERSONA"].Value.ToString();
                    f.txbCliente.Text = dtgMovimiento.CurrentRow.Cells["cliente"].Value.ToString();
                    f.dtpFecha.Text = dtgMovimiento.CurrentRow.Cells["fecha"].Value.ToString();
                    f.cbbEstado.Text = dtgMovimiento.CurrentRow.Cells["estado"].Value.ToString();
                    f.cbbFactura.Text = dtgMovimiento.CurrentRow.Cells["tipocomprobante"].Value.ToString();
                    f.txbNFactura.Text = dtgMovimiento.CurrentRow.Cells["numcomprobante"].Value.ToString();

                    f.cbbTransaccion.Text = dtgMovimiento.CurrentRow.Cells["Transaccion"].Value.ToString(); ;
                    f.lblSubtotal.Text = dtgMovimiento.CurrentRow.Cells["subtotal"].Value.ToString();
                    f.lblIVA.Text = dtgMovimiento.CurrentRow.Cells["ivatotal"].Value.ToString();
                    f.lblTotal.Text = dtgMovimiento.CurrentRow.Cells["total"].Value.ToString();
                    ClienteInfo.tipoDoc = dtgMovimiento.CurrentRow.Cells["tipocomprobante"].Value.ToString();
                    ClienteInfo.subtotal = Convert.ToDouble(dtgMovimiento.CurrentRow.Cells["subtotal"].Value);
                    ClienteInfo.iva = Convert.ToDouble(dtgMovimiento.CurrentRow.Cells["ivatotal"].Value);
                    ClienteInfo.total = Convert.ToDouble(dtgMovimiento.CurrentRow.Cells["total"].Value);

                    if (dtgMovimiento.CurrentRow.Cells["condpago"].Value.ToString().Equals("TARJETA DE CREDITO"))
                    {
                        f.cbbCondPago.SelectedIndex = 1;
                        f.lblBanco.Text = dtgMovimiento.CurrentRow.Cells["banco"].Value.ToString();
                        f.lblPropietario.Text = dtgMovimiento.CurrentRow.Cells["propietariocuenta"].Value.ToString();
                        f.lblCuenta.Text = dtgMovimiento.CurrentRow.Cells["ncuenta"].Value.ToString();
                    }
                    else if (dtgMovimiento.CurrentRow.Cells["condpago"].Value.ToString().Equals("EFECTIVO"))
                    {
                        f.cbbCondPago.SelectedIndex = 0;
                    }

                    f.ShowDialog();
                    Cargar();
                    FiltrarPorFecha();

                    ClienteInfo.tipoDoc = "";
                    ClienteInfo.subtotal = 0.00;
                    ClienteInfo.iva = 0.00;
                    ClienteInfo.total = 0.00;
                }

                catch
                {

                }

            }
            else
            {
                MessageBox.Show("No es posible editar valores de este documento ya que fue anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Movimientos_Load(object sender, EventArgs e)
        {
        }

        private void transaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Instrucciones:\n1. El producto que desee dar doble click sobre el nombre \n2. Ingregar la cantidad en el espacio espeficiado.\n3. Al Ingresar toda la cantidad, precionar ENTER para agregar la informacion al cuadro de abajo.", "Informacion Para agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (!dtgMovimiento.CurrentRow.Cells["estado"].Value.ToString().Equals("Anulado"))
            {
                try
                {
                    if (respuesta == DialogResult.OK)
                    {
                        DetallesMovimiento f = new DetallesMovimiento();
                        f.lblIDMov.Text = dtgMovimiento.CurrentRow.Cells["IDMovimiento"].Value.ToString();
                        f.lblTransaccion.Text = dtgMovimiento.CurrentRow.Cells["Transaccion"].Value.ToString();
                        f.lblComprobante.Text = dtgMovimiento.CurrentRow.Cells["tipocomprobante"].Value.ToString();
                        f.ShowDialog();
                        cbbComprobante.SelectedIndex = cbbComprobante.SelectedIndex;
                        Cargar();
                        FiltrarPorFecha();
                    }
                }
                catch (Exception)
                {
                }
            }
            else
            {

                try
                {
                    DetallesMovimiento f = new DetallesMovimiento();
                    f.lblIDMov.Text = dtgMovimiento.CurrentRow.Cells["IDMovimiento"].Value.ToString();
                    f.lblTransaccion.Text = dtgMovimiento.CurrentRow.Cells["Transaccion"].Value.ToString();
                    f.lblComprobante.Text = dtgMovimiento.CurrentRow.Cells["tipocomprobante"].Value.ToString();

                    f.toolStrip1.Enabled = false;
                    f.dtgDetalle.Enabled = false;
                    f.dtgProductos.Enabled = false;
                    f.txbCantidad.Enabled = false;
                    f.ShowDialog();
                    Cargar();
                    FiltrarPorFecha();
                }
                catch (Exception)
                {
                }
            }

        }

        private void dtgMovimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                txbFiltro.Focus();
            }
            if (e.KeyData == Keys.X)
            {
                btnEliminar_Click(sender, e);
            }
            if (e.KeyData == Keys.A)
            {
                btnAgregar_Click(sender, e);
            }
        }

        private void cbbTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTransaccion.SelectedIndex == 0)
            {
                btnEmitirCotizacion.Enabled = false;
                btnEmitirCotizacion.Visible = false;

                Cargar();
                FiltrarPorComprobante();
            }
            else if (cbbTransaccion.SelectedIndex == 1)
            {
                btnEmitirCotizacion.Enabled = true;
                btnEmitirCotizacion.Visible = true;

                Cargar();
                FiltrarPorComprobante();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dtgMovimiento.CurrentRow.Cells["estado"].Value.ToString().Equals("Anulado"))
                {

                    if (MessageBox.Show("¿Esta Seguro que desea anular este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CLS.Movimiento f = new CLS.Movimiento();
                        f.IDMovimiento = dtgMovimiento.CurrentRow.Cells["idmovimiento"].Value.ToString();
                        f.Estado = "Anulado";
                        f.Actualizar_Anulado();

                        //actualizar valores de anulacion
                        actualizar_anulacion();

                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Esta factura ya ha sido anulada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
        }

        private void btnEmitirCotizacion_Click(object sender, EventArgs e)
        {
            try
            {
                
                Reportes.GUI.Cotizaciones f = new Reportes.GUI.Cotizaciones();
                f.txbNCotizacion.Text = dtgMovimiento.CurrentRow.Cells["idmovimiento"].Value.ToString();
                f.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado o no hay ningun dato el cual sea posible mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbComprobante.SelectedIndex != 0)
            {
                FiltrarPorComprobante();
            }
            else
            {
                FiltrarLocalmente();
            }
        }

        private void dtgMovimiento_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 12)
                {
                    if (!dtgMovimiento.CurrentRow.Cells["estado"].Value.ToString().Equals("Anulado"))
                    {
                        
                        try
                        {

                            String idmovimiento = dtgMovimiento.CurrentRow.Cells["idmovimiento"].Value.ToString();
                            String idmovDev = obtenerIDMovimientoDevolucion(idmovimiento);
                            Devoluciones f = new Devoluciones();
                            f.tsMovimiento.Text = idmovimiento;
                            f.tsDocumento.Text = dtgMovimiento.CurrentRow.Cells["tipoComprobante"].Value.ToString();

                            if (idmovimiento.Equals(idmovDev))
                            {
                                if (MessageBox.Show("Ya hay una devolucion concluida de este documento, podra ingresar pero solo podra visualizar los datos pero no modificarlos.\nAun asi, ¿desea continuar?", "Aviso de devolucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    f.dtgDetalles.Enabled = false;
                                    f.dtgDevoluciones.Enabled = false;
                                    f.botones.Enabled = false;
                                    f.txbCantidad.Enabled = false;
                                    f.ShowDialog();
                                }
                            }
                            else
                            {
                                DialogResult respuesta = MessageBox.Show("Instrucciones:\n1. El producto que desee dar doble click sobre el nombre \n2. Ingregar la cantidad en el espacio espeficiado.\n3. Al Ingresar toda la cantidad, precionar ENTER para agregar la informacion al cuadro de abajo.", "Informacion Para agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (respuesta == DialogResult.OK)
                                {
                                    f.ShowDialog();
                                }
                            }

                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("No es posible hacer devoluciones de documentos anulados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (e.ColumnIndex == 13)
                {
                    //  MessageBox.Show("Se ha seleccinado la opcion de IMPRIMIR");
                    String ESTADO = dtgMovimiento.CurrentRow.Cells["estado"].Value.ToString();
                    String TIPODOC = dtgMovimiento.CurrentRow.Cells["tipoComprobante"].Value.ToString();
                    int ID = Convert.ToInt16(dtgMovimiento.CurrentRow.Cells["idmovimiento"].Value);

                    if (ESTADO.Equals("Cancelado"))
                    {
                        if (TIPODOC.Equals("Factura consumidor final"))
                        {
                            //CONSUMIDOR FINAL
                            Reportes.GUI.VPFacturas_Consumidor_Final f = new Reportes.GUI.VPFacturas_Consumidor_Final();
                            //f.MdiParent = this;
                            f.ID1 = ID;
                            // f.TipoFactura = "CONSUMIDORFINAL";
                            f.ShowDialog();
                        }
                        else
                        {
                            //CREDITOS FISCALESR
                            Reportes.GUI.VP_Factura_CREDITOFISCAL f = new Reportes.GUI.VP_Factura_CREDITOFISCAL();

                            f.ID1 = ID;
                            f.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("No es posible imprimir una factura que ha sido anulada o esta en estado pendiente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private string obtenerIDMovimientoDevolucion(string idmovimiento)
        {
            String idDevolucionMov = "";
            try
            {
                idDevolucionMov = CacheManager.CLS.Cache.OBTENER_ID_MOVIMIENTO_PARA_VERIFICAR_SI_EXISTE_DEVOLUCION(idmovimiento)["idmov"].ToString();
            }
            catch 
            {
                idDevolucionMov = "";
            }

            return idDevolucionMov;
        }

        private void actualizar_anulacion()
        {

            DataTable dtgAnulados = new DataTable();
            //Lista de auxiliares
            List<int> auxIDDetalle = new List<int>();
            List<int> auxIDProducto = new List<int>();
            List<int> auxIDInventario = new List<int>();
            List<double> auxExistencias = new List<double>();
            List<double> auxCantidad = new List<double>();

            //Lista de nuevo inventario
            List<double> nuevoInventario = new List<double>();

            double auxValores = 0.00;

            //Clase de Inventario
            CLS.Inventario oInventario = new CLS.Inventario();
            try
            {
                String idmovi = dtgMovimiento.CurrentRow.Cells["idmovimiento"].Value.ToString();
                dtgAnulados = CacheManager.CLS.Cache.OBTENER_ELEMENTOS_DETALLEMOV_POR_IDMOV(idmovi);

                //agregar por separado cada id en cada lista de elementos que viene del dtg
                foreach (DataRow row in dtgAnulados.Rows)
                {

                    auxIDDetalle.Add(Convert.ToInt32(row["iddetalle"]));
                    auxIDProducto.Add(Convert.ToInt32(row["idproducto"]));
                    auxIDInventario.Add(Convert.ToInt32(row["idinventario"]));

                    auxCantidad.Add(Convert.ToDouble(row["cantidad"]));
                    auxExistencias.Add(Convert.ToDouble(row["existencias"]));

                }
                for (int i = 0; i < auxIDDetalle.Count; i++)
                {
                    auxValores = auxExistencias.ElementAt(i) + auxCantidad.ElementAt(i);
                    nuevoInventario.Add(auxValores);


                    //actualizar cada uno con id
                    oInventario = new CLS.Inventario();
                    oInventario.IdProducto = Convert.ToString(auxIDProducto.ElementAt(i));
                    oInventario.IDInventario = Convert.ToString(auxIDInventario.ElementAt(i));
                    oInventario.Existencias = Convert.ToString(nuevoInventario.ElementAt(i));

                    oInventario.Actualizar_Existencias();

                }

            }
            catch (Exception)
            {

            }
        
    
    }
    }
}
