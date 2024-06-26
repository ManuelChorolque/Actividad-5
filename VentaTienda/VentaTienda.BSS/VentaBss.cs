﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaTienda.DAL;
using VentaTienda.Modelos;

namespace VentaTienda.BSS
{
    public class VentaBss
    {
        VentaDal dal = new VentaDal();
        public DataTable ListarVentaBss()
        {
            return dal.ListarVentaDal();
        }
        public void InsertarVentaBss(Venta venta)
        {
            dal.InsertarVentaDal(venta);
        }
        public Venta ObtenerIdBss(int id)
        {
            return dal.ObtenerVentaId(id);
        }
        public void EditarVentaBss(Venta v)
        {
            dal.EditarVentaDal(v);
        }
        public void EliminarVentaBss(int id)
        {
            dal.EliminarVentaDal(id);

        }
        public DataTable VentaDatosVentasBss(int id)
        {
            return dal.VentaDatosVentasDal(id);
        }
        public DataTable VentaDatosDetalleBss(int id)
        {
            return dal.VentaDatosDetalleDal(id);
        }
    }
}
