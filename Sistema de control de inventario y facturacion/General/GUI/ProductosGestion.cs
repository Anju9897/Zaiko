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
    public partial class ProductosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        SessionManager.CLS.Sesion _Instancia =   SessionManager.CLS.Sesion.Instancia;
        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.TODOS_LOS_PRODUCTOS();
                FiltrarLocalmente();
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
                    _DATOS.Filter = @"Nombre LIKE '%" + txbFiltro.Text + "%' OR Descripcion LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgProductos.AutoGenerateColumns = false;
                dtgProductos.DataSource = _DATOS;
                lblCuenta.Text = dtgProductos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch
            {
            }
        }

        public ProductosGestion()
        {
            InitializeComponent();
            Cargar();
        }

        private void ProductosGestion_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProductoEdicion f = new ProductoEdicion();
            f.ShowDialog();
            Cargar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        
        {
            try
            {
                if (MessageBox.Show("Realmente Desea editar este producto", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProductoEdicion f = new ProductoEdicion();
                    CLS.Producto p = new CLS.Producto();
                    p.IDProducto = dtgProductos.CurrentRow.Cells["idproducto"].Value.ToString();
                    f.lblIDProducto.Text = dtgProductos.CurrentRow.Cells["idproducto"].Value.ToString();
                    f.lblIDInventario.Text = dtgProductos.CurrentRow.Cells["idinventario"].Value.ToString();
                    f.txbCodigo.Text = dtgProductos.CurrentRow.Cells["Codigo"].Value.ToString();
                    f.txbNombre.Text = dtgProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                    f.txbMarca.Text = dtgProductos.CurrentRow.Cells["idmarca"].Value.ToString();
                    f.txbPrecio.Text = dtgProductos.CurrentRow.Cells["PrecioUnitario"].Value.ToString();
                    f.cbbUnidad.Text = dtgProductos.CurrentRow.Cells["Unidad"].Value.ToString();
                    f.txbExistencias.Text = dtgProductos.CurrentRow.Cells["Existencias"].Value.ToString();
                    f.txbDescripcion.Text = dtgProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                    f.txbExistencias.Enabled = false;
                    f.txbPrecio.Enabled = false;
                    //f.pbProducto.Image = CacheManager.CLS.Comandos.retornarImagen(p.obtenerImagen(p.IDProducto));
                    f.ShowDialog();
                    Cargar();

                }
            }
            catch
            {
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea ELIMINAR el producto seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Producto oProducto = new CLS.Producto();
                    CLS.Inventario oInventario = new CLS.Inventario();
                    // sincronizar
                    oProducto.IDProducto = dtgProductos.CurrentRow.Cells["idproducto"].Value.ToString();
                    oInventario.IDInventario = dtgProductos.CurrentRow.Cells["idinventario"].Value.ToString();
                    if (oInventario.Eliminar())
                    {
                        oProducto.Eliminar();
                        Cargar();
                    }

                }
            }
            catch
            {
            }
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 10 && e.RowIndex >= 0)
                {

                }
                
            }
            catch
            {

            }
        }

        private void dtgProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txbFiltro.Focus();
            }
        }
    }
}
