using BiblioTech.Models;
using System.Collections.Generic;
using System;

namespace BiblioTech.Models
{ //7
    public class Libro
    {
        // Atributos privados
        private int _id; 
        private string _isbn;
        private string _titulo;
        private Autor _autor; 
        private Categoria _categoria;
        private Editorial _editorial;
        private decimal _precio;
        private int _numeroPaginas;
        private DateTime _fechaPublicacion;
        private DateTime _fechaRegistro;

        // COntador interno
        private static int _contadorId = 1;

        // Constructores
        public Libro()
        {
        }

        public Libro(string titulo, Autor autor, Categoria categoria, Editorial editorial,
            decimal precio, int paginas)
        {
            _id = _contadorId++;
            _isbn = ValidarISBN(_isbn);
            _titulo = titulo;
            _autor = autor;
            _categoria = categoria;
            _editorial = editorial;
            _precio = precio;
            _numeroPaginas = paginas;
        }

        // Getters y Setters
        public string ISBN
        {
            get { return _isbn; }
            private set { _isbn = value }
        }

        public string Titulo
        {
            get { return _titulo }
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


        // Metodos propios de la clase libro
        private string ValidarISBN(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
                return null;

            // Eliminar guiones y espacios
            isbn = isbn.Replace("-", "").Replace(" ", "");
            if (isbn.Length == 13)
                return isbn;

            return null;
        }

    }
}


