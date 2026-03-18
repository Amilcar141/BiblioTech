using System;

namespace BiblioTech.Models
{
    public class Categoria
    {
        // Atributos privados de Categoria
        private int _id;
        private string _codigoCategoria;
        private string _nombreCategoria;
        private string _descripcion;

        // Contador para generar IDs únicos
        private static int _contadorId = 1;

        // Constructor es
        public Categoria() { }

        public Categoria(string nombreCategoria, string descripcion)
        {
            _id = _contadorId++;
            _codigoCategoria = AsignarCodigo(nombreCategoria);
            _nombreCategoria = nombreCategoria;
            _descripcion = descripcion;
        }

        // Metodos Getters y Setters
        public string CodigoCategoria
        {
            get { return _codigoCategoria; }
            private set { _codigoCategoria = value; }
        }

        public string NombreCategoria
        {
            get { return _nombreCategoria; }
            set { _nombreCategoria = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }


        // Asignar un código único a cada categoría
        private string AsignarCodigo(string categoria)
        {
            return "CAT-" + categoria.Substring(0, 3).ToUpper();
        }

    }
}
