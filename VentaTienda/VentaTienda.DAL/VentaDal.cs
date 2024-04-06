using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaTienda.Modelos;

namespace VentaTienda.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from venta";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into venta values('" + venta.FechaVenta.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                                                        "" + venta.TotalVenta + ")";

            conexion.Ejecutar(consulta);
        }
        public Venta ObtenerVentaId(int id)
        {
            string consulta = "select * from venta where idventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Venta v = new Venta();

            if (tabla.Rows.Count > 0)
            {
                v.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                v.FechaVenta = Convert.ToDateTime(tabla.Rows[0]["fechaventa"]);
                v.TotalVenta = Convert.ToDecimal(tabla.Rows[0]["totalventa"]);
            }
            return v;

        }
        public void EditarVentaDal(Venta v)
        {
            string consulta = "update venta set fechaventa='" + v.FechaVenta.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                                                  "totalventa=" + v.TotalVenta + "" +
                                              "where idventa=" + v.IdVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarVentaDal(int id)
        {
            string consulta = "delete from venta where idventa=" + id;
            conexion.Ejecutar(consulta);
        }
      

    }
}
