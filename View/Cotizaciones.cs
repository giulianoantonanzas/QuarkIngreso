using System;
using System.Windows.Forms;

namespace QuarkIngreso.View
{
    public partial class Cotizaciones : Form
    {
        public Cotizaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GenerarCotizacion().Show();
        }

        private void Cotizaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
