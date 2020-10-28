using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaiko.CLS
{
    class AppManager: ApplicationContext
    {
        public AppManager()
        {
            if (Splash())
            {
                if (Login())
                {
                    GUI.Principal f = new GUI.Principal();
                    f.ShowDialog();
                }
            }
        }


        private Boolean Splash()
        {
            Boolean resultado = true;
            GUI.Splash f = new GUI.Splash();
            f.ShowDialog();
            return resultado;
        }

        private Boolean Login()
        {
            Boolean resultado = true;
            GUI.Login f = new GUI.Login();
            f.txbUsuario.Focus();
            f.ShowDialog();
            return resultado;
        }
    }
}
