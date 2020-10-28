using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManager.CLS
{
    //Singleton
    public class Sesion
    {
        private static Sesion _Instancia = null;
        Datos _Informacion;

        public static Sesion Instancia
        {
            get 
            {
                if (_Instancia == null)
                {
                    lock (padlock)
                    {
                        if (_Instancia == null)
                        {
                            _Instancia = new Sesion();
                        }
                    }
                }  
                return Sesion._Instancia; 
            }
        }


        public Datos Informacion
        {
            get { return _Informacion; }
            set { _Informacion = value; }
        }

        private static readonly object padlock = new object();

        private Sesion()
        {
            _Informacion = new Datos();
        }



    }
}
