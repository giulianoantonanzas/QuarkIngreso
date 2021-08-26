using QuarkIngreso.Constants;
using QuarkIngreso.Models;
using System.Collections.Generic;
using System.IO;

namespace QuarkIngreso.Controller
{
    public class VendedorController
    {
        protected string file= fileName.vendedor;
        private List<Vendedor> vendedores;
        protected string vendedoresTXT;
        public VendedorController() {
            vendedores = new List<Vendedor>();
        }
        public List<Vendedor> GetVendedores()
        {
            vendedoresTXT = File.ReadAllText(file);
            string[] vendedores = vendedoresTXT.Split('\n');
            for (int i = 1; i < vendedores.Length - 1; i++)
            {
                if (vendedores[i].Length > 1)
                {
                    string[] vendedoresValues = vendedores[i].Split('\t');
                    this.vendedores.Add(new Vendedor(int.Parse(vendedoresValues[0]), vendedoresValues[1], vendedoresValues[2]));
                }
            }
            return this.vendedores;
        }

        public void SetTienda(Vendedor vendedor)
        {
            using (StreamWriter myFile = File.AppendText(file))
            {
                myFile.WriteLine(vendedor.Id + "\t" + vendedor.Nombre + "\t" + vendedor.Apellido + "\t");
            }
        }
    }
}
