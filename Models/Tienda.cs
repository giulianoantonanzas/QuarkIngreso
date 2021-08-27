using System.Collections.Generic;

namespace QuarkIngreso.Models
{
    public class Tienda
    {
        private long id;
        private string nombre;
        private string direccion;
        private Vendedor vendedor;

        public Tienda()
        {
            vendedor = new Vendedor();
        }

        public Tienda(long id, string nombre, string direccion, Vendedor vendedor)
        {
            this.id = id;
            this.nombre = nombre;
            this.vendedor = vendedor;
            this.direccion = direccion;
        }

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public Vendedor Vendedor { get => vendedor; set => vendedor = value; }
    }
}
