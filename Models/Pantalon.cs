using QuarkIngreso.Constants;

namespace QuarkIngreso.Models
{
    public class Pantalon : Ropa
    {
        private bool chupin;

        public Pantalon() { }
        public Pantalon(bool chupin, string calidad, float precioUnitario, int stock)
        {
            this.chupin = chupin;
            base.Calidad = calidad;
            base.PrecioUnitario = precioUnitario;
            base.Stock = stock;
        }

        /// <summary>se entiende que es chupin o comun</summary>
        public bool Chupin { get => chupin; set => chupin = value; }

        public override string ToString()
        {
            string pantalon = "Panton - ";
            pantalon += chupin ? "chupin - " : "comun - ";
            pantalon += Calidad + " - ";
            pantalon += PrecioUnitario.ToString() + " - ";
            pantalon += Stock.ToString() + " - ";
            return pantalon;
        }

        public override string[] ropaHeaders()
        {
            string[] pantalon = new string[3];
            pantalon[0] = "Pantalon";
            pantalon[1] = chupin ? "Chupin" : "Comun";
            pantalon[2] = Calidad;

            return pantalon;
        }

        public override void RopaCotizadaRefreshInRule()
        {
            PantalonRulesActives.maxCantidadPantalones -= Stock;
            if (Chupin)
            {
                PantalonRulesActives.MaxCantidadChupines -= Stock;
                if (Calidad == "premium")
                {
                    PantalonRulesActives.MaxCantidadChupinesPremium -= Stock;
                }
                else if(Calidad == "standar")
                {
                    PantalonRulesActives.MaxCantidadChupinesStandar -= Stock;
                }
            }
            else
            {
                PantalonRulesActives.MaxCantidadComunes -= Stock;
                if (Calidad == "premium")
                {
                    PantalonRulesActives.MaxCantidadComunesPremium -= Stock;
                }
                else if (Calidad == "standar")
                {
                    PantalonRulesActives.MaxCantidadComunesStandar -= Stock;
                }
            }
        }

        public override string IsCotizable()
        {
            if (PantalonRulesActives.maxCantidadPantalones - Stock < 0) return "Como maximo, puede llevarse " + PantalonRulesActives.maxCantidadPantalones + " pantalones";
            if (Chupin)
            {
                if (PantalonRulesActives.MaxCantidadChupines - Stock < 0) return "Como maximo, puede llevarse " + PantalonRulesActives.MaxCantidadChupines + " pantalones chupin";
                if (Calidad == "standar"
                    && PantalonRulesActives.MaxCantidadChupinesStandar - Stock < 0) return "Como maximo, puede llevarse " + PantalonRulesActives.MaxCantidadChupinesStandar + " pantalones chupin de calidad Standar";
                if (Calidad == "premium"
                    && PantalonRulesActives.MaxCantidadChupinesPremium - Stock < 0) return "Como maximo, puede llevarse " + PantalonRulesActives.MaxCantidadChupinesPremium + " pantalones chupin de calidad Premium";
            }
            else
            {
                if (PantalonRulesActives.MaxCantidadComunes - Stock < 0) return "Como maximo, puede llevarse " + PantalonRulesActives.MaxCantidadComunes + " pantalones comunes";
                if (Calidad == "standar"
                    && PantalonRulesActives.MaxCantidadComunesStandar - Stock < 0) return "Como maximo, puede llevarse " + PantalonRulesActives.MaxCantidadComunesStandar + " pantalones comunes de calidad Standar";
                if (Calidad == "premium"
                    && PantalonRulesActives.MaxCantidadComunesPremium - Stock < 0) return "Como maximo, puede llevarse " + PantalonRulesActives.MaxCantidadComunesPremium + " pantalones comunes de calidad Premium";
            }
            return Mensaje.seCotizo;
        }
    }
}
