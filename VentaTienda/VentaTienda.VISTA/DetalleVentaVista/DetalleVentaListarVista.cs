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
using VentaTienda.VISTA.VentaVista;

namespace VentaTienda.VISTA.DetalleVentaVista
{
    public partial class DetalleVentaListarVista : Form
    {
        public DetalleVentaListarVista()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void DetalleVentaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.DetalleVentaDatosBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleVentaInsertarVista fr = new DetalleVentaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.DetalleVentaDatosBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdDetalleVentaSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaEditarVista fr = new DetalleVentaEditarVista(IdDetalleVentaSelecionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.DetalleVentaDatosBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdDetalleVentaSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar este detalle venta", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleVentaBss(IdDetalleVentaSelecionado);
                dataGridView1.DataSource = bss.DetalleVentaDatosBss();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            VentaListarDatosVista.IdDetalleVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
