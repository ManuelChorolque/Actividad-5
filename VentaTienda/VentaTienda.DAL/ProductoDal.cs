﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaTienda.Modelos;

namespace VentaTienda.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductoDal()
        {
            string consulta = "select * from producto";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into producto values('" + producto.NombreProducto + "'," +
                                                        "" + producto.PrecioUnitario +")";
            conexion.Ejecutar(consulta);
        }
        public Producto ObtenerProductoId(int id)
        {
            string consulta = "select * from producto where idproducto=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Producto p = new Producto();

            if (tabla.Rows.Count > 0)
            {
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.NombreProducto = tabla.Rows[0]["nombreproducto"].ToString();
                p.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["preciounitario"]);
            }
            return p;

        }
        public void EditarProductoDal(Producto p)
        {
            string consulta = "update producto set nombreproducto='" + p.NombreProducto + "'," +                          
                                                  "preciounitario=" + p.PrecioUnitario + "" +
                                              "where idproducto=" + p.IdProducto;
            conexion.Ejecutar(consulta);
        }
        public void EliminarProductoDal(int id)
        {
            string consulta = "delete from producto where idproducto=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
