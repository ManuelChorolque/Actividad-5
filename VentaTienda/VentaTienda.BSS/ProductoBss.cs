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
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductoDal();
        }
        public void InsertarProductoBss(Producto producto)
        {
            dal.InsertarProductoDal(producto);
        }
        public Producto ObtenerIdBss(int id)
        {
            return dal.ObtenerProductoId(id);
        }
        public void EditarProductoBss(Producto p)
        {
            dal.EditarProductoDal(p);
        }
        public void EliminarProductoBss(int id)
        {
            dal.EliminarProductoDal(id);

        }
    }
}
