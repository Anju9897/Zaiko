using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Marca
    {
        String _IDMarca;

        public String IDMarca
        {
            get { return _IDMarca; }
            set { _IDMarca = value; }
        }

        String _Nombre;

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }


        public Boolean Guardar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Insert into Marca(mnombre) Values(";
                Sentencia += "'" + Nombre + "');";
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    MessageBox.Show("Marca Insertado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el registro de la marca", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }
                
            }
            catch
            {
                MessageBox.Show("Error al insertar la marca, verifica los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Sentencia = @"Update Marca set ";
                Sentencia += "mnombre= '" + Nombre + "' ";
                Sentencia += @"Where idmarca= '" + IDMarca + "';";

                if (Operacion.Actualizar(Sentencia) > 0)
                {
                    MessageBox.Show("Marca Actualizado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar los datos de la marca", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }

            }
            catch
            {
                MessageBox.Show("Error al Actualizar la marca, verifica los datos esten correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Sentencia = @"Delete from Marca ";
                Sentencia += @"Where idmarca= '" + IDMarca + "';";

                if (Operacion.Eliminar(Sentencia) > 0)
                {
                    MessageBox.Show("Marca Eliminado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No es posible Eliminar esta marca debido\na que tiene dependencias de el", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
