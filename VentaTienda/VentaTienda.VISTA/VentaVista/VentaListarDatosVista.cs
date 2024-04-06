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
using VentaTienda.VISTA.DetalleVentaVista;

namespace VentaTienda.VISTA.VentaVista
{
    public partial class VentaListarDatosVista : Form
    {
        public VentaListarDatosVista()
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
                textBox1.Text = venta.IdVenta.ToString();
            }
        }
        public static int IdDetalleVentaSeleccionado = 0;
        private void button4_Click(object sender, EventArgs e)
        {

            DetalleVentaBss bss = new DetalleVentaBss();
            DetalleVentaListarVista fr = new DetalleVentaListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                DetalleVenta venta = bss.ObtenerIdBss(IdDetalleVentaSeleccionado);
                textBox2.Text = venta.IdDetalleVenta.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            VentaBss bss = new VentaBss();
            dataGridView1.DataSource = bss.VentaDatosVentasBss(IdVentaSeleccionado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentaBss bss = new VentaBss();
            dataGridView2.DataSource = bss.VentaDatosDetalleBss(IdVentaSeleccionado);
        }
    }
}
