using QuarkIngreso.Constants;
using QuarkIngreso.Controller;
using QuarkIngreso.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuarkIngreso.View
{
    public partial class GenerarCotizacion : Form
    {
        private float precio;
        private CotizacionController cotizacionController;
        private TiendaController tiendaController;
        private List<Tienda> tiendas;
        private Tienda tiendaSeleccionada;
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
            tiendaSeleccionada=tiendas[tiendasComboBox.SelectedIndex];
            direccionTiendaTXT.Text = tiendaSeleccionada.Direccion;
            vendedorTiendaTXT.Text = tiendaSeleccionada.Vendedor.Nombre
                +" "+tiendaSeleccionada.Vendedor.Apellido;
            nombreTiendaTXT.Text = tiendaSeleccionada.Nombre;
        }

        private void cotizarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Ropa ropa;
                long id = long.Parse(idTextBox.Text);
                DateTime fecha = DateTime.Now;
                int stock = int.Parse(stockTextBox.Text);
                string calidad = standarRadioBTN.Checked ? "standar" : "premium";
                float precioUnitario=float.Parse(precioTextBox.Text);
                int cantidad = int.Parse(cantidadTextBox.Text);
                if (camisaRadioBTN.Checked)
                {
                    bool mangasCortas = mangasCortasCheckBox.Checked;
                    bool cuelloMao = cuelloMaoCheckBox.Checked;
                    ropa =new Camisa(mangasCortas, cuelloMao, calidad, precioUnitario, stock);
                }
                else
                {
                    bool chupin = chupinCheckBox.Checked;
                    ropa =new Pantalon(chupin, calidad, precioUnitario, stock);
                }
                if (precio != 0)
                {
                    string seCotizo=cotizacionController.Cotizar(
                       new Cotizacion(id, fecha, tiendaSeleccionada, ropa, cantidad, precio));
                    if (seCotizo==Mensaje.seCotizo)
                    {
                        MessageBox.Show("¡Se genero la cotizacion exitosamente!", "Cotizacion Generada",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        new Cotizaciones().Show();
                    }
                    else
                    {
                        MessageBox.Show(seCotizo, "Error al Cotizar",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Revisa el formulario. Ingrese valores validos.", "Error al registrar la cotizacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshCotizacionValue()
        {
            try
            {
                if (precioTextBox.Text !="" && cantidadTextBox.Text!="")
                {
                    string calidad = standarRadioBTN.Checked ? "standar" : "premium";
                    float precioUnitario = float.Parse(precioTextBox.Text);
                    int cantidad = int.Parse(cantidadTextBox.Text);
                    precio = precioUnitario * cantidad;
                    if(cantidad>0 && precioUnitario > 0)
                    {
                        if (camisaRadioBTN.Checked)
                        {
                            bool mangasCortas = mangasCortasCheckBox.Checked;
                            bool cuelloMao = cuelloMaoCheckBox.Checked;
                            if (mangasCortas) precio = precio - precio * 10 / 100;//descuento del 10% si es mangas cortas
                            if (cuelloMao) precio = precio + precio * 3 / 100;//aumento del 3% si es cuello mao
                        }
                        else
                        {
                            bool chupin = chupinCheckBox.Checked;
                            if (chupin) precio = precio - precio * 12 / 100;//aumento del 3% si es cuello mao
                        }
                        if (calidad.Equals("premium")) precio = precio + precio * 30 / 100;//si es calidad premi
                        cotizacionValueTXT.Text = precio.ToString();
                    }
                }
                
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error al ingresar valor",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void camisaRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCotizacionValue();
        }

        private void mangasCortasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCotizacionValue();
        }

        private void cuelloMaoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCotizacionValue();
        }

        private void pantalonRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCotizacionValue();
        }

        private void chupinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshCotizacionValue();
        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshCotizacionValue();
        }

        private void cantidadTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshCotizacionValue();
            stockTextBox.Text= cantidadTextBox.Text;
        }
    }
}
