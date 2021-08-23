using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkIngreso.Models
{
    public class Pantalon:Ropa
    {
        private bool chupin;

        public Pantalon() { }

        /// <summary>se entiende que es chupin o comun</summary>
        public bool Chupin { get => chupin; set => chupin = value; }
    }
}
