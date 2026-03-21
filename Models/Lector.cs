namespace BiblioTech.Models
{
    public class Lector
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public Lector() { Nombre = ""; } 
        public Lector(string nombre) { Nombre = nombre; }
    }
}
