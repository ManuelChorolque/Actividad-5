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

namespace VentaTienda.VISTA.ProductoVsita
{
    public partial class ProductoEditarVista : Form
    {
        int idx = 0;
        Producto p = new Producto();
        ProductoBss bss = new ProductoBss();
        public ProductoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProductoEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx); ;
            textBox1.Text = p.NombreProducto;
            textBox2.Text = p.PrecioUnitario.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.NombreProducto = textBox1.Text;
            p.PrecioUnitario = Convert.ToDecimal(textBox2.Text);

            bss.EditarProductoBss(p);
            MessageBox.Show("Datos actualizados");
        }
    }
}
