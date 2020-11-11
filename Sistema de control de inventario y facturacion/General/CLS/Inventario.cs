using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Inventario
    {
        String _IDInventario;

        public String IDInventario
        {
            get { return _IDInventario; }
            set { _IDInventario = value; }
        }

        String _idProducto;

        public String IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        String _Existencias;

        public String Existencias
        {
            get { return _Existencias; }
            set { _Existencias = value; }
        }

        String _IDUnidades;

        public String IDUnidades
        {
            get { return _IDUnidades; }
            set { _IDUnidades = value; }
        }

        String _PrecioUnitario;

        public String PrecioUnitario
        {
            get { return _PrecioUnitario; }
            set { _PrecioUnitario = value; }
        }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Insert into Inventario(idProducto, Existencias, IDUnidades, PrecioUnitario) Values(";
                Sentencia += "'" + IdProducto + "',";
                Sentencia += "" + Existencias + ",";
                Sentencia += "'" + IDUnidades + "',";
                Sentencia += "" + PrecioUnitario + ");";
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

        public Boolean Actualizar_Existencias()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Update Inventario set ";
                Sentencia += "Existencias='" + Existencias + "'";
                Sentencia += "Where idProducto='" + IdProducto + "' or idInventario='"+ IDInventario +"';";

                if (Operacion.Actualizar(Sentencia) > 0)
                {
                    MessageBox.Show("Existencias Actualizadas con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public Boolean Actualizar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Update Inventario set ";
                Sentencia += "idProducto='" + IdProducto + "',";
                Sentencia += "Existencias='" + Existencias + "',";
                Sentencia += "IDUnidades='" + IDUnidades + "',";
                Sentencia += "PrecioUnitario='" + PrecioUnitario + "'";
                Sentencia += "Where idInventario='" + IDInventario + "';";

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
                Sentencia = @"Delete from Inventario ";
                Sentencia += @"Where IDInventario= '" + IDInventario + "';";

                if (Operacion.Eliminar(Sentencia) > 0)
                {
                    MessageBox.Show("Registro Eliminado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo Eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
