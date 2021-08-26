using QuarkIngreso.Constants;
using QuarkIngreso.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuarkIngreso.Controller
{
    class CotizacionController
    {
        private List<Cotizacion> cotizaciones;
        protected string file = fileName.cotizacion;
        protected string cotizacionesTXT;

        public CotizacionController() {
            cotizaciones = new List<Cotizacion>();
        }

        public List<Cotizacion> GetCotizaciones()
        {
            cotizacionesTXT = File.ReadAllText(file);
            string[] cotizaciones = cotizacionesTXT.Split('\n');
            for (int i = 1; i < cotizaciones.Length - 1; i++)
            {
                if (cotizaciones[i].Length > 1)
                {
                    string[] cotizacionesValues = cotizaciones[i].Split('\t');
                    Tienda tienda=FindTiendaById(cotizacionesValues[2]);
                    Ropa ropa = StringToRopa(cotizacionesValues[3]);
                    this.cotizaciones.Add(new Cotizacion(long.Parse(cotizacionesValues[0]),
                       DateTime.Parse(cotizacionesValues[1]),
                       tienda,
                       ropa,
                       float.Parse(cotizacionesValues[4])));
                }
            }
            return this.cotizaciones;
        }

        public void SetCotizacion(Cotizacion cotizacion)
        {
            using (StreamWriter myFile = File.AppendText(file))
            {
                myFile.WriteLine(cotizacion.Id + "\t" +
                    cotizacion.Tienda.Id+ "\t" +
                    cotizacion.Fecha.ToString("dd/MM/yyyy") + "\t"+
                    cotizacion.Ropa.ToString() + "\t" +
                    cotizacion.Total + "\t");
            }
        }

        public Tienda FindTiendaById(string id)
        {
            string tiendaTXT = File.ReadAllText(fileName.tienda);
            string[] tiendas = tiendaTXT.Split('\n');
            for (int i = 1; i < tiendas.Length - 1; i++)
            {
                if (tiendas[i].Split('\t')[0] == id)
                {
                    string[] tiendaValues = tiendas[i].Split('\t');
                    Vendedor vendedor=new TiendaController().FindVendedorById(tiendaValues[3]);
                    if (vendedor!= null)
                    {
                        return new Tienda(int.Parse(tiendaValues[0]), tiendaValues[1], tiendaValues[2], vendedor);
                    }
                }
            }
            return null;
        }

        public Ropa StringToRopa(string ropa)
        {
            string calida;
            float precioUnitario;
            int stock;

            string[] separatingStrings = {" - "};
            string[] ropaDetails = ropa.Split(separatingStrings, StringSplitOptions.None);
            ;
            if (ropaDetails[0] == "Camisa")
            {
                calida = ropaDetails[3];
                precioUnitario = float.Parse(ropaDetails[4]);
                stock = int.Parse(ropaDetails[5]);
                bool mangasLargas = ropaDetails[1] == "mangas largas";
                bool cuelloMao = ropaDetails[2] == "cuello mao";                
                return new Camisa(mangasLargas,cuelloMao,calida,precioUnitario,stock);
            }
            else
            {
                calida = ropaDetails[2];
                precioUnitario = float.Parse(ropaDetails[3]);
                stock = int.Parse(ropaDetails[4]);
                bool chupin = ropaDetails[1] == "chupin";
                return new Pantalon(chupin, calida, precioUnitario, stock);
            }
        }
    }
}
