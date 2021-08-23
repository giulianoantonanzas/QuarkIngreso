using QuarkIngreso.Models;
using System;
using System.IO;
using System.Reflection;

namespace Database
{
    /// <summary>Inicializara la base de datos de Vendedor, Cotizaciones y Ropas</summary>
    public static class InitialiceDB
    {

        /// <summary>si ya estaba inicializado alguno de los archivos de la base de datos no genera nuevos archivos. En todo caso, los crea</summary>
        public static void checkInitializeOrInitialize()
        {
            try
            {
                File.ReadAllText("Vendedores.txt");
            }
            catch(Exception)
            {
                initialiceVendedor();
                initialiceCotizacion();
                initialiceTienda();
            }
        }
        public static void initialiceVendedor()
        {
            File.WriteAllText("Vendedores.txt", keyGenerate(typeof(Cotizacion).GetProperties()));
        }
        public static void initialiceCotizacion()
        {
            PropertyInfo[] keys = typeof(Cotizacion).GetProperties();
            File.WriteAllText("Cotizacion.txt", keyGenerate(typeof(Cotizacion).GetProperties()));
        }

        public static void initialiceTienda()
        {
            File.WriteAllText("Tiendas.txt", keyGenerate(typeof(Tienda).GetProperties()));
        }
        public static string keyGenerate(PropertyInfo[] keys)
        {
            string keysToString = "";
            foreach (var key in keys)
            {
                keysToString += key.Name + "\t";
            }
            keysToString += "\n";
            return keysToString;
        }
    }
}

