using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class Permisos : Form
    {
        Int32 INDICE = 0;
        private void CargarRoles()
        {
            DataTable roles = new DataTable();
            roles = CacheManager.CLS.Cache.TODOS_LOS_ROLES();
            cbbRoles.DataSource = roles;
            cbbRoles.DisplayMember = "Rol";
            cbbRoles.ValueMember = "idRol";
        }

        private void CargarAsignaciones()
        {
            DataTable Asignaciones = new DataTable();
            Asignaciones = CacheManager.CLS.Cache.ASIGNACIONES_DE_PERMISOS_SEGUN_IDROL(cbbRoles.SelectedValue.ToString());
            dtgOpciones.AutoGenerateColumns = false;
            dtgOpciones.DataSource = Asignaciones;

            try
            {
                INDICE = dtgOpciones.CurrentRow.Index;

                dtgOpciones.Rows[INDICE].Selected = true;
            }
            catch(Exception ex)
            {
                INDICE = 0;
            }

            
        }

        public Permisos()
        {
            InitializeComponent();
            CargarRoles();
            cbbRoles.SelectedIndex = 0;
            CargarAsignaciones();
        }

        private void cbbRoles_SelectedValueChanged(object sender, EventArgs e)
        {
            
            CargarAsignaciones();
        }

        private void dtgOpciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    Int32 Valor = 0;
                    CLS.Permiso oPermiso = new CLS.Permiso();
                    oPermiso.IDRol = cbbRoles.SelectedValue.ToString();
                    Valor = Convert.ToInt32(dtgOpciones.CurrentRow.Cells["IDPermiso"].Value.ToString());
                    if (Valor > 0)
                    {
                        oPermiso.IDPermiso = Valor.ToString();
                        oPermiso.Revocar();
                    }
                    else
                    {
                        oPermiso.IDOpcion = dtgOpciones.CurrentRow.Cells["IDOpcion"].Value.ToString();
                        oPermiso.Conceder();
                    }
                    CargarAsignaciones();
                }
            }
            catch
            {
            }
        }
    }
}
