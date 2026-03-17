using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    internal class Favorito
    {
         
        public int idFavorito { get; set; }
        public int ISBN { get; set; }
        public string AliasUsuario { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Anio { get; set; }
        public string genero { get; set; }



        public Favorito(int idFavorito, int ISBN, string AliasUsuario, string Titulo, string Autor, string Anio, string genero)
        {

            this.idFavorito = idFavorito;
            this.ISBN = ISBN;
            this.AliasUsuario = AliasUsuario;
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Anio = Anio;
            this.genero = genero;

        }
    }
}
