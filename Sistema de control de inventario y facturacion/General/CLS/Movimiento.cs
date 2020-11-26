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
        String _IDUsuario;
        String _IDPersona;
        String _CondPago;
        String _TComprobante;
        String _nComprobante;
        String _Fecha;
        String _Transaccion;
        String _Subtotal;
        String _IvaTotal;
        String _Estado;
        String _total;

        String _BANCO;

        public String BANCO
        {
            get { return _BANCO; }
            set { _BANCO = value; }
        }
        String _PROPIETARIO;

        public String PROPIETARIO
        {
            get { return _PROPIETARIO; }
            set { _PROPIETARIO = value; }
        }
        String _NCUENTA;

        public String NCUENTA
        {
            get { return _NCUENTA; }
            set { _NCUENTA = value; }
        }
       

        public String IDPersona
        {
            get { return _IDPersona; }
            set { _IDPersona = value; }
        }

        public String IDMovimiento
        {
            get { return _IDMovimiento; }
            set { _IDMovimiento = value; }
        }

        public String IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        public String CondPago
        {
            get { return _CondPago; }
            set { _CondPago = value; }
        }

        public String TComprobante
        {
            get { return _TComprobante; }
            set { _TComprobante = value; }
        }

        public String NComprobante
        {
            get { return _nComprobante; }
            set { _nComprobante = value; }
        }

        public String Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public String Transaccion
        {
            get { return _Transaccion; }
            set { _Transaccion = value; }
        }

        public String Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public String Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public String IvaTotal
        {
            get { return _IvaTotal; }
            set { _IvaTotal = value; }
        }

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
                Sentencia = @"Insert into Movimientos(idUsuario,idpersona, condPago, Banco, PropietarioCuenta, nCuenta,
                              TipoComprobante, numComprobante, fecha, Transaccion, estado) Values(";
                Sentencia += "'" + IDUsuario + "',";
                Sentencia += "'" + IDPersona + "',";
                Sentencia += "'" + CondPago + "',";
                Sentencia += "'" + BANCO + "',";
                Sentencia += "'" + PROPIETARIO + "',";
                Sentencia += "'" + NCUENTA + "',";
                Sentencia += "'" + TComprobante + "',";
                Sentencia += "'" + NComprobante + "',";
                Sentencia += "'" + Fecha + "',";
                Sentencia += "'" + Transaccion + "',";
                Sentencia += "'" + Estado + "');";
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    MessageBox.Show("Movimiento Insertado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el registro del movimiento, revisar la información", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }

            }
            catch
            {
                MessageBox.Show("Error al insertar el movimiento, revise si los datos han sido ingresados correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Sentencia = @"update Movimientos set ";
                Sentencia += "idUsuario='" + IDUsuario + "',";
                Sentencia += "idpersona='" + IDPersona + "',";
                Sentencia += "condPago='" + CondPago + "',";
                Sentencia += "Banco='" + BANCO + "',";
                Sentencia += "PropietarioCuenta='" + PROPIETARIO + "',";
                Sentencia += "nCuenta='" + NCUENTA + "',";
                Sentencia += "TipoComprobante='" + TComprobante + "',";
                Sentencia += "numComprobante='" + NComprobante + "',";
                Sentencia += "fecha='" + Fecha + "',";
                Sentencia += "Transaccion='" + Transaccion + "',";
                Sentencia += "estado='" + Estado + "' where idmovimiento='"+ IDMovimiento +"';";

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
                Sentencia = @"Update Movimientos set ";
                Sentencia += "Estado='" + Estado + "' ";
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
