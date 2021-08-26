using QuarkIngreso.Models;
using System.Collections.Generic;
using QuarkIngreso.Constants;
using System.IO;

namespace QuarkIngreso.Controller
{
    public class TiendaController
    {
        private List<Tienda> tiendas;
        protected string file = fileName.tienda;
        protected string tiendasTXT;

        public TiendaController() {
            tiendas = new List<Tienda>();
        }

        public List<Tienda> GetTiendas()
        {
            tiendasTXT =  File.ReadAllText(file);
            string[] tiendas=tiendasTXT.Split('\n');
            for(int i=1; i<tiendas.Length-1; i++)
            {
                string[] tiendaValues = tiendas[i].Split('\t');
                if (tiendaValues.Length > 1)
                {
                    Vendedor vendedor = FindVendedorById(tiendaValues[3]);
                    if (vendedor != null)
                    {
                        this.tiendas.Add(new Tienda(long.Parse(tiendaValues[0]), tiendaValues[1], tiendaValues[2], vendedor));
                    }
                }
            }
            return this.tiendas;
        }

        public void SetTienda(Tienda tienda)
        {
            using (StreamWriter myFile = File.AppendText(file))
            {
                myFile.WriteLine(tienda.Id + "\t" + tienda.Nombre + "\t" + tienda.Direccion + "\t" + tienda.Vendedor.Id + "\t");
            }
        }

        public Vendedor FindVendedorById(string id)
        {
            string vendedorTXT = File.ReadAllText(fileName.vendedor);
            string[] vendedores = vendedorTXT.Split('\n');
            for (int i = 1; i < vendedores.Length - 1; i++)
            {
                if(vendedores[i].Split('\t')[0] == id)
                {
                    string[] vendedorValues = vendedores[i].Split('\t');
                    return new Vendedor(int.Parse(vendedorValues[0]), vendedorValues[1], vendedorValues[2]);
                }
            }
            return null;
        }
    }
}
