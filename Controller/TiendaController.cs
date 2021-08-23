using QuarkIngreso.Models;
using System;
using System.Collections.Generic;

namespace QuarkIngreso.Controller
{
    public class TiendaController
    {
        List<Tienda> tiendas = new List<Tienda>();
        public List<Tienda> getTiendas()
        {
            return tiendas;
        }
    }
}
