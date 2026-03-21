using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{//7
    internal class Genero
    {
        public int idGenero { get; set; } 
        public string genero { get; set; }

        public Genero(int idGenero, string genero)
        {
            this.idGenero = idGenero;
            this.genero = genero;
        }
    }
}
