namespace BiblioTech.Models
{
    public class Administrador
    {
        public string Nombre { get; set; }
        public Administrador() { Nombre = "Admin"; }
        public Administrador(string nombre) { Nombre = nombre; }
    }
}
 