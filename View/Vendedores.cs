using System;
using System.Windows.Forms;

namespace QuarkIngreso.View
{
    public partial class Vendedores : Form
    {
        public Vendedores()
        {
            InitializeComponent();
        }

        private void nuevoVendedor_Click(object sender, EventArgs e)
        {
            new NuevoVendedor().Show();
        }
    }
}
