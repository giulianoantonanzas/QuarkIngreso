using QuarkIngreso.Constants;
using QuarkIngreso.Controller;
using QuarkIngreso.Models;
using System.Collections.Generic;


namespace QuarkIngreso.Helpers
{
    public static class RefreshRules
    {
        public static void Refresh()
        {
            CamisaRulesActives.Refresh();
            PantalonRulesActives.Refresh();
            CotizacionController cotizacionController= new CotizacionController();
            List<Cotizacion> cotizaciones=cotizacionController.GetCotizaciones();
            foreach(Cotizacion cotizacion in cotizaciones)
            {
                cotizacion.Ropa.RopaCotizadaRefreshInRule();
            }
        }
    }
}
