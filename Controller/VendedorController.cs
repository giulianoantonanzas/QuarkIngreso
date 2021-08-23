using QuarkIngreso.Models;
using System;
using System.Collections.Generic;

namespace QuarkIngreso.Controller
{
    public class VendedorController
    {
        public List<Vendedor> vendedores = new List<Vendedor>();
        public  List<Vendedor> getVendedores()
        {
            vendedores.Add(new Vendedor(id: 0, nombre: "giuliano", apellido: "antonanzas"));
            vendedores.Add(new Vendedor(id: 1, nombre: "gean", apellido: "binotto"));
            return vendedores;
        }
    }
}
