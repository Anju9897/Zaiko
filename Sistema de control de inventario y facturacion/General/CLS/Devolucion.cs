using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Devolucion
    {
        String iddevolucion, idmovimiento, iddetalle;

        public String Iddevolucion
        {
            get { return iddevolucion; }
            set { iddevolucion = value; }
        }

        public String Idmovimiento
        {
            get { return idmovimiento; }
            set { idmovimiento = value; }
        }

        public String Iddetalle
        {
            get { return iddetalle; }
            set { iddetalle = value; }
        }
        String fecha, tipoNota;

        public String TipoNota
        {
            get { return tipoNota; }
            set { tipoNota = value; }
        }

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        Double Precio, Costo, cEntrada, cSalida, Gravado, IVA, Subtotal;

        public Double Subtotal1
        {
            get { return Subtotal; }
            set { Subtotal = value; }
        }

        public Double IVA1
        {
            get { return IVA; }
            set { IVA = value; }
        }

        public Double Gravado1
        {
            get { return Gravado; }
            set { Gravado = value; }
        }

        public Double CSalida
        {
            get { return cSalida; }
            set { cSalida = value; }
        }

        public Double CEntrada
        {
            get { return cEntrada; }
            set { cEntrada = value; }
        }

        public Double Costo1
        {
            get { return Costo; }
            set { Costo = value; }
        }

        public Double Precio1
        {
            get { return Precio; }
            set { Precio = value; }
        }


        public Boolean Guardar_devolucion_venta()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Insert into devoluciones( idmovimiento, "/*Fecha,*/+" tipoNota, Precio, cEntrada, Gravado, IVA, Subtotal, iddetalle) Values(";
                Sentencia += Idmovimiento + ",";
                //Sentencia += "'" + Fecha + "',";
                Sentencia += "'" + tipoNota + "',";
                Sentencia += Precio1 + ",";
                Sentencia += cEntrada + ",";
                Sentencia += Gravado1 + ",";
                Sentencia += IVA1 + ",";
                Sentencia += Subtotal1 + ",";
                Sentencia += Iddetalle + ")";
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    MessageBox.Show("Devolucion registrada con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el registro de la devolucion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public Boolean Guardar_devolucion_compra()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Insert into devoluciones(idmovimiento, Fecha, tipoNota, Costo, cSalida, Gravado, IVA, Subtotal, iddetalle) Values(";
                Sentencia += "'" + Idmovimiento + "',";
                Sentencia += "'" + Fecha + "',";
                Sentencia += "'" + tipoNota + "',";
                Sentencia += "'" + Costo1 + "',";
                Sentencia += "'" + CSalida + "',";
                Sentencia += "'" + Gravado1 + "',";
                Sentencia += "'" + IVA1 + "',";
                Sentencia += "'" + Subtotal1 + "',";
                Sentencia += "'" + Iddetalle + "')";
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    MessageBox.Show("Devolucion registrada con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el registro de la devolucion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public Boolean Actualizar_devolucion_venta()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Update devoluciones set ";
                Sentencia += "Precio=" + Precio1 + ",";
                Sentencia += "CEntrada=" + CEntrada + ",";
                Sentencia += "Gravado=" + Gravado1 + ",";
                Sentencia += "IVA=" + IVA1 + ",";
                Sentencia += "SUBTOTAL=" + Subtotal1 + " where iddevolucion = '"+ Iddevolucion +"';";
                if (Operacion.Actualizar(Sentencia) > 0)
                {
                    MessageBox.Show("Devolucion actualizada con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el registro de la devolucion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }

            }
            catch
            {
                MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Guardado = false;
            }
            return Guardado;
        }

        public Boolean eliminar_devolucion_venta()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"delete from devoluciones where iddevolucion = '"+ Iddevolucion +"';";
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    MessageBox.Show("Devolucion elimiada con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la eliminacion de la devolucion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Guardado = false;
                }

            }
            catch
            {
                MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Guardado = false;
            }
            return Guardado;
        }

        public Boolean Actualizar_devolucion_compra()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = @"Update devoluciones set ";
                Sentencia += "idmovimiento='" + Idmovimiento + "',";
                Sentencia += "fecha='" + Fecha + "',";
                Sentencia += "tiponota='" + tipoNota + "',";
                Sentencia += "Costo=" + Costo1 + ",";
                Sentencia += "cSalida=" + CSalida + ",";
                Sentencia += "Gravado=" + Gravado1 + ",";
                Sentencia += "IVA=" + IVA1 + ",";
                Sentencia += "subtotal=" + Subtotal1 + ",";
                Sentencia += "iddetalle=" + Iddetalle + " where iddevolucion = '"+ iddevolucion +"';";
                if (Operacion.Insertar(Sentencia) > 0)
                {
                    MessageBox.Show("Devolucion registrada con Éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el registro de la devolucion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
