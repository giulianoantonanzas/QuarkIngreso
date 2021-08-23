using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkIngreso.Models
{
    public abstract class Ropa
    {
        private long id;
        private string calidad;
        private float precioUnitario;
        private int stock;

        public string Calidad { get => calidad; set => calidad = value; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int Stock { get => stock; set => stock = value; }
        public long Id { get => id; set => id = value; }
    }
}
