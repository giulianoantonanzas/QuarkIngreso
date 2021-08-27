using QuarkIngreso.Controller;
using QuarkIngreso.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuarkIngreso.View
{
    public partial class Tiendas : Form
    {
        private TiendaController tiendaController;
        private DataGridViewRow row;
        private List<Tienda> tiendas;
        public Tiendas()
        {
            tiendaController = new TiendaController();
            row = new DataGridViewRow();
            tiendas = tiendaController.GetTiendas();
            InitializeComponent();
        }

        private void nuevaTienda_Click(object sender, EventArgs e)
        {
            new NuevaTienda().Show();
            Close();
        }

        private void Tiendas_Load(object sender, EventArgs e)
        {
            
            if (tiendas.Count > 0)
            {
                row.CreateCells(this.tablaTiendas);
                for (int i = 0; i < tiendas.Count; i++)
                {
                    row.Cells[0].Value = tiendas[i].Id;
                    row.Cells[1].Value = tiendas[i].Nombre;
                    row.Cells[2].Value = tiendas[i].Direccion;
                    row.Cells[3].Value = tiendas[i].Vendedor.Nombre + " " + tiendas[i].Vendedor.Apellido;
                    tablaTiendas.Rows.Insert(i,row);
                    row = new DataGridViewRow();
                    row.CreateCells(this.tablaTiendas);
                }
            }
        }
    }
}
