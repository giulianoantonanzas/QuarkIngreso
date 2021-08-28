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
            cotizaciones = cotizacionController.GetCotizaciones();
            row = new DataGridViewRow();
            InitializeComponent();
        }

        public Cotizaciones(List<Cotizacion> cotizaciones)
        {
            cotizacionController = new CotizacionController();
            this.cotizaciones = cotizaciones;
            row = new DataGridViewRow();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GenerarCotizacion().Show();
            Close();
        }

        private void Cotizaciones_Load(object sender, EventArgs e)
        {
            if (cotizaciones.Count > 0)
            {
                row.CreateCells(this.tablaCotizacion);
                for (int i = 0; i < cotizaciones.Count; i++)
                {
                    string[] ropaDetails=cotizaciones[i].Ropa.ropaHeaders();
                    row.Cells[0].Value = cotizaciones[i].Id;
                    row.Cells[1].Value = cotizaciones[i].Fecha.ToString().Split(' ')[0];
                    row.Cells[2].Value = cotizaciones[i].Tienda.Nombre;
                    row.Cells[3].Value = ropaDetails[0];//nombre
                    row.Cells[4].Value = ropaDetails[1];//detalle
                    row.Cells[5].Value = ropaDetails[2];//calidad
                    row.Cells[6].Value = cotizaciones[i].Ropa.Stock;
                    row.Cells[7].Value = cotizaciones[i].Ropa.PrecioUnitario;
                    row.Cells[8].Value = cotizaciones[i].PrendasCotizadas.ToString();
                    row.Cells[9].Value = cotizaciones[i].Total.ToString();
                    tablaCotizacion.Rows.Insert(i, row);
                    row = new DataGridViewRow();
                    row.CreateCells(this.tablaCotizacion);
                }
            }
        }
    }
}
