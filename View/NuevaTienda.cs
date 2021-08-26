using QuarkIngreso.Controller;
using QuarkIngreso.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuarkIngreso.View
{
    public partial class NuevaTienda : Form
    {
        VendedorController vendedorController;
        TiendaController tiendaController;

        public NuevaTienda()
        {
            vendedorController = new VendedorController();
            tiendaController = new TiendaController();
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idBox.Text);
                string nombre = nombreBox.Text;
                string direccion = direccionBox.Text;
                string idVendedor = vendedoresComboBox.Text.Split(' ')[0];
                tiendaController.SetTienda(
                    new Tienda(id, nombre, direccion,
                    tiendaController.FindVendedorById(idVendedor)));
                this.Close();
            }
            catch (Exception exepcion)
            {
                MessageBox.Show(exepcion.Message, "Error al registrar la tienda",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void vendedoresComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void NuevaTienda_Load(object sender, EventArgs e)
        {
            List<Vendedor> vendedores = vendedorController.GetVendedores();

            foreach (Vendedor vendedor in vendedores)
                vendedoresComboBox.Items.Add(vendedor.Id + " " + vendedor.Nombre + " " + vendedor.Apellido);
        }
    }
}
