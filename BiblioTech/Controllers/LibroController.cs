using System;
using System.Collections.Generic;
using BiblioTech.Models;

namespace BiblioTech.Controllers
{
    public class LibroController
    {

        private static List<Libro> _libros;

        // Constructor
        public LibroController()
        {
            _libros = new List<Libro>();
        }

        // Metodos

        // Obtiene todos los libros
        public List<Libro> ObtenerTodos()
        {
            return _libros;
        }

        // Obtiene libros por autor
        public List<Libro> ObtenerPorAutor(string autor)
        {
            List<Libro> resultado = new List<Libro>();

            foreach (Libro lib in _libros)
            {
                if (lib.Autor.ToLower == autor.ToLower)
                    resultado.Add(lib);
            }

            return resultado;
        }

        // Obtiene libros por categoria
        public List<Libro> ObtenerPorCategoria(string categoria)
        {
            List<Libro> resultado = new List<Libro>();
            foreach (Libro lib in _libros)
            {
                if (lib.Categoria.Nombre.ToLower == categoria.ToLower)
                    resultado.Add(lib);
            }
            return resultado;
        }

        // Obtiene un libro por su isbn
        public Libro ObtenerPorId(string isbn)
        {
            foreach (Libro lib in _libros)
            {
                if (lib.ISBN == isbn)
                    return lib;
            }
            return null;
        }

        public bool AgregarLibro(Libro libro)
        {
            if (ObtenerPorId(libro.ISBN) != null)
                return false; // No se puede agregar un libro con un ISBN duplicado

            _libros.Add(libro);
            return true;
        }

        public bool ActualizarLibro(string isbn, Libro libroActualizado)
        {
            foreach (Libro lib in _libros)
            {
                if (lib.ISBN == isbn)
                {
                    lib = libroActualizado;
                    return true;
                }
            }
            return false;
        }

        public bool EliminarLibro(string isbn)
        {
            foreach (Libro lib in _libros)
            {
                if (lib.ISBN == isbn)
                {
                    _libros.Remove(lib);
                    return true;
                }
            }
            return false;
        }
    }
}
