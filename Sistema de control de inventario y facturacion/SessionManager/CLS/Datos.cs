using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionManager.CLS
{
    public class Datos
    {
        DataTable _PERMISOS = new DataTable();
        String _IDUsuario;

        public String IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        String _Usuario;

        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        String _IDRol;

        public String IDRol
        {
            get { return _IDRol; }
            set
            {
                _IDRol = value;
                    ObtenerPermisos(); }
        }
        String _Rol;

        public String Rol
        {
            get { return _Rol; }
            set { _Rol = value; }
        }

        public void ObtenerPermisos()
        {
            try
            {
                _PERMISOS = CacheManager.CLS.Cache.PERMISOS_DE_UN_ROL(_IDRol);
            }
            catch
            {
            }
        }

        public Boolean VerificarPermiso(Int32 pOpcion)
        {
            ObtenerPermisos();
            Boolean Autorizado = false;
            String IDOpcionLocal;
            try
            {
                foreach (DataRow Fila in _PERMISOS.Rows)
                {

                    IDOpcionLocal = Fila["IDOpcion"].ToString();
                    if (IDOpcionLocal.Equals(pOpcion.ToString()))
                    {
                        Autorizado = true;
                        break;
                    }
                }
            }
            catch
            {
                Autorizado = false;
            }

            if (Autorizado == false)
            {
               // MessageBox.Show("No cuenta con el permiso nesesario para ejecutar esta tarea","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            return Autorizado;
        }
        
    }
}
