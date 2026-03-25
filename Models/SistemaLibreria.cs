 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class SistemaLibreria
    {
        // Colecciones del sistema
        private static List<Libro> _libros;
        private static List<Autor> _autores;
        private static List<Editorial> _editoriales;
        private static List<Categoria> _categorias;
        private static List<Ejemplar> _ejemplares;
        private static List<Publicacion> _publicaciones;
        private static List<Catalogo> _catalogos;
        private static List<Lector> _lectores;
        private static List<Reserva> _reservas;
        private static List<Prestamo> _prestamos;
        private static List<Multa> _multas;

        // Constructor
        public SistemaLibreria()
        {
            // Inicializar colecciones
            _libros = new List<Libro>();
            _autores = new List<Autor>();
            _editoriales = new List<Editorial>();
            _categorias = new List<Categoria>();
            _ejemplares = new List<Ejemplar>();
            _publicaciones = new List<Publicacion>();
            _catalogos = new List<Catalogo>();
            _lectores = new List<Lector>();
            _reservas = new List<Reserva>();
            _prestamos = new List<Prestamo>();
            _multas = new List<Multa>();
        }

        // Propiedades Get y Set

        public List<Libro> Libros
        {
            get { return _libros; }
            set { _libros = value; }
        }

        public List<Autor> Autores
        {
            get { return _autores; }
            set { _autores = value; }
        }

        public List<Editorial> Editoriales
        {
            get { return _editoriales; }
            set { _editoriales = value; }
        }

        public List<Categoria> Categorias
        {
            get { return _categorias; }
            set { _categorias = value; }
        }

        public List<Ejemplar> Ejemplares
        {
            get { return _ejemplares; }
            set { _ejemplares = value; }
        }

        public List<Publicacion> Publicaciones
        {
            get { return _publicaciones; }
            set { _publicaciones = value; }
        }

        public List<Catalogo> Catalogos
        {
            get { return _catalogos; }
            set { _catalogos = value; }
        }

        public List<Lector> Lectores
        {
            get { return _lectores; }
            set { _lectores = value; }
        }

        public List<Reserva> Reservas
        {
            get { return _reservas; }
            set { _reservas = value; }
        }

        public List<Prestamo> Prestamos
        {
            get { return _prestamos; }
            set { _prestamos = value; }
        }

        public List<Multa> Multas
        {
            get { return _multas; }
            set { _multas = value; }
        }
    }
}
