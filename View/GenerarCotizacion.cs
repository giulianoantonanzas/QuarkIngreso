using QuarkIngreso.Controller;
using QuarkIngreso.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuarkIngreso.View
{
    public partial class GenerarCotizacion : Form
    {
        CotizacionController cotizacionController;
        TiendaController tiendaController;
        List<Tienda> tiendas;
        public GenerarCotizacion()
        {
            cotizacionController = new CotizacionController();
            tiendaController = new TiendaController();
            tiendas = new List<Tienda>();
            InitializeComponent();
        }

        private void GenerarCotizacion_Load(object sender, EventArgs e)
        {
            tiendas = tiendaController.GetTiendas();
            foreach (Tienda tienda in tiendas)
                tiendasComboBox.Items.Add(tienda.Id+" "+ tienda.Nombre);
        }

        private void tiendasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tienda tiendaSeleccionada=tiendas[tiendasComboBox.SelectedIndex];
            direccionTiendaTXT.Text = tiendaSeleccionada.Direccion;
            vendedorTiendaTXT.Text = tiendaSeleccionada.Vendedor.Nombre
                +" "+tiendaSeleccionada.Vendedor.Apellido;
            nombreTiendaTXT.Text = tiendaSeleccionada.Nombre;
        }

    }
}
