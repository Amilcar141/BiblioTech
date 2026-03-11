using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Models;

namespace BiblioTech.Controllers
{
  public class LibroController
    {
        public static List<Libro> Inventario = new List<Libro>();

        public void AgregarLibro(Libro nuevo) { Inventario.Add(nuevo); }

        public List<Libro> BuscarLibro(string texto)
        {
            return Inventario.Where(l => l.Titulo.Contains(texto) || l.Autor.Contains(texto)).ToList();
        }

        public void EliminarLibro(int id) { Inventario.RemoveAll(l => l.idLibro == id); }
    }
}
