using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Producto
    {
        String _IDProducto;

        public String IDProducto
        {
            get { return _IDProducto; }
            set { _IDProducto = value; }
        }

        String _IDMarca;

        public String IDMarca
        {
            get { return _IDMarca; }
            set { _IDMarca = value; }
        }

        String _IDCategoria;

        public String IDCategoria
        {
            get { return _IDCategoria; }
            set { _IDCategoria = value; }
        }

        String _IDUnidad;

        public String IDUnidad
        {
            get { return _IDUnidad; }
            set { _IDUnidad = value; }
        }

        String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        String _Nombre;

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        String _Descripcion;

        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        byte[] _Imagen;

        public byte[] Imagen
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }

        String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        List<Producto> _lProducto = new List<Producto>();

        public List<Producto> LProducto
        {
            get { return _lProducto; }
        }

        public void addProducto(Producto pProducto)
        {
            if (pProducto != null)
            {
                _lProducto.Add(pProducto);
            }
        }

        public String ObtenerID(String pCodigo)
        {
            int id = 0;
            String sentencia;
            DataTable resultado = new DataTable();
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                sentencia = @"Select idproducto from producto where codigo='" + pCodigo + "';";
                resultado = Operacion.Consultar(sentencia);
                if (resultado != null)
                {
                    id = resultado.Rows[0].Field<Int32>("idproducto");
                }
            }
            catch 
            {
            }
            return id.ToString();
        }

        public byte[] obtenerImagen(String id){
            byte[] img = null;
            String sentencia;
            DataTable resultado = new DataTable();
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                sentencia = @"Select imagen from producto where idproducto='" + id + "';";
                resultado = Operacion.Consultar(sentencia);
                if (resultado != null)
                {
                    img = resultado.Rows[0].Field<byte[]>("imagen");
                }
            }
            catch 
            {
            }
            return img;
        }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Insert into Producto(IDMarca, IDCategoria, IDUnidad, Codigo, Nombre, Descripcion, Imagen, Estado) Values(";
                Sentencia += "'" + IDMarca + "',";
                Sentencia += "'" + IDCategoria + "',";
                Sentencia += "'" + IDUnidad + "',";
                Sentencia += "'" + Codigo + "',";
                Sentencia += "'" + Nombre + "',";
                Sentencia += "'" + Descripcion + "',";
                Sentencia += "'" + Imagen + "',";
                Sentencia += "'" + Estado + "');";
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    MessageBox.Show("Registro Insertado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }

            }
            catch
            {
                MessageBox.Show("Error al insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Guardado = false;
            }
            return Guardado;
        }

        public Boolean Actualizar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Update Producto set ";
                Sentencia += "IDMarca='" + IDMarca + "',";
                Sentencia += "IDCategoria='" + IDCategoria + "',";
                Sentencia += "IDUnidad='" + IDUnidad + "',";
                Sentencia += "Codigo='" + Codigo + "',";
                Sentencia += "Nombre='" + Nombre + "',";
                Sentencia += "Descripcion='" + Descripcion + "',";
                Sentencia += "Imagen='" + Imagen + "',";
                Sentencia += "Estado='" + Estado + "'";
                Sentencia += @"Where idProducto='" + IDProducto + "';";

                if (Operacion.Actualizar(Sentencia) > 0)
                {
                    MessageBox.Show("Registro Actualizado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }

            }
            catch
            {
                MessageBox.Show("Error al Actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Guardado = false;
            }
            return Guardado;
        }

        public Boolean Eliminar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Delete from Producto ";
                Sentencia += @"Where IDProducto= '" + IDProducto + "';";

                if (Operacion.Eliminar(Sentencia) > 0)
                {
                   // MessageBox.Show("Registro Eliminado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                   // MessageBox.Show("No se pudo Eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }

            }
            catch
            {
                MessageBox.Show("Error al Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Guardado = false;
            }
            return Guardado;
        }
    }
}
