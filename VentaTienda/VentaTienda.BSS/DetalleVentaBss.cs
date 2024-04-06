using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaTienda.DAL;
using VentaTienda.Modelos;

namespace VentaTienda.BSS
{
    public class DetalleVentaBss
    {
        DetalleVentaDal dal = new DetalleVentaDal();
        public DataTable ListarDetalleVentaBss()
        {
            return dal.ListarDetalleVentaDal();
        }
        public void InsertarDetalleVentaBss(DetalleVenta detalleVenta)
        {
            dal.InsertarDetalleVentaDal(detalleVenta);
        }
        public DetalleVenta ObtenerIdBss(int id)
        {
            return dal.ObtenerDetalleVentaId(id);
        }
        public void EditarDetalleVentaBss(DetalleVenta d)
        {
            dal.EditarDetalleVentaDal(d);
        }
        public void EliminarDetalleVentaBss(int id)
        {
            dal.EliminarDetalleVentaDal(id);

        }
        public DataTable DetalleVentaDatosBss()
        {
            return dal.DetalleVentaDatosDal();
        }
        public DataTable DetalleVentaDatosVentasBss(int id)
        {
            return dal.DetalleVentaDatosVentasDal(id);
        }
        public DataTable DetalleVentaDatosDetalleBss(int id)
        {
            return dal.DetalleVentaDatosDetalleDal(id);
        }
    }
}
