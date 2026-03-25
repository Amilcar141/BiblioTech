using System;

namespace BiblioTech.Models
{
    public class Categoria
    {
        // Atributos privados
        private int _id;
        private string _codigo;
        private string _nombreCategoria;
        private string _descripcion;

        // Contador de ID para asignar automáticamente
        private static int _contadorId = 1;

        // Constructores
        public Categoria() { }

        public Categoria(string nombreCategoria, string descripcion)
        {
            _id = _contadorId++;
            _codigo = AsignarCategoria(nombreCategoria);
            _nombreCategoria = nombreCategoria;
            _descripcion = descripcion;
        }

        // Metodos Getters y Setters
        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
            private set { _codigo = value; }
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

        // Metodos
        private string AsignarCategoria(string nombre)
        {
            return $"{nombre.Substring(0, 3)}-{_id.ToString("D3")}";
        }
    }
}
