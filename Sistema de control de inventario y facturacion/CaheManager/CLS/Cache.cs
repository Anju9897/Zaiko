﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager.CLS
{
    public static class Cache
    {
        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"select a.IDUsuario, a.Usuario, a.Credencial, a.IDRol, b.rol , a.IDEmpleado, concat(c.nombres,' ',c.Apellidos) as 'Empleado'
                             from usuarios a, roles b, empleados c
                             where a.IDRol = b.IDRol and  a.IDEmpleado = c.IDempleado;";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable TODOS_LOS_EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"select 
                                e.idEmpleado,u.idusuario, e.nombre, e.apellidos, e.DUI, e.NIT, 
                                e.direccion,
                                ifnull(u.usuario,'') as 'Usuario', 
                                ifnull(u.Credencial,'') as 'Credencial', ifnull(r.rol,'') as 'rol', e.telefono, e.genero, e.fechaNac 
                                from empleados e inner join usuario u on u.idempleado=e.idempleado
                                inner join rol r on u.idrol = r.idrol;";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"select IDRol, Rol from rol;";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable TODOS_LOS_PRODUCTOS()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"select 
                            p.idproducto, i.idinventario,m.idmarca, p.codigo, p.nombre, 
                            p.descripcion, m.mnombre, i.existencias, i.preciounitario, u.Unidad 
                            from producto p
                            inner join unidades u on p.idUnidad = u.idUnidad 
                            inner join inventario i on p.idProducto = i.idProducto 
                            inner join marca m on m.idmarca = p.idmarca;";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable TODAS_LAS_MARCAS()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"select idmarca,mnombre from marca";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable TODAS_LAS_CATEGORIAS()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"select idcategoria,nombre from categorias";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable TODAS_LAS_UNIDADES() 
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"select idunidad,Unidad from unidades";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }
       
        public static DataTable TODOS_LOS_CLIENTES()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"select idPersonas, concat(nombres,' ',apellidos) as 'Nombres',TipoPersona,
                               ifnull(DUI,'') as 'DUI',
                               ifnull(NIT,'') as NIT,
                               ifnull(NRC,'') as NRC,
                               Giro,Direccion,Categoria from Personas";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable PERMISOS_DE_UN_ROL(String idRol)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"Select IDPermiso,IDOpcion,
                            (Select Opciones from opcion z where z.IDOpcion = a.IDOpcion) as 'Opcion',
                            IDRol from permiso a where a.IDRol =" + idRol + ";";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable TODOS_LOS_MOVIMIENTOS(String pTransaccion)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"SELECT
                                m.idmovimiento, m.estado,m.idpersona as 'IDPERSONA', concat(p.nombres,' ', p.apellidos) as 'cliente',date(m.FECHA) as 'fecha',
                                m.tipocomprobante,m.numcomprobante,m.condpago,
                                ifnull(m.banco,'') as 'banco',
                                ifnull(m.propietariocuenta,'') as 'propietariocuenta',
                                ifnull(m.ncuenta,'') as 'ncuenta',
                                ifnull(m.subtotal,'0.00') as 'Subtotal',
                                ifnull(m.IVATOTAL,'0.00') as 'IVATOTAL',
                                ifnull(m.TOTAL,'0.00') as 'total',m.transaccion
                                from movimientos m inner join personas p on p.idpersonas = m.idpersona where Transaccion='"+ pTransaccion +"';";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable TODOS_LOS_MOVIMIENTOS_COMPRAS()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"SELECT
                                m.idmovimiento, m.estado,m.idpersona as 'idpersona',concat(p.nombres,' ', p.apellidos) as  'cliente',date(m.FECHA) as 'fecha',
                                m.tipocomprobante as 'tipodocumento',m.numcomprobante as 'numdocumento',m.condpago,
                                ifnull(m.subtotal,'0.00') as 'Subtotal',
                                ifnull(m.IVATOTAL,'0.00') as 'IVATOTAL',
                                ifnull(m.TOTAL,'0.00') as 'total', m.transaccion as 'Transaccion' 
                                from movimientos m inner join personas p on m.idpersona = p.idpersonas where m.Transaccion='Compra';";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable ASIGNACIONES_DE_PERMISOS_SEGUN_IDROL(String idRol)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"Select
                            IDOpcion, Opciones, a.IDClasificacion,b.Clasificacion,
                            IFNULL((SELECT IDPermiso from permiso z where z.IDRol = " + idRol + @" and z.IDOpcion=a.IDOpcion),0) as 'IDPermiso',
                            IF(IFNULL((SELECT IDPermiso from permiso z where z.IDRol = " + idRol + @" and z.IDOpcion=a.IDOpcion),0)>0,1,0) as 'Asignado' 
                            from Opcion a inner join Clasificacion b on a.IDClasificacion = b.IDClasificacion;";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        /// CONSILYA REPORTE VENTAS CONTRIBUYENTE - CREDITO FISCAL
        public static DataTable VentaCreditoFiscal(String FechaI, String FechaF)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @" select 
                        c.fecha As Fecha, 
                        c.numComprobante as Comprobante_No,
                        concat(p.nombres,' ',p.apellidos) AS Nombre,
                        p.NRC As NRC,
                        c.subtotal as Gravado,
                        c.IvaTotal as IVA, 
                        c.total As Total ,
                        estado as Estado
                        from movimientos c inner join personas p on c.idpersona = p.idpersonas 
                        where c.fecha>= '" + FechaI + "' and c.fecha<= '" + FechaF + " ' and Transaccion= 'Venta' and TipoComprobante = 'Comprobante de Credito fiscal' and estado != 'Pendiente'; ";
                Resultado = oConsulta.Consultar(Consulta);

             
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        /// CONSILYA REPORTE VENTAS CONSUMIDOR FINAL 
        public static DataTable VentaConsumidorFinal(String FechaI, String FechaF)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"
                        select 
                        c.numComprobante as Registro,
                        c.fecha As Fecha, 
                        ifnull(c.total,'0.00') As Total, 
                        c.estado AS Estado
                        from movimientos c
                         where c.fecha>= '" + FechaI + "' and c.fecha<= '" + FechaF + "' and Transaccion='Venta' and TipoComprobante = 'Factura consumidor final' and estado != 'Pendiente';";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        /// CONSILYA REPORTE COMPRA CREDITOS SICALES 
        public static DataTable CompraCreditoFiscal(String FechaI, String FechaF)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @" select 
                        c.fecha As Fecha, 
                        c.numComprobante as Registro,
                        concat(p.nombres,' ',p.apellidos) AS Nombre,
                        ifnull(c.subtotal,0.00) as Gravado,
                        ifnull(c.IvaTotal,0.00) as IVA, 
                        ifnull(c.total,0.00) As Total 
                        from movimientos c inner join personas p on c.idpersona = p.idpersonas " +
                        "where c.fecha>= '" + FechaI 
                        + "' and c.fecha<= '"+ FechaF 
                        +"' and Transaccion= 'Compra' and TipoComprobante = 'Comprobante de Credito fiscal' and estado != 'Pendiente';";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        // Para el detalle de moviminentos
        public static DataTable TODOS_LOS_PRODUCTOS_DETALLE()
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"select 
                            p.idproducto,i.idinventario as 'idinventario', p.nombre, 
                            p.descripcion, m.mnombre, i.existencias, i.preciounitario,         u.Unidad
                            from producto p
                            inner join unidades u on p.idUnidad = u.idUnidad 
                            inner join inventario i on p.idProducto = i.idProducto 
                            inner join marca m on m.idmarca = p.idmarca;";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable TODOS_LOS_DETALLES_POR_ID(String idmov)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"select dm.idDetalle,i.idinventario as 'inventario',i.idproducto as 'idp', p.nombre as 'Producto',i.existencias as 'exi',
                            dm.Fecha, dm.Precio, 
                            dm.CantitadSalida,
                            u.unidad as 'Unidades',
                            ifnull(dm.Gravado,0.00) as 'Gravado', 
                            dm.MontoIVA, dm.SubTotal
                             from detallemovimiento dm 
                             inner join producto p on p.idProducto=dm.idProducto
                             inner join inventario i on i.idproducto = dm.idproducto
                             inner join unidades u on u.idunidad = p.idunidad where dm.idMovimiento = '" + idmov + "' order by iddetalle asc;";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable TODOS_LOS_DETALLES_COMPRAS_POR_ID(String idmov)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"select dm.idDetalle,i.idinventario as 'inventario',p.idproducto as 'idp', p.nombre as 'Producto', ifnull(i.existencias,0.00) as 'exi',
                            dm.Fecha, dm.Costo, 
                            dm.CantidadEntrada,
                            u.unidad as 'Unidades',
                            ifnull(dm.Gravado,0.00) as 'Gravado', 
                            dm.MontoIVA, dm.SubTotal
                             from detallemovimiento dm 
                             inner join producto p on p.idProducto=dm.idProducto
                             inner join unidades u on u.idunidad = p.idunidad 
                             inner join inventario i on i.idproducto = p.idproducto
                             where dm.idMovimiento = '" + idmov + "' order by iddetalle asc;";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }


        public static DataTable CotizacionConsulta(String idmov)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"select 
							dm.idDetalle,
							p.codigo as Codigo, 
							p.nombre as 'Producto',
                            u.unidad as 'Unidades',
                            p.descripcion as Descrpcion,
                            dm.CantitadSalida as Cantidad,
                            dm.Precio as Precio,
							dm.SubTotal as Total, 
                            mov.numComprobante as NCotizacion
							from detallemovimiento dm 
                            inner join movimientos mov on mov.idMovimiento = dm.idMovimiento
							inner join producto p on p.idProducto=dm.idProducto
							inner join unidades u on u.idunidad = p.idunidad 
                            where  mov.TipoComprobante= 'Cotizacion' and dm.idMovimiento = '"+idmov+"'    order by iddetalle asc ;";
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }


        public static DataTable OBTENER_ELEMENTOS_DETALLEMOV_POR_IDMOV(string idMov)
        {
            DataTable Resultado = new DataTable();
            String Consulta;
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();

            try
            {
                Consulta = @"Select 
                                    dm.iddetalle as 'IDDetalle', 
                                    dm.idproducto as 'IDProducto',
                                    dm.cantitadsalida as 'Cantidad',
                                    i.idinventario as 'idInventario',
                                    i.existencias as 'Existencias' 
                                    from detallemovimiento dm inner join inventario i on dm.idproducto = i.idproducto
                                    where dm.idmovimiento = '" + idMov +"';";

                Resultado = oConsulta.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }
    }
}
