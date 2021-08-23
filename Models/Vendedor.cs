namespace QuarkIngreso.Models
{
    public class Vendedor 
    {
        private long id;
        private string nombre;
        private string apellido;

        public Vendedor(){}

        public Vendedor(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public long Id { get => id; set => id = value; }
        public string Apellido { get => apellido; set => apellido = value; }

    }
}
