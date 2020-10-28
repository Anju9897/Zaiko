using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Empleado
    {
        String _idEmpleado;

        public String IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }
        String _Nombre;

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        String _Apellidos;

        public String Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }
        String _DUI;

        public String DUI
        {
            get { return _DUI; }
            set { _DUI = value; }
        }
        String _NIT;

        public String NIT
        {
            get { return _NIT; }
            set { _NIT = value; }
        }
        String _Direccion;

        public String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        String _Telefono;

        public String Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        String _Genero;

        public String Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
        }
        String _FechaNacimiento;

        public String FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        //Metodos

        public DataTable getIDempleado(String pDUI)
        {
            DataManager.CLS.DBOperacion oOperacion = new DataManager.CLS.DBOperacion();
            DataTable id = new DataTable();
            try
            {
               String sentencia = @"select idempleado from empleados where dui='" + pDUI + "';";
               id = oOperacion.Consultar(sentencia);
               return id;
            }
                
            catch
            {
                return new DataTable();
            }
            
        }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"insert into 
                              Empleados(nombre, apellidos, DUI, NIT, direccion, telefono, genero, fechaNac) 
                              Values(";
                Sentencia += "'" + Nombre + "',";
                Sentencia += "'" + Apellidos + "',";
                Sentencia += "'" + DUI + "',";
                Sentencia += "'" + NIT + "',";
                Sentencia += "'" + Direccion + "',";
                Sentencia += "'" + Telefono + "',";
                Sentencia += "'" + Genero + "',";
                Sentencia += "'" + FechaNacimiento + "'";
                Sentencia += @");";

                if (Operacion.Insertar(Sentencia) > 0)
                {
                    //MessageBox.Show("Registro Insertado con Éxito","Confirmacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("El Registro no se pudo realizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Sentencia = @"Update Empleados set ";
                Sentencia += "nombre= '" + Nombre + "',";
                Sentencia += "apellidos= '" + Apellidos + "',";
                Sentencia += "DUI= '" + DUI + "',";
                Sentencia += "NIT= '" + NIT + "',";
                Sentencia += "direccion= '" + Direccion + "',";
                Sentencia += "Telefono= '" + Telefono + "',";
                Sentencia += "genero= '" + Genero + "',";
                Sentencia += "fechaNac= '" + FechaNacimiento + "'";
                Sentencia += @"Where idEmpleado= '" + IdEmpleado + "';";

                if (Operacion.Actualizar(Sentencia) > 0)
                {
                    MessageBox.Show("Registro Actualizado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("El Registro no se pudo Actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un Error al Actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Guardado = false;
            }
            return Guardado;
        }

        public Boolean Eliminar()
        {
            Boolean Eliminado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Delete from Empleados ";
                Sentencia += @"Where idEmpleado= '" + IdEmpleado + "';";

                if (Operacion.Eliminar(Sentencia) > 0)
                {
                    MessageBox.Show("Registro Eliminado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Eliminado = true;
                }
                else
                {
                    MessageBox.Show("El Registro no se pudo Eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Eliminado = false;
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un Error al Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Eliminado = false;
            }
            return Eliminado;
        }
    }
}
