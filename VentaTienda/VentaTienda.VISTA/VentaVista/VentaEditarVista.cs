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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VentaTienda.VISTA.VentaVista
{
    public partial class VentaEditarVista : Form
    {
        int idx = 0;
        Venta v = new Venta();
        VentaBss bss = new VentaBss();
        public VentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void VentaEditarVista_Load(object sender, EventArgs e)
        {
            v = bss.ObtenerIdBss(idx); ;
            dateTimePicker1.Value = v.FechaVenta;
            textBox1.Text = v.TotalVenta.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v.FechaVenta = dateTimePicker1.Value;
            v.TotalVenta = Convert.ToDecimal(textBox1.Text);

            bss.EditarVentaBss(v);
            MessageBox.Show("Datos actualizados");
        }
    }
}
