using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaTienda.Modelos;

namespace VentaTienda.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "insert into detalleVenta values(" + detalleVenta.IdVenta + "," +
                                                        "" + detalleVenta.IdProducto + "," +
                                                        "" + detalleVenta.Cantidad + "," +
                                                        "" + detalleVenta.PrecioUnitario + "," +
                                                        "" + detalleVenta.TotalDetalle + ")";
            conexion.Ejecutar(consulta);
        }
        public DetalleVenta ObtenerDetalleVentaId(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleVenta d = new DetalleVenta();

            if (tabla.Rows.Count > 0)
            {
                d.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
                d.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                d.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                d.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                d.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["preciounitario"]);
                d.TotalDetalle = Convert.ToDecimal(tabla.Rows[0]["totaldetalle"]);
            }
            return d;

        }
        public void EditarDetalleVentaDal(DetalleVenta d)
        {
            string consulta = "update detalleventa set idventa=" + d.IdVenta + "," +
                                                  "idproducto=" + d.IdProducto + "," +
                                                  "cantidad=" + d.Cantidad + "," +
                                                  "preciounitario=" + d.PrecioUnitario + "," +
                                                  "totaldetalle=" + d.TotalDetalle + "" +
                                              "where iddetalleventa=" + d.IdDetalleVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa=" + id;
            conexion.Ejecutar(consulta);
        }
        public DataTable DetalleVentaDatosDal()
        {
            string consulta = "SELECT DETALLEVENTA.IDDETALLEVENTA, VENTA.FECHAVENTA, PRODUCTO.NOMBREPRODUCTO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOUNITARIO, DETALLEVENTA.TOTALDETALLE " +
                "FROM DETALLEVENTA INNER JOIN PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO " +
                "INNER JOIN VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
        public DataTable DetalleVentaDatosVentasDal(int id)
        {
            string consulta = "SELECT IDVENTA, FECHAVENTA, TOTALVENTA " +
                              "FROM  VENTA WHERE IDVENTA = " + id;
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
        public DataTable DetalleVentaDatosDetalleDal(int id)
        {
            string consulta = "SELECT DETALLEVENTA.IDPRODUCTO, PRODUCTO.NOMBREPRODUCTO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOUNITARIO, DETALLEVENTA.TOTALDETALLE " +
                "FROM  DETALLEVENTA INNER JOIN PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO " +
                "WHERE IDDETALLEVENTA = " + id;
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
