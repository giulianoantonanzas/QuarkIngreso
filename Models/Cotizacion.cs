using System;
using System.Collections.Generic;

namespace QuarkIngreso.Models
{
    public class Cotizacion
    {
        private long id;
        private Tienda tienda;
        private Ropa ropa;
        private DateTime fecha;
        private int prendasCotizadas;
        private float total;

        public Cotizacion() { }

        public Cotizacion(long id, DateTime fecha, Tienda tienda, Ropa ropa, int prendasCotizadas, float total)
        {
            this.id = id;
            this.tienda = tienda;
            this.ropa = ropa;
            this.fecha = fecha;
            this.total = total;
            this.prendasCotizadas = prendasCotizadas;
        }

        public long Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Tienda Tienda { get => tienda; set => tienda = value; }
        public Ropa Ropa { get => ropa; set => ropa = value; }
        public int PrendasCotizadas { get => prendasCotizadas; set => prendasCotizadas = value; }
        public float Total { get => total; set => total = value; }
       
    }
}
