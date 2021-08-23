using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkIngreso.Models
{
    public class Tienda
    {
        private long id;
        private string nombre;
        private Vendedor vendedor;
        private string direccion;
        private List<Ropa> ropas;

        public Tienda()
        {
            ropas = new List<Ropa>();
            vendedor = new Vendedor();
        }

        public Tienda(long id, string nombre, Vendedor vendedor, string direccion, List<Ropa> ropas)
        {
            this.id = id;
            this.nombre = nombre;
            this.vendedor = vendedor;
            this.direccion = direccion;
            this.ropas = ropas;
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Ropa> Ropas { get => ropas; set => ropas = value; }
        public Vendedor Vendedor { get => vendedor; set => vendedor = value; }
        public long Id { get => id; set => id = value; }
    }
}
