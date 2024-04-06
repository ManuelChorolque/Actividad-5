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

namespace VentaTienda.VISTA.VentaVista
{
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaBss bss = new VentaBss();
            Venta v = new Venta();
            v.FechaVenta = dateTimePicker1.Value;
            v.TotalVenta = Convert.ToDecimal(textBox1.Text);

            bss.InsertarVentaBss(v);
            MessageBox.Show("se agrego correctamente");
        }
    }
}
