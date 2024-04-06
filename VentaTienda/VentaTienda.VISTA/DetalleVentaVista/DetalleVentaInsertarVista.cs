using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaTienda.BSS;
using VentaTienda.Modelos;
using VentaTienda.VISTA.ProductoVsita;
using VentaTienda.VISTA.VentaVista;

namespace VentaTienda.VISTA.DetalleVentaVista
{
    public partial class DetalleVentaInsertarVista : Form
    {
        public DetalleVentaInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdVentaSeleccionado = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            VentaBss bss = new VentaBss();
            VentaListarVista fr = new VentaListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bss.ObtenerIdBss(IdVentaSeleccionado);
                textBox1.Text = venta.FechaVenta.ToString();
            }
        }
        public static int IdProductoSeleccionado = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            ProductoListarVista fr = new ProductoListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bss.ObtenerIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.NombreProducto;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetalleVentaBss bss = new DetalleVentaBss();
            DetalleVenta dv = new DetalleVenta();
            dv.IdVenta = IdVentaSeleccionado;
            dv.IdProducto = IdProductoSeleccionado;
            dv.Cantidad = Convert.ToInt32(textBox3.Text);
            dv.PrecioUnitario = Convert.ToDecimal(textBox4.Text);
            dv.TotalDetalle = Convert.ToDecimal(textBox5.Text);

            bss.InsertarDetalleVentaBss(dv);
            MessageBox.Show("se guardo correctamente DetalleVentas");
        }
    }
}
