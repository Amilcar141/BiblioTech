using BiblioTech.Models;
using System.Collections.Generic;
using System;

namespace BiblioTech.Models
{
    public class Libro
    {
        // Atributos privados
        private int _id; 
        private string _isbn;
        private string _titulo;
        private decimal _precio;
        private int _numeroPaginas;
        private Autor _autor; 
        private Categoria _categoria;
        private Editorial _editorial;
        private DateTime _fechaPublicacion;
        private DateTime _fechaRegistro;

        // COntador interno
        private static int _contadorId = 1;

        // Constructores
        public Libro()
        {
        }

        public Libro(string isbn, string titulo, Autor autor, Categoria categoria, Editorial editorial,
            decimal precio, int paginas, DateTime fechaPublicacion)
        {
            _id = _contadorId++;
            _isbn = ValidarISBN(isbn);
            _titulo = titulo;
            _autor = autor;
            _categoria = categoria;
            _editorial = editorial;
            _precio = precio;
            _numeroPaginas = paginas;
            _fechaRegistro = DateTime.Now;
            _fechaPublicacion = fechaPublicacion;
        }

        // Getters y Setters
        public string ISBN
        {
            get { return _isbn; }
            private set { _isbn = value; }
        }

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public Autor Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public Editorial Editorial
        {
            get { return _editorial; }
            set { _editorial = value; }
        }

        public decimal Precio
        {
            get { return _precio; }
            set 
            { 
                if (value > 0)
                    _precio = value; 
            }
        }

        public int NumeroPaginas
        {
            get { return _numeroPaginas; }
            set 
            { 
                if (value > 0)
                    _numeroPaginas = value; 
            }
        }

        public DateTime FechaPublicacion
        {
            get { return _fechaPublicacion; }
            set { _fechaPublicacion = value; }
        }

        public DateTime FechaRegistro
        {
            get { return _fechaRegistro; }
        }


        // Metodos propios de la clase libro
        private string ValidarISBN(string isbn)
        {
            // Eliminar guiones y espacios
            isbn = isbn.Replace("-", "").Replace(" ", "");
            if (isbn.Length == 13)
                return isbn;

            return null;
        }

    }
}


