using System;
using System.Collections.Generic;
using BiblioTech.Models;

namespace BiblioTech.Controllers 
{
    public class LibroController
    {
        // Instancia del SistemaLibreria para el manejo de datos
        private SistemaLibreria _sistema;

        // Constructor
        public LibroController(SistemaLibreria sistema)
        {
            _sistema = sistema;
        }

        // Devuelve todos los libros (Inventario)
        public List<Libro> Inventario()
        {
            return _sistema.Libros;
        }

        // Agregar un nuevo libro
        public bool AgregarLibro(Libro libro)
        {

            // Verificar ISBN duplicado
            if (ExisteISBN(libro.ISBN))
                return false;

            _sistema.Libros.Add(libro);
            return true;
        }

        //  Editar un libro 
        public bool EditarLibro(Libro libro)
        {
            // Verificar ISBN ya existe en otro libro
            if (ExisteISBN(libro.ISBN))
                return false;

            foreach (Libro lib in Inventario())
            {
                if (lib.ISBN == libro.ISBN)
                {
                    lib.Titulo = libro.Titulo;
                    lib.Autor = libro.Autor;
                    lib.Categoria = libro.Categoria;
                    lib.Editorial = libro.Editorial;
                    lib.Precio = libro.Precio;
                    lib.NumeroPaginas = libro.NumeroPaginas;
                    lib.FechaPublicacion = libro.FechaPublicacion;
                    return true;
                }
            }
            return false;
        }


        // Elimina un libro por su SBND
        public bool EliminarLibro(string isbn)
        {
            if (ExisteISBN(isbn))
            {
                Libro libroAEliminar = ObtenerPorISBN(isbn);
                _sistema.Libros.Remove(libroAEliminar);
                return true;
            }
            return false;
        }

        // Metodos de busqueda 

        // Obtener un libro por el ISBN
        public Libro ObtenerPorISBN(string isbn)
        {
            foreach (Libro lib in Inventario())
            {
                if (lib.ISBN == isbn)
                    return lib;
            }
            return null;
        }

        // Valida si el libro eciste
        private bool ExisteISBN(string isbn)
        {
            foreach (Libro lib in Inventario())
            {
                if (lib.ISBN == isbn)
                    return true;
            }
            return false;
        }

        // Obtiene los libros por autor, categoría o editorial
        public List<Libro> Buscar(string termino)
        {
            List<Libro> resultado = new List<Libro>();

            termino = termino.Trim().ToLower();

            foreach (Libro lib in Inventario())
            {
                // Por Autor
                if (lib.Autor.Codigo.ToLower() == termino)
                    resultado.Add(lib);

                // Por Categoría
                if (lib.Categoria.Codigo.ToString() == termino)
                    resultado.Add(lib);

                // Por Editorial
                if (lib.Editorial.Codigo.ToString() == termino)
                    resultado.Add(lib);
            }

            return resultado;
        }
    }
}
