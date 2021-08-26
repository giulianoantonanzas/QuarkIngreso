using QuarkIngreso.Controller;
using QuarkIngreso.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuarkIngreso.View
{
    public partial class Cotizaciones : Form
    {
        private CotizacionController cotizacionController;
        private List<Cotizacion> cotizaciones;
        private DataGridViewRow row;
        public Cotizaciones()
        {
            cotizacionController = new CotizacionController();
            cotizaciones = new List<Cotizacion>();
            row = new DataGridViewRow();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GenerarCotizacion().Show();
        }

        private void Cotizaciones_Load(object sender, EventArgs e)
        {
            cotizaciones=cotizacionController.GetCotizaciones();
            if (cotizaciones.Count > 0)
            {
                row.CreateCells(this.tablaCotizacion);
                for (int i = 0; i < cotizaciones.Count; i++)
                {
                    string[] ropaDetails=cotizaciones[i].Ropa.ropaHeaders();
                    row.Cells[0].Value = cotizaciones[i].Tienda.Nombre;
                    row.Cells[1].Value = ropaDetails[0];//nombre
                    row.Cells[2].Value = ropaDetails[1];//detalle
                    row.Cells[3].Value = ropaDetails[2];//calidad
                    row.Cells[4].Value = cotizaciones[i].Ropa.Stock;
                    row.Cells[5].Value = cotizaciones[i].Ropa.PrecioUnitario;
                    row.Cells[6].Value = cotizaciones[i].Total.ToString();
                    tablaCotizacion.Rows.Insert(i, row);
                    row = new DataGridViewRow();
                    row.CreateCells(this.tablaCotizacion);
                }
            }
        }
    }
}
