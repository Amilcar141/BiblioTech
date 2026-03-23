using System;
using System.Collections.Generic;
using BiblioTech.Models;

namespace BiblioTech.Controllers 
{
    public class LibroController
    { //3
        
        private static List<Libro> _libros = new List<Libro>();
        private static int _nextId = 1;

        // Constructor
        public LibroController()
        {
        }

        
        public List<Libro> ObtenerTodos()
        {
            return new List<Libro>(_libros);
        }

        // Devuelve todos los libros (Inventario)
        
        public static List<Libro> Inventario
        {
            get { return _libros; }
        }



        public Libro ObtenerPorId(int id)
        {
            foreach (Libro lib in _libros)
            {
                if (lib.GetIdLibro() == id)
                    return lib;
            }
            return null;
        }

        public List<Libro> Buscar(string termino, string filtro)
        {
            List<Libro> resultado = new List<Libro>();
            termino = termino.Trim().ToLower();

            foreach (Libro lib in _libros)
            {
                // Filtrar por termino de busqueda
                bool coincideBusqueda = string.IsNullOrEmpty(termino) ||
                    lib.GetNombreLibro().ToLower().Contains(termino) ||
                    lib.GetISBN().ToLower().Contains(termino) ||
                    lib.GetAutor().ToLower().Contains(termino);

                if (!coincideBusqueda)
                    continue;

                // Filtrar por disponibilidad
                if (filtro == "Disponibles" && !lib.GetDisponible())
                    continue;

                if (filtro == "Prestados" && lib.GetDisponible())
                    continue;

                resultado.Add(lib);
            }

            // Ordenar por nombre
            resultado.Sort((a, b) => string.Compare(a.GetNombreLibro(), b.GetNombreLibro()));
            return resultado;
        }

        
        public bool Guardar(
            string isbn,
            string nombreLibro,
            string autor,
            int    idCategoria,
            string nombreCategoria,
            string fechaPublicacion,
            string numeroPaginasTexto,
            string editorial,
            string aliasUsuario,
            out string mensaje)
        {
            mensaje = "";

            // Validaciones
            if (string.IsNullOrWhiteSpace(isbn))
            {
                mensaje = "El ISBN no puede estar vacío.";
                return false;
            }

            if (isbn.Trim().Length < 3)
            {
                mensaje = "El ISBN debe tener al menos 3 caracteres.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(nombreLibro))
            {
                mensaje = "El nombre del libro no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(autor))
            {
                mensaje = "El autor no puede estar vacío.";
                return false;
            }

            if (idCategoria <= 0)
            {
                mensaje = "Debe ingresar una categoría válida.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(fechaPublicacion))
            {
                mensaje = "La fecha de publicación no puede estar vacía.";
                return false;
            }

            int numeroPaginas = 0;
            if (!int.TryParse(numeroPaginasTexto, out numeroPaginas) || numeroPaginas <= 0)
            {
                mensaje = "El número de páginas debe ser un entero positivo.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(editorial))
            {
                mensaje = "La editorial no puede estar vacía.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(aliasUsuario))
            {
                mensaje = "El alias de usuario no puede estar vacío.";
                return false;
            }

           

            // Crear y agregar el libro
            Libro nuevoLibro = new Libro();
            nuevoLibro.SetIdLibro(_nextId);
            nuevoLibro.SetISBN(isbn.Trim());
            nuevoLibro.SetNombreLibro(nombreLibro.Trim());
            nuevoLibro.SetAutor(autor.Trim());
            nuevoLibro.SetIdCategoria(idCategoria);
            nuevoLibro.SetNombreCategoria(nombreCategoria.Trim());
            nuevoLibro.SetFechaPublicacion(fechaPublicacion.Trim());
            nuevoLibro.SetNumeroPaginas(numeroPaginas);
            nuevoLibro.SetEditorial(editorial.Trim());
            nuevoLibro.SetAliasUsuario(aliasUsuario.Trim());
            nuevoLibro.SetFechaRegistro(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            nuevoLibro.SetDisponible(true);

            _libros.Add(nuevoLibro);
            _nextId++;

            mensaje = "Libro '" + nombreLibro.Trim() + "' guardado correctamente.";
            return true;
        }

        //  Editar un libro 
        public bool Editar(
            int    idLibro,
            string isbn,
            string nombreLibro,
            string autor,
            int    idCategoria,
            string nombreCategoria,
            string fechaPublicacion,
            string numeroPaginasTexto,
            string editorial,
            string aliasUsuario,
            out string mensaje)
        {
            mensaje = "";

            // Validaciones
            if (string.IsNullOrWhiteSpace(isbn))
            {
                mensaje = "El ISBN no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(nombreLibro))
            {
                mensaje = "El nombre del libro no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(autor))
            {
                mensaje = "El autor no puede estar vacío.";
                return false;
            }

            if (idCategoria <= 0)
            {
                mensaje = "Debe ingresar una categoría válida.";
                return false;
            }

            int numeroPaginas = 0;
            if (!int.TryParse(numeroPaginasTexto, out numeroPaginas) || numeroPaginas <= 0)
            {
                mensaje = "El número de páginas debe ser un entero positivo.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(editorial))
            {
                mensaje = "La editorial no puede estar vacía.";
                return false;
            }

            Libro libro = ObtenerPorId(idLibro);
            if (libro == null)
            {
                mensaje = "No se encontró el libro.";
                return false;
            }

            // Verificar ISBN duplicado
            foreach (Libro lib in _libros)
            {
                if (lib.GetIdLibro() != idLibro &&
                    lib.GetISBN().ToLower() == isbn.Trim().ToLower())
                {
                    mensaje = "Ya existe otro libro con el ISBN '" + isbn.Trim() + "'.";
                    return false;
                }
            }

            // Actualizar datos
            libro.SetISBN(isbn.Trim());
            libro.SetNombreLibro(nombreLibro.Trim());
            libro.SetAutor(autor.Trim());
            libro.SetIdCategoria(idCategoria);
            libro.SetNombreCategoria(nombreCategoria.Trim());
            libro.SetFechaPublicacion(fechaPublicacion.Trim());
            libro.SetNumeroPaginas(numeroPaginas);
            libro.SetEditorial(editorial.Trim());
            libro.SetAliasUsuario(aliasUsuario.Trim());

            mensaje = "Libro '" + nombreLibro.Trim() + "' actualizado correctamente.";
            return true;
        }

        
        public bool Eliminar(int idLibro, out string mensaje)
        {
            mensaje = "";

            Libro libro = ObtenerPorId(idLibro);
            if (libro == null)
            {
                mensaje = "No se encontró el libro.";
                return false;
            }

            _libros.Remove(libro);
            mensaje = "Libro '" + libro.GetNombreLibro() + "' eliminado correctamente.";
            return true;
        }
    }
}
