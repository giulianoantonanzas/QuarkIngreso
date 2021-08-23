namespace QuarkIngreso.Models
{
    public class Camisas:Ropa
    {
        private bool mangasCortas;
        private bool cuelloMao;

        public Camisas() { }

        /// <summary>se entiende que si no es mangasCortas ,es mangas largas</summary>
        public bool MangasCortas { get => mangasCortas; set => mangasCortas = value; }
        /// <summary>se entiende que es tiene el cuello estilo mao o comun</summary>
        public bool CuelloMao { get => cuelloMao; set => cuelloMao = value; }
    }
}
