using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    internal class Favorito
    {
        // Comentario
        public int idFavorito { get; set; }
        public int idLibro { get; set; }
        public int idUsuario { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Anio { get; set; }
        public string genero { get; set; }



        public Favorito(int idFavorito, int idLibro, int idUsuario, string Titulo, string Autor, string Anio, string genero)
        {

            this.idFavorito = idFavorito;
            this.idLibro = idLibro;
            this.idUsuario = idUsuario;
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Anio = Anio;
            this.genero = genero;

        }
    }
}
