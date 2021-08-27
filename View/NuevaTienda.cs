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
        List<Vendedor> vendedores;

        public NuevaTienda()
        {
            vendedorController = new VendedorController();
            tiendaController = new TiendaController();
            vendedores = new List<Vendedor>();
            vendedores = vendedorController.GetVendedores();
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(idBox.Text!="" && nombreBox.Text!="" && direccionBox.Text!="" && vendedoresComboBox.Text != "")
                {
                    int id = int.Parse(idBox.Text);
                    string nombre = nombreBox.Text;
                    string direccion = direccionBox.Text;
                    Vendedor vendedorSeleccionado = vendedores[vendedoresComboBox.SelectedIndex];
                    string idVendedor = vendedoresComboBox.Text.Split(' ')[0];
                    tiendaController.SetTienda(new Tienda(id, nombre, direccion, vendedorSeleccionado));
                    Close();
                    new Tiendas().Show();
                }
                else
                {
                    MessageBox.Show("Rellene los campos correctamente", "Error al registrar la tienda",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exepcion)
            {
                MessageBox.Show("Ingrese bien los datos y corrobore que el vendedor exista. Detalle: "+exepcion.Message, "Error al registrar la tienda",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void vendedoresComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void NuevaTienda_Load(object sender, EventArgs e)
        {
            foreach (Vendedor vendedor in vendedores)
                vendedoresComboBox.Items.Add(vendedor.Id + " " + vendedor.Nombre + " " + vendedor.Apellido);
        }
    }
}
