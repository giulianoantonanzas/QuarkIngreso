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
            camisa[0]="Camisa";
            camisa[1]= (mangasCortas ? "Mangas Cortas" : "Mangas Largas")+" "+(cuelloMao ? "Cuello mao" : "Cuello Comun");
            camisa[2]= Calidad;
            return camisa;
        }
    }
}
