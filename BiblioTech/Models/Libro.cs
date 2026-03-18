using BiblioTech.Models;
using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BiblioTech.Models
{
    public class Libro
    {
        // Atributos privados
        private int _id;
        private string _isbn;
        private string _titulo;
        private string _autor;
        private string _editorial;
        private decimal _precio;
        private int _numeroPaginas;
        private DateTime _fechaPublicacion;
        private DateTime _fechaRegistro;
        private bool _tieneStock;
        private List<Ejemplar> _ejemplares;
        private Categoria _categoria;

        // Contador para generar IDs únicos
        private static int _contadorId = 1;

        // Constructores
        public Libro()
        {
            _id = _contadorId++;
            _ejemplares = new List<Ejemplar>();
            _fechaRegistro = DateTime.Now;
            _tieneStock = true;
        }

        public Libro(string isbn, string titulo, string autor, string editorial, 
            decimal precio, int numeroPaginas, DateTime fechaPublicacion, Categoria categoria)
        {
            _id = _contadorId++;
            _isbn = isbn;
            _titulo = titulo;
            _autor = autor;
            _editorial = editorial;
            _precio = precio;
            _numeroPaginas = numeroPaginas;
            _fechaPublicacion = fechaPublicacion;
            _categoria = categoria;
            _ejemplares = new List<Ejemplar>();
            _fechaRegistro = DateTime.Now;
            _tieneStock = true;
        }

        // Propiedades modernas

        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public string Editorial
        {
            get { return _editorial; }
            set { _editorial = value; }
        }

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public int NumeroPaginas
        {
            get { return _numeroPaginas; }
            set { _numeroPaginas = value; }
        }

        public DateTime FechaPublicacion
        {
            get { return _fechaPublicacion; }
            set { _fechaPublicacion = value; }
        }

        public DateTime FechaRegistro
        {
            get { return _fechaRegistro; }
            private set { _fechaRegistro = value; }
        }

        public bool TieneStock
        {
            get { return _tieneStock; }
            set { _tieneStock = value; }
        }

        public List<Ejemplar> Ejemplares
        {
            get { return _ejemplares; }
            set { 
                if (value != null)
                    _ejemplares = value; 
            }
        }

        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        // Validar ISBN
        public bool ValidarISBN(string isbn)
        {
            if (isbn == null) 
                return false;

            // Limpia el formato
            string limpio = Regex.Replace(isbn, @"[- ]", "");

            // Validar ISBN-10
            if (limpio.Length == 10)
            {
                int sum = 0;
                for (int i = 0; i < 9; i++)
                {
                    if (!char.IsDigit(limpio[i])) 
                        return false;

                    sum += (limpio[i] - '0') * (10 - i);
                }

                // El último caracter puede ser una 'X' (que vale 10)
                char last = limpio[9];
                sum += (last == 'X' || last == 'x') ? 10 : (last - '0');

                return (sum % 11 == 0);
            }

            // Validar ISBN-13
            if (limpio.Length == 13)
            {
                if (!limpio.All(char.IsDigit)) 
                    return false;

                int sum = 0;
                for (int i = 0; i < 12; i++)
                {
                    // Ponderación
                    sum += (limpio[i] - '0') * (i % 2 == 0 ? 1 : 3);
                }

                int checkDigit = (10 - (sum % 10)) % 10;
                return checkDigit == (limpio[12] - '0');
            }

            return false;
        }

        // Verificar stock disponible
        public bool VerificarStock()
        {
            return Ejemplar.ContarDisponibles(_ejemplares) > 0;
        }
    }
}


