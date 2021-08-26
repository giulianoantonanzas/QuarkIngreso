using QuarkIngreso.Controller;
using QuarkIngreso.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarkIngreso.View
{
    public partial class NuevoVendedor : Form
    {
        VendedorController vendedorController;
        public NuevoVendedor()
        {
            vendedorController = new VendedorController();
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = int.Parse(idBox.Text);
                string nombre = nombreBox.Text;
                string apellido = apellidoBox.Text;
                vendedorController.SetTienda(new Vendedor(id, nombre, apellido));
                new Tiendas().Show();
                Close();
            }
            catch (Exception exepcion)
            {
                MessageBox.Show(exepcion.Message, "Error al registrar el vendedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
