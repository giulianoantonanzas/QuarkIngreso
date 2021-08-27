using QuarkIngreso.View;
using System;
using System.Windows.Forms;

namespace QuarkIngreso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Tiendas().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Vendedores().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Cotizaciones().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
