using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Libro
    {
        public int idLibro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }        
        public string idCategoria { get; set; }

        public bool Disponibilidad { get; set; } = true;

    }
}
