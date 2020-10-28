using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Usuario
    {
        String _IDUsuario;

        public String IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        String _IDRol;

        public String IDRol
        {
            get { return _IDRol; }
            set { _IDRol = value; }
        }

        String _IDEmpleado;

        public String IDEmpleado
        {
            get { return _IDEmpleado; }
            set { _IDEmpleado = value; }
        }

        String _User;

        public String User
        {
            get { return _User; }
            set { _User = value; }
        }

        String _Credencial;

        public String Credencial
        {
            get { return _Credencial; }
            set { _Credencial = value; }
        }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"insert into 
                              Usuario(idRol, idEmpleado, Usuario, Credencial) 
                              Values(";
                Sentencia += "'" + IDRol + "',";
                Sentencia += "'" + IDEmpleado + "',";
                Sentencia += "'" + User + "',";
                Sentencia += "md5(sha1('" + Credencial + "'))";
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
                Sentencia = @"Update Usuario set ";
                Sentencia += "idRol= '" + IDRol + "',";
                Sentencia += "idEmpleado= '" + IDEmpleado + "',";
                Sentencia += "Usuario= '" + User + "',";
                Sentencia += "Credencial= md5(sha1('" + Credencial + "'))";
                Sentencia += @"Where IDUsuario= '" + IDUsuario + "';";

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
                Sentencia = @"Delete from Usuario ";
                Sentencia += @"Where IDUsuario= '" + IDUsuario + "';";

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
