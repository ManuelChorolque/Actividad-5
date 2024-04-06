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
    public partial class ProductoInsertarVista : Form
    {
        public ProductoInsertarVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            Producto p = new Producto();
            p.NombreProducto = textBox1.Text;
            p.PrecioUnitario = Convert.ToDecimal(textBox2.Text);

            bss.InsertarProductoBss(p);
            MessageBox.Show("se agrego correctamente");
        }
    }
}
