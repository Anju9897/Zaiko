using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Empresa
    {
        String _IDEmpresa;
        public String IDEmpresa
        {
            get { return _IDEmpresa; }
            set { _IDEmpresa = value; }
        }

        String _Nombre;
        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        String _Direccion;

        public String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        String _NIT;
        public String NIT
        {
            get { return _NIT; }
            set { _NIT = value; }
        }

        String _NRC;
        public String NRC
        {
            get { return _NRC; }
            set { _NRC = value; }
        }

        String _Encargado;
        public String Encargado
        {
            get { return _Encargado; }
            set { _Encargado = value; }
        }

        String _NEncargado;
        public String NEncargado
        {
            get { return _NEncargado; }
            set { _NEncargado = value; }
        }

        String _Anio;
        public String Anio
        {
            get { return _Anio; }
            set { _Anio = value; }
        }

        

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Insert into Empresas(NombreEmpresa, direccion, NIT, NRC, tipoEncargado, NombreEncargado, AnioEjercicio) Values(";
                Sentencia += "'" + Nombre + "',";
                Sentencia += "'" + Direccion + "',";
                Sentencia += "'" + NIT + "',";
                Sentencia += "'" + NRC + "',";
                Sentencia += "'" + Encargado + "',";
                Sentencia += "'" + NEncargado + "',";
                Sentencia += "'" + Anio + "');";
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
                Sentencia = @"Update Empresas set ";
                Sentencia += "NombreEmpresa= '" + Nombre + "',";
                Sentencia += "direccion= '" + Direccion + "',";
                Sentencia += "NIT= '" + NIT + "',";
                Sentencia += "NRC= '" + NRC + "',";
                Sentencia += "tipoEncargado= '" + Encargado + "',";
                Sentencia += "NombreEncargado'" + NEncargado + "',";
                Sentencia += "AnioEjercicio= '" + Anio + "'";
                Sentencia += "Where idEmpresa='" + IDEmpresa + "';";

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
                Sentencia = @"Delete from Empresas";
                Sentencia += @"Where IDEmpresa= '" + IDEmpresa + "';";

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
