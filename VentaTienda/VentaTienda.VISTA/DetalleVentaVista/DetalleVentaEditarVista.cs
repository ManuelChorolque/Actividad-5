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
    public partial class DetalleVentaEditarVista : Form
    {
        int idx = 0;
        DetalleVenta d = new DetalleVenta();
        DetalleVentaBss bss = new DetalleVentaBss();
        public DetalleVentaEditarVista(int id)
        {
            idx = id;
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

        private void DetalleVentaEditarVista_Load(object sender, EventArgs e)
        {
            d = bss.ObtenerIdBss(idx);
            textBox1.Text = d.IdVenta.ToString();
            textBox2.Text = d.IdProducto.ToString();
            textBox3.Text = d.Cantidad.ToString();
            textBox4.Text = d.PrecioUnitario.ToString();
            textBox5.Text = d.TotalDetalle.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            d.IdVenta = IdVentaSeleccionado;
            d.IdProducto = IdProductoSeleccionado;
            d.Cantidad = Convert.ToInt32(textBox3.Text);
            d.PrecioUnitario = Convert.ToDecimal(textBox4.Text);
            d.TotalDetalle = Convert.ToDecimal(textBox5.Text);

            bss.EditarDetalleVentaBss(d);
            MessageBox.Show("Datos actualizados");
        }

       
    }
}
