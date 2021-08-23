using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkIngreso.Models
{
    class Cotizacion
    {
        private long id;
        private Tienda tienda;
        private DateTime fecha;
        private float total;
        private List<Ropa> ropas;

        public Cotizacion() { }

        public Cotizacion(long id, Tienda tienda, DateTime fecha, List<Ropa> ropas, float total)
        {
            this.id = id;
            this.tienda = tienda;
            this.fecha = fecha;
            this.ropas = ropas;
            this.total = total;
        }

        public long Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public List<Ropa> Ropas { get => ropas; set => ropas = value; }
        public Tienda Tienda { get => tienda; set => tienda = value; }
        public float Total { get => total; set => total = value; }
    }
}
