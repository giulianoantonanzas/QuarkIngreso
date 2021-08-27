using QuarkIngreso.Constants;

namespace QuarkIngreso.Models
{
    public class Camisa:Ropa
    {
        private bool mangasCortas;
        private bool cuelloMao;

        public Camisa() { }
        public Camisa(bool mangasCortas, bool cuelloMao, string calidad, float precioUnitario, int stock)
        {
            this.mangasCortas = mangasCortas;
            this.cuelloMao = cuelloMao;
            Calidad = calidad;
            PrecioUnitario = precioUnitario;
            Stock = stock;
        }

        /// <summary>se entiende que si no es mangasCortas ,es mangas largas</summary>
        public bool MangasCortas { get => mangasCortas; set => mangasCortas = value; }
        /// <summary>se entiende que es tiene el cuello estilo mao o comun</summary>
        public bool CuelloMao { get => cuelloMao; set => cuelloMao = value; }

        public override string ToString()
        {
            string camisa= "Camisa - ";
            camisa += mangasCortas? "mangas cortas - " : "mangas largas - ";
            camisa += cuelloMao ? "cuello mao - " : "cuello comun - ";
            camisa += Calidad+" - ";
            camisa += PrecioUnitario.ToString() + " - ";
            camisa += Stock.ToString() + " - ";
            return camisa;
        }

        public override string[] ropaHeaders()
        {
            string[] camisa = new string[3];
            camisa[0] = "Camisa";
            camisa[1] = (mangasCortas ? "Mangas Cortas" : "Mangas Largas") + " " + (cuelloMao ? "Cuello mao" : "Cuello Comun");
            camisa[2] = Calidad;
            return camisa;
        }

        public override void RopaCotizadaRefreshInRule()
        {
            CamisaRulesActives.maxCantidadCamizas -= Stock;
            if (MangasCortas)
            {
                CamisaRulesActives.maxMangasCortas -= Stock;
                if (CuelloMao)
                {
                    CamisaRulesActives.maxMangasCortasCuelloMao -= Stock;
                    if (Calidad == "standar")
                    {
                        CamisaRulesActives.maxMangasCortasCuelloMaoStandar -= Stock;
                    }
                    else if (Calidad == "premium")
                    {
                        CamisaRulesActives.maxMangasCortasCuelloMaoPremium -= Stock;
                    }
                }
            }
            else
            {
                CamisaRulesActives.maxMangasLargas -= Stock;
                if (CuelloMao)
                {
                    CamisaRulesActives.maxMangasLargasCuelloMao -= Stock;
                    if (Calidad == "standar")
                    {
                        CamisaRulesActives.maxMangasLargasCuelloMaoStandar -= Stock;
                    }
                    else if (Calidad == "premium")
                    {
                        CamisaRulesActives.maxMangasLargasCuelloMaoPremium -= Stock;
                    }
                }
            }
        }

        public override string IsCotizable()
        {
            if (CamisaRulesActives.maxCantidadCamizas - Stock < 0) return "Como maximo, puede llevarse "+ CamisaRulesActives.maxCantidadCamizas+ " camisas";
            if (MangasCortas)
            {
                if (CamisaRulesActives.maxMangasCortas - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasCortas + " camisas de mangas cortas"; 
                if (CuelloMao)
                {
                    if (CamisaRulesActives.maxMangasCortasCuelloMao - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasCortasCuelloMao + " camisas de mangas cortas con cuello mao"; 
                    if (Calidad == "standar"
                        && CamisaRulesActives.maxMangasCortasCuelloMaoStandar - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasCortasCuelloMaoStandar + " camisas de mangas cortas con cuello mao y de calidad Standar"; 
                    if (Calidad == "premium"
                        && CamisaRulesActives.maxMangasCortasCuelloMaoPremium - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasCortasCuelloMaoPremium + " camisas de mangas cortas con cuello mao y de calidad Premium"; 
                }
                else
                {
                    if (CamisaRulesActives.maxMangasCortasCuelloComun - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasCortasCuelloComun + " camisas de mangas cortas con cuello comun";
                    if (Calidad == "standar"
                      && CamisaRulesActives.maxMangasCortasCuelloComunStandar - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasCortasCuelloComunStandar + " camisas de mangas cortas con cuello comun y de calidad Standar";
                    if (Calidad == "premium"
                        && CamisaRulesActives.maxMangasCortasCuelloComunPremium - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasCortasCuelloComunPremium + " camisas de mangas cortas con cuello comun y de calidad Premium";
                }
            }
            else
            {
                if (CamisaRulesActives.maxMangasLargas - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasLargas + " camisas de mangas largas";
                if (CuelloMao)
                {
                    if (CamisaRulesActives.maxMangasLargasCuelloMao - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasLargasCuelloMao + " camisas de mangas largas con cuello mao";
                    if (Calidad == "standar"
                        && CamisaRulesActives.maxMangasLargasCuelloMaoStandar - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasLargasCuelloMaoStandar + " camisas de mangas largas con cuello mao y calidad Standar";
                    if (Calidad == "premium"
                        && CamisaRulesActives.maxMangasLargasCuelloMaoPremium - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasLargasCuelloMaoPremium + " camisas de mangas largas con cuello mao y calidad Premium";
                }
                else
                {
                    if (CamisaRulesActives.maxMangasLargasCuelloComun - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasLargasCuelloComun + " camisas de mangas largas con cuello comun";
                    if (Calidad == "standar"
                      && CamisaRulesActives.maxMangasLargasCuelloComunStandar - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasLargasCuelloComunStandar + " camisas de mangas largas con cuello comun y calidad Standar";
                    if (Calidad == "premium"
                        && CamisaRulesActives.maxMangasLargasCuelloComunPremium - Stock < 0) return "Como maximo, puede llevarse " + CamisaRulesActives.maxMangasLargasCuelloComunPremium + " camisas de mangas largas con cuello comun y calidad Standar";
                }
            }
            return Mensaje.seCotizo;
        }
    }
}
