using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Permiso
    {
        String _IDPermiso;

        public String IDPermiso
        {
            get { return _IDPermiso; }
            set { _IDPermiso = value; }
        }
        String _IDRol;

        public String IDRol
        {
            get { return _IDRol; }
            set { _IDRol = value; }
        }
        String _IDOpcion;

        public String IDOpcion
        {
            get { return _IDOpcion; }
            set { _IDOpcion = value; }
        }

        public Boolean Conceder()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"INSERT INTO PERMISO(IDRol, IDOpcion) VALUES (";
                Sentencia += "'" + IDRol + "',";
                Sentencia += "'" + IDOpcion + "');";

                if (Operacion.Insertar(Sentencia) > 0)
                {
                    MessageBox.Show("Permiso Concedido con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("El Permiso No fue Concedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }
            }
            catch
            {
                MessageBox.Show("Ha Ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Guardado = false;
            }
            return Guardado;
        }

        public Boolean Revocar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"DELETE FROM PERMISO ";
                Sentencia += "WHERE IDPermiso='" + IDPermiso + "';";

                if (Operacion.Eliminar(Sentencia) > 0)
                {
                    MessageBox.Show("Permiso revocado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("El Permiso No fue revocado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }
            }
            catch
            {
                MessageBox.Show("Ha Ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Guardado = false;
            }
            return Guardado;
        }
    }
}
