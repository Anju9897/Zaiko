using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Movimiento
    {
        String _IDMovimiento;

        public String IDMovimiento
        {
            get { return _IDMovimiento; }
            set { _IDMovimiento = value; }
        }

        String _IDUsuario;

        public String IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        String _Cliente;

        public String Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }

        String _Direccion;

        public String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        String _CondPago;

        public String CondPago
        {
            get { return _CondPago; }
            set { _CondPago = value; }
        }

        String _TDoc;

        public String TDoc
        {
            get { return _TDoc; }
            set { _TDoc = value; }
        }

        String _NDoc;

        public String NDoc
        {
            get { return _NDoc; }
            set { _NDoc = value; }
        }

        String _Giro;

        public String Giro
        {
            get { return _Giro; }
            set { _Giro = value; }
        }

        String _TComprobante;

        public String TComprobante
        {
            get { return _TComprobante; }
            set { _TComprobante = value; }
        }

        String _nComprobante;

        public String NComprobante
        {
            get { return _nComprobante; }
            set { _nComprobante = value; }
        }

        String _Fecha;

        public String Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        String _Transaccion;

        public String Transaccion
        {
            get { return _Transaccion; }
            set { _Transaccion = value; }
        }

        String _total;

        public String Total
        {
            get { return _total; }
            set { _total = value; }
        }

        String _Estado;

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        String _IvaTotal;

        public String IvaTotal
        {
            get { return _IvaTotal; }
            set { _IvaTotal = value; }
        }

        String _Subtotal;

        public String Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Insert into Movimientos(idUsuario, Cliente,
                              Direccion, condPago, tipoDocumento, numDocumento, Giro,
                              TipoComprobante, numComprobante, fecha, Transaccion, estado) Values(";
                Sentencia += "'" + IDUsuario + "',";
                Sentencia += "'" + Cliente + "',";
                Sentencia += "'" + Direccion + "',";
                Sentencia += "'" + CondPago + "',";
                Sentencia += "'" + TDoc + "',";
                Sentencia += "'" + NDoc + "',";
                Sentencia += "'" + Giro + "',";
                Sentencia += "'" + TComprobante + "',";
                Sentencia += "'" + NComprobante + "',";
                Sentencia += "'" + Fecha + "',";
                Sentencia += "'" + Transaccion + "',";
                Sentencia += "'" + Estado + "');";
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

        public Boolean Actualizar_Total()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Update Movimientos set ";
                Sentencia += "Subtotal='" + Subtotal + "', ";
                Sentencia += "IVATOTAL='" + IvaTotal + "', ";
                Sentencia += "Total='" + Total + "' ";
                Sentencia += "Where idMovimiento='" + IDMovimiento + "';";

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

        public Boolean Actualizar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Update Movimientos set ";
                Sentencia += "idUsuario='" + IDUsuario + "',";
                Sentencia += "Cliente='" + Cliente + "',";
                Sentencia += "Direccion='" + Direccion + "',";
                Sentencia += "condPago='" + CondPago + "',";
                Sentencia += "tipoDocumento='" + TDoc + "',";
                Sentencia += "numDocumento='" + NDoc + "',";
                Sentencia += "Giro='" + Giro + "',";
                Sentencia += "TipoComprobante='" + TComprobante + "',";
                Sentencia += "numComprobante='" + NComprobante + "',";
                Sentencia += "fecha='" + Fecha + "',";
                Sentencia += "estado='" + Estado + "'";
                Sentencia += "Where idMovimiento='" + IDMovimiento + "';";

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

        public Boolean Actualizar_Anulado()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                CLS.DetalleMovimiento dm = new DetalleMovimiento();
                dm.IDMovimiento = IDMovimiento;
                dm.Eliminar_Detalles();
                Sentencia = @"Update Movimientos set ";
                Sentencia += "Estado='" + Estado + "',";
                Sentencia += "Subtotal='" + Subtotal + "',";
                Sentencia += "IVATOTAL='" + IvaTotal + "',";
                Sentencia += "Total='" + Total + "' ";
                Sentencia += "Where idMovimiento='" + IDMovimiento + "';";

                if (Operacion.Actualizar(Sentencia) > 0)
                {
                    Guardado = true;
                }
                else
                {
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
            DetalleMovimiento dm = new DetalleMovimiento();
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                dm.IDMovimiento = IDMovimiento;
                dm.Eliminar_Detalles();
                Sentencia = @"Delete from Movimientos ";
                Sentencia += @"Where IDMovimiento= '" + IDMovimiento + "';";

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
