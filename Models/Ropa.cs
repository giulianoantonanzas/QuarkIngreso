using System;

namespace QuarkIngreso.Models
{
    public abstract class Ropa
    {
        private string calidad;
        private float precioUnitario;
        private int stock;
        public Ropa() { }

        public string Calidad { get => calidad; set => calidad = value; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int Stock { get => stock; set => stock = value; }

        public abstract override string ToString();

        public abstract string[] ropaHeaders();

    }
}
