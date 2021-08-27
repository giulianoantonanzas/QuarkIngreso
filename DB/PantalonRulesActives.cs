namespace QuarkIngreso.Constants
{
    public static class PantalonRulesActives
    {
        //pantalones
        public static int maxCantidadPantalones= 2000;

        //chupines
        public static int MaxCantidadChupines = 1500;
        public static int MaxCantidadChupinesStandar= 750;
        public static int MaxCantidadChupinesPremium = 750;

        //comunes
        public static int MaxCantidadComunes = 500;
        public static int MaxCantidadComunesStandar = 250;
        public static int MaxCantidadComunesPremium = 250;

        public static void Refresh()
        {
            maxCantidadPantalones = 2000;
            MaxCantidadChupines = 1500;
            MaxCantidadChupinesStandar = 750;
            MaxCantidadChupinesPremium = 750;
            MaxCantidadComunes = 500;
            MaxCantidadComunesStandar = 250;
            MaxCantidadComunesPremium = 250;
        }
    }
} 
