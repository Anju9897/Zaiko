using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace General.CLS
{
    class DetalleMovimiento
    {
        String _IDDetalle;

        public String IDDetalle
        {
            get { return _IDDetalle; }
            set { _IDDetalle = value; }
        }

        String _IDMovimiento;

        public String IDMovimiento
        {
            get { return _IDMovimiento; }
            set { _IDMovimiento = value; }
        }

        String _IDProducto;

        public String IDProducto
        {
            get { return _IDProducto; }
            set { _IDProducto = value; }
        }

        String _Fecha;

        public String Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        Double _Precio;

        public Double Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        Double _Costo;

        public Double Costo
        {
            get { return _Costo; }
            set { _Costo = value; }
        }

        Double _CEntrada;

        public Double CEntrada
        {
            get { return _CEntrada; }
            set { _CEntrada = value; }
        }

        Double _CSalida;

        public Double CSalida
        {
            get { return _CSalida; }
            set { _CSalida = value; }
        }

        Double _NoSujeto;

        public Double NoSujeto
        {
            get { return _NoSujeto; }
            set { _NoSujeto = value; }
        }

        Double _Exento;

        public Double Exento
        {
            get { return _Exento; }
            set { _Exento = value; }
        }

        Double _Gravado;

        public Double Gravado
        {
            get { return _Gravado; }
            set { _Gravado = value; }
        }

        Double _IVA;

        public Double IVA
        {
            get { return _IVA; }
            set { _IVA = value; }
        }

        Double _SubTotal;

        public Double SubTotal
        {
            get { return _SubTotal; }
            set { _SubTotal = value; }
        }

        Double _PSugerido;

        public Double PSugerido
        {
            get { return _PSugerido; }
            set { _PSugerido = value; }
        }

        public Boolean Guardar_Venta()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            try
            {
                Sentencia = @"Insert into DetalleMovimiento(idMovimiento, idProducto, Fecha, Precio, 
                              CantitadSalida, Gravado, MontoIVA, 
                              SubTotal) Values(";
                Sentencia += "'" + IDMovimiento + "',";
                Sentencia += "'" + IDProducto + "',";
                Sentencia += "'" + Fecha + "',";
                Sentencia += "'" + Precio.ToString(nfi) + "',";
                Sentencia += "'" + CSalida.ToString(nfi) + "',";
                Sentencia += "'" + Gravado.ToString(nfi) + "',";
                Sentencia += "'" + IVA.ToString(nfi) + "',";
                Sentencia += "'" + SubTotal.ToString(nfi) + "');";
                if (Operacion.Insertar(Sentencia.ToString(nfi)) > 0)
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

        public Boolean Actualizar_Venta()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            try
            {
                Sentencia = @"Update DetalleMovimiento set ";
                Sentencia += "idProducto='" + IDProducto + "',";
                Sentencia += "Precio='" + Precio.ToString(nfi) + "',";
                Sentencia += "CantitadSalida='" + CSalida.ToString(nfi) + "',";
                Sentencia += "Gravado='" + Gravado.ToString(nfi) + "',";
                Sentencia += "MontoIVA='" + IVA.ToString(nfi) + "',";
                Sentencia += "SubTotal='" + SubTotal.ToString(nfi) + "' where idmovimiento='"+IDMovimiento+"' and iddetalle='"+IDDetalle+"';";
                if (Operacion.Insertar(Sentencia.ToString(nfi)) > 0)
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

        public Boolean Guardar_Compra()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            try
            {
                Sentencia = @"Insert into DetalleMovimiento(idMovimiento, idProducto, Fecha, Costo, 
                              CantidadEntrada, Gravado, MontoIVA, 
                              SubTotal) Values(";
                Sentencia += "'" + IDMovimiento + "',";
                Sentencia += "'" + IDProducto + "',";
                Sentencia += "'" + Fecha + "',";
                Sentencia += "'" + Costo.ToString(nfi) + "',";
                Sentencia += "'" + CEntrada.ToString(nfi) + "',";
                Sentencia += "'" + Gravado.ToString(nfi) + "',";
                Sentencia += "'" + IVA.ToString(nfi) + "',";
                Sentencia += "'" + SubTotal.ToString(nfi) + "');";
                if (Operacion.Insertar(Sentencia.ToString(nfi)) > 0)
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

        public Boolean Actualizar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Update DetalleMovimiento SET";
                Sentencia += "idProducto='" + IDProducto + "',";
                Sentencia += "Fecha='" + Fecha + "',";
                Sentencia += "Precio='" + Precio + "',";
                Sentencia += "Costo='" + Costo + "',";
                Sentencia += "CantidadEntrada='" + CEntrada + "',";
                Sentencia += "CantitadSalida='" + CSalida + "',";
                Sentencia += "NoSujeto='" + NoSujeto + "',";
                Sentencia += "Exento='" + Exento + "',";
                Sentencia += "Gravado='" + Gravado + "',";
                Sentencia += "MontoIVA='" + IVA + "',";
                Sentencia += "SubTotal='" + SubTotal + "',";
                Sentencia += "Where idDetalle='" + IDDetalle + "';";

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

        public Boolean Eliminar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Delete from DetalleMovimiento ";
                Sentencia += "Where iddetalle='" + IDDetalle + "';";

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

        public Boolean Eliminar_Detalles()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Delete from DetalleMovimiento ";
                Sentencia += "Where idMovimiento='" + IDMovimiento + "';";

                if (Operacion.Eliminar(Sentencia) > 0)
                {
                   // MessageBox.Show("Registro Eliminado con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    //MessageBox.Show("No se pudo Eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public Boolean Actualizar_Compra()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            try
            {
                Sentencia = @"update DetalleMovimiento set ";
                Sentencia += "idProducto='" + IDProducto + "',";
                Sentencia += "Costo='" + Costo.ToString(nfi) + "',";
                Sentencia += "CantidadEntrada='" + CEntrada.ToString(nfi) + "',";
                Sentencia += "Gravado='" + Gravado.ToString(nfi) + "',";
                Sentencia += "MontoIVA='" + IVA.ToString(nfi) + "',";
                Sentencia += "SubTotal='" + SubTotal.ToString(nfi) + "' where idmovimiento='" + IDMovimiento + "' and iddetalle='" + IDDetalle + "';";
                if (Operacion.Insertar(Sentencia.ToString(nfi)) > 0)
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
    }
}
