using QuarkIngreso.Controller;
using QuarkIngreso.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuarkIngreso.View
{
    public partial class Vendedores : Form
    {
        private VendedorController vendedorController;
        private List<Vendedor> vendedores;
        private DataGridViewRow row;
        public Vendedores()
        {
            vendedorController = new VendedorController();
            vendedores = vendedorController.GetVendedores();
            row = new DataGridViewRow();
            InitializeComponent();
        }

        private void nuevoVendedor_Click(object sender, EventArgs e)
        {
            new NuevoVendedor().Show();
            Close();
        }

        private void Vendedores_Load(object sender, EventArgs e)
        {
            if (vendedores.Count > 0)
            {
                row.CreateCells(this.tablaVendedores);
                for (int i = 0; i < vendedores.Count; i++)
                {
                    row.Cells[0].Value = vendedores[i].Id;
                    row.Cells[1].Value = vendedores[i].Nombre;
                    row.Cells[2].Value = vendedores[i].Apellido;
                    tablaVendedores.Rows.Insert(i, row);
                    row = new DataGridViewRow();
                    row.CreateCells(this.tablaVendedores);
                }
            }
        }
    }
}
