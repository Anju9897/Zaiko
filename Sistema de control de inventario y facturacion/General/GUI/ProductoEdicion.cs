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
    public partial class ProductoEdicion : Form
    {
        private Boolean VerificarDatos()
        {
            Boolean Verificado = true;
            Notificador.Clear();

            if (txbCodigo.TextLength == 0)
            {
                Notificador.SetError(txbCodigo, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (txbNombre.TextLength == 0)
            {
                Notificador.SetError(txbNombre, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (txbPrecio.TextLength == 0)
            {
                Notificador.SetError(txbPrecio, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (txbDescripcion.TextLength == 0)
            {
                Notificador.SetError(txbDescripcion, "Este campo no puede quedar vacio");
                Verificado = false;
            }
            if (txbMarca.TextLength == 0)
            {
                Notificador.SetError(txbMarca, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (cbbCategoria.SelectedValue.ToString().Equals("0"))
            {
                Notificador.SetError(cbbCategoria, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (cbbUnidad.SelectedValue.ToString().Equals("0"))
            {
                Notificador.SetError(cbbUnidad, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            if (pbProducto == null)
            {
                Notificador.SetError(pbProducto, "Este campo no puede quedar vacio");
                Verificado = false;
            }

            return Verificado;
        }

        private void Procesar()
        {
            try
            {
                if (VerificarDatos())
                {
                    CLS.Producto oProducto = new CLS.Producto();
                    oProducto.IDProducto = lblIDProducto.Text;
                    oProducto.Nombre = txbNombre.Text;
                    oProducto.IDCategoria = cbbCategoria.SelectedValue.ToString();
                    oProducto.IDMarca = txbMarca.Text;
                    oProducto.IDUnidad = cbbUnidad.SelectedValue.ToString();
                    oProducto.Codigo = txbCodigo.Text;
                    oProducto.Descripcion = txbDescripcion.Text;
                    if (pbProducto.Image != null)
                    {
                        oProducto.Imagen = CacheManager.CLS.Comandos.conversionImagen(pbProducto);
                    }


                    CLS.Inventario oInventario = new CLS.Inventario();
                    oInventario.IDInventario = lblIDInventario.Text;
                    oInventario.PrecioUnitario = txbPrecio.Text;
                    oInventario.Existencias = txbExistencias.Text;
                    oInventario.IDUnidades = cbbUnidad.SelectedValue.ToString();
                    oInventario.IdProducto = oProducto.ObtenerID(txbCodigo.Text);

                    if (lblIDProducto.Text.Length > 0)
                    {
                        oProducto.Actualizar();

                        if (lblIDInventario.Text.Length > 0)
                        {
                            oInventario.Actualizar();
                        }
                        Close();
                    }else{
                        oProducto.Guardar();
                        oInventario.IdProducto = oProducto.ObtenerID(txbCodigo.Text);

                        if (lblIDInventario.Text.Length == 0)
                        {
                            oInventario.Guardar();
                        }
                        Close();
                    }
                }
            }
            catch
            {
            }
        }

        private void CargarCategorias()
        {
            DataTable cat = new DataTable();
            cat = CacheManager.CLS.Cache.TODAS_LAS_CATEGORIAS();
            cbbCategoria.DataSource = cat;
            cbbCategoria.DisplayMember = "Nombre";
            cbbCategoria.ValueMember = "IDCategoria";
        }

        private void CargarUnidades()
        {
            DataTable unidad = new DataTable();
            unidad = CacheManager.CLS.Cache.TODAS_LAS_UNIDADES();
            cbbUnidad.DataSource = unidad;
            cbbUnidad.DisplayMember = "Unidad";
            cbbUnidad.ValueMember = "IDUnidad";
        }

        public ProductoEdicion()
        {
            InitializeComponent();
            CargarCategorias();
            CargarUnidades();
            CacheManager.CLS.Comandos.CrearCarpeta("Productos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog seleccionar = new OpenFileDialog();
                seleccionar.Filter = "Imagen (*.jpg) | *.jpg|Imagen (*.png) | *.png|Todos los archivos (*.*) | *.*";
                seleccionar.Title = "Selecciona Imagen";
                seleccionar.InitialDirectory = @"C:\Productos";
                seleccionar.RestoreDirectory = true;
                DialogResult resultado = seleccionar.ShowDialog();


                if (resultado == DialogResult.OK)
                {
                    pbProducto.Image = Image.FromFile(seleccionar.FileName); 
                }
            }
            catch
            {

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            MarcaGestion f = new MarcaGestion();
            f.btnSeleccionar.Visible = true;
            f.ShowDialog();
            txbMarca.Text = f.dtgMarcas.CurrentRow.Cells["IDMarca"].Value.ToString();
        }

        private void txbMarca_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
