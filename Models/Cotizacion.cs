using System;
using System.Collections.Generic;

namespace QuarkIngreso.Models
{
    class Cotizacion
    {
        private long id;
        private Tienda tienda;
        private Ropa ropa;
        private DateTime fecha;
        private float total;

        public Cotizacion() { }

        public Cotizacion(long id, Tienda tienda,Ropa ropa, DateTime fecha, float total)
        {
            this.id = id;
            this.tienda = tienda;
            this.ropa = ropa;
            this.fecha = fecha;
            this.total = total;
        }

        public long Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Tienda Tienda { get => tienda; set => tienda = value; }
        public Ropa Ropa { get => ropa; set => ropa = value; }
        public float Total { get => total; set => total = value; }
    }
}
