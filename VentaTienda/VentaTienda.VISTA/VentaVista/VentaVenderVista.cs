using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using VentaTienda.BSS;
using VentaTienda.Modelos;
using VentaTienda.VISTA.ProductoVsita;
using System.Reflection.Emit;

namespace VentaTienda.VISTA.VentaVista
{
    public partial class VentaVenderVista : Form
    {
        private int n = 0;
        public VentaVenderVista()
        {
            InitializeComponent();
        }
        public static int IdProductoSeleccionado = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            ProductoListarVista fr = new ProductoListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bss.ObtenerIdBss(IdProductoSeleccionado);
                textBox1.Text = producto.NombreProducto;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DetalleVentaBss bss1 = new DetalleVentaBss();
            DetalleVenta d = bss1.ObtenerIdBss(IdProductoSeleccionado);

            int cantidad = Convert.ToInt32(domainUpDown1.Text);

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = d.IdVenta;
            dataGridView1.Rows[n].Cells[1].Value = d.IdProducto;
            dataGridView1.Rows[n].Cells[2].Value = cantidad;
            dataGridView1.Rows[n].Cells[3].Value = d.PrecioUnitario;
            dataGridView1.Rows[n].Cells[4].Value = d.PrecioUnitario * cantidad; //subtotal

            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[4].Value);
                }
            }
            label2.Text = total.ToString(); //suma de todos los subtotales(total)

            textBox1.Text = "";
            domainUpDown1.Text = "";
        }



        private void button2_Click(object sender, EventArgs e)
        {

            VentaBss bss2 = new VentaBss();
            Venta v = new Venta();
            DetalleVentaBss bss1 = new DetalleVentaBss();

            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DetalleVenta d = new DetalleVenta();

                    d.IdVenta = Convert.ToInt32(row.Cells[0].Value);
                    d.IdProducto = IdProductoSeleccionado;
                    d.Cantidad = Convert.ToInt32(row.Cells[2].Value);
                    d.PrecioUnitario = Convert.ToDecimal(row.Cells[3].Value);
                    d.TotalDetalle = Convert.ToDecimal(row.Cells[4].Value);

                    bss1.InsertarDetalleVentaBss(d);
                }

                v.TotalVenta = Convert.ToDecimal(label2.Text);
                bss2.InsertarVentaBss(v);

                MessageBox.Show("Venta guardada correctamente.");
            }
            else
            {
                MessageBox.Show("Agregue al menos un producto a la venta.");
            }
        }
    }
}
