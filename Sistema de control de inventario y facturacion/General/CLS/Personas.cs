using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Personas
    {

        String _IDPersonas;
        String _TipoPersona;
        String _Nombres;
        String _Apellidos;
        String _DUI;
        String _NIT;
        String _NRC;
        String _Giro;
        String _Direccion;
        String _Categoria;

        public String Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }

        public String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public String Giro
        {
            get { return _Giro; }
            set { _Giro = value; }
        }

        public String NRC
        {
            get { return _NRC; }
            set { _NRC = value; }
        }

        public String NIT
        {
            get { return _NIT; }
            set { _NIT = value; }
        }

        public String DUI
        {
            get { return _DUI; }
            set { _DUI = value; }
        }

        public String Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        public String Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        public String TipoPersona
        {
            get { return _TipoPersona; }
            set { _TipoPersona = value; }
        }

        public String IDPersonas
        {
            get { return _IDPersonas; }
            set { _IDPersonas = value; }
        }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Insert into Personas(TipoPersona, Nombres,Apellidos,DUI,NIT,NRC,Giro, Direccion,Categoria) Values(";
                Sentencia += "'" + TipoPersona + "',";
                Sentencia += "'" + Nombres + "',";
                Sentencia += "'" + Apellidos + "',";
                Sentencia += "'" + DUI + "',";
                Sentencia += "'" + NIT + "',";
                Sentencia += "'" + NRC + "',";
                Sentencia += "'" + Giro + "',";
                Sentencia += "'" + Direccion + "',";
                Sentencia += "'" + Categoria + "');";
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    MessageBox.Show("Cliente Registrado Insertado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el registro del Cliente, verificar informacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion con la base de datos "  , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Sentencia = @"Update Personas set ";
                Sentencia += "TipoPersona='" + TipoPersona + "',";
                Sentencia += "Nombres='" + Nombres + "',";
                Sentencia += "Apellidos='" + Apellidos + "',";
                Sentencia += "DUI='" + DUI + "',";
                Sentencia += "NRC='" + NRC + "',";
                Sentencia += "Giro='" + Giro + "',";
                Sentencia += "Direccion='" + Direccion + "',";
                Sentencia += "Categoria='" + Categoria + "' ";
                Sentencia += "Where IDPersonas='" + IDPersonas + "';";

                if (Operacion.Actualizar(Sentencia) > 0)
                {
                    MessageBox.Show("Informacion de Cliente Actualizado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar al cliente, verifique la informacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    Guardado = false;
                }

            }
            catch
            {
                MessageBox.Show("Error al Actualizar, problemas al conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Sentencia = @"Delete from Personas";
                Sentencia += @"Where IDPersona= '" + IDPersonas + "';";

                if (Operacion.Eliminar(Sentencia) > 0)
                {
                    MessageBox.Show("Cliente Eliminado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo Eliminar, deben de haber dependencias con este cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }

            }
            catch
            {
                MessageBox.Show("Error al Eliminar, problema con la conexion a base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Guardado = false;
            }
            return Guardado;
        }
    }
}
