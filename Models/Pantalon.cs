namespace QuarkIngreso.Models
{
    public class Pantalon:Ropa
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
            string camisa = "Panton - ";
            camisa += chupin ? "chupin - " : "comun - ";
            camisa += Calidad + " - ";
            camisa += PrecioUnitario.ToString() + " - ";
            camisa += Stock.ToString() + " - ";
            return camisa;
        }

        public override string[] ropaHeaders()
        {
            string[] pantalon = new string[3];
            pantalon[0] = "Panton";
            pantalon[1] = chupin ? "Chupin" : "Comun";
            pantalon[2] = Calidad;

            return pantalon;
        }
    }
}
