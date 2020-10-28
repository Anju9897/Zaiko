using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Tiraje
    {
        String _IDTiraje;

        public String IDTiraje
        {
            get { return _IDTiraje; }
            set { _IDTiraje = value; }
        }
        String _Fecha;

        public String Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        String _Comprobante;

        public String Comprobante
        {
            get { return _Comprobante; }
            set { _Comprobante = value; }
        }
        String _DESDE;

        public String DESDE
        {
            get { return _DESDE; }
            set { _DESDE = value; }
        }
        String _Hasta;

        public String Hasta
        {
            get { return _Hasta; }
            set { _Hasta = value; }
        }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"insert into 
                              Tiraje(Fecha, TipoComprobante, DEL, AL) 
                              Values(";
                Sentencia += "'" + Fecha + "',";
                Sentencia += "'" + Comprobante + "',";
                Sentencia += "'" + DESDE + "',";
                Sentencia += "'" + Hasta + "'";
                Sentencia += @");";

                if (Operacion.Insertar(Sentencia) > 0)
                {
                    MessageBox.Show("Registro Insertado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("El Registro no se pudo Insertar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Sentencia = @"Update Tiraje set ";
                Sentencia += "Fecha= '" + Fecha + "',";
                Sentencia += "TipoComprobante= '" + Comprobante + "',";
                Sentencia += "Del= '" + DESDE + "',";
                Sentencia += "Al='" + Hasta + "'";
                Sentencia += @"Where IDTiraje= '" + IDTiraje + "';";

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
                Sentencia = @"Delete from Tiraje ";
                Sentencia += @"Where IDTiraje= '" + IDTiraje + "';";

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
