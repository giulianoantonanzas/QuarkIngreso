using QuarkIngreso.Constants;
using QuarkIngreso.Models;
using System.IO;
using System.Reflection;

namespace DB
{
    /// <summary>Inicializara la base de datos de Vendedor, Cotizaciones y Ropas</summary>
    public static class InitialiceDB
    {

        /// <summary>si ya estaba inicializado alguno de los archivos de la base de datos no genera nuevos archivos. En todo caso, los crea</summary>
        public static void checkInitializeOrInitialize()
        {
            if (!File.Exists(FileName.vendedor)|| !File.Exists(FileName.tienda) || !File.Exists(FileName.cotizacion))
            {
                initialiceVendedor();
                initialiceCotizacion();
                initialiceTienda();
            }
        }
        public static void initialiceVendedor()
        {
            File.WriteAllText(FileName.vendedor, keyGenerate(typeof(Vendedor).GetProperties()));
        }
        public static void initialiceCotizacion()
        {
            File.WriteAllText(FileName.cotizacion, keyGenerate(typeof(Cotizacion).GetProperties()));
        }

        public static void initialiceTienda()
        {
            File.WriteAllText(FileName.tienda, keyGenerate(typeof(Tienda).GetProperties()));
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

