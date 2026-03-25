using BiblioTech.Models;
using System;
using System.Collections.Generic;

namespace BiblioTech.Controllers
{
    public class CategoriaController
    {
        // Instancia del SistemaLibreria para el manejo de datos
        private SistemaLibreria _sistema;

        // Constructor
        public CategoriaController(SistemaLibreria sistema)
        {
            _sistema = sistema;
        }

        // Metodos principales

        // Obtener todas las categorías
        public List<Categoria> ObtenerTodas()
        {
            return _sistema.Categorias;
        }

        // Agregar una nueva categoría
        public bool AgregarCategoria(string nombre, string descripcion)
        {
            // Validar que no exista una categoría con el mismo nombre
            if (Existe(nombre))
                return false;

            // Crear y agregar la nueva categoría
            Categoria nuevaCategoria = new Categoria(nombre, descripcion);
            _sistema.Categorias.Add(nuevaCategoria);
            return true;
        }

        // Editar una categoría existente
        public bool EditarCategoria(string codigo, string nuevoNombre, string nuevaDescripcion)
        {
            Categoria categoria = BuscarCategoria(codigo);

            if (categoria == null)
                return false;

            categoria.NombreCategoria = nuevoNombre;
            categoria.Descripcion = nuevaDescripcion;
            return true;
        }

        // Eliminar una categoría
        public bool EliminarCategoria(string codigo)
        {
            Categoria categoria = BuscarCategoria(codigo);

            if (categoria == null)
                return false;

            _sistema.Categorias.Remove(categoria);
            return true;
        }

        // Metodos de busqueda y filtrado

        // Buscar categoría por ID
        public Categoria BuscarCategoria(string codigo)
        {
            foreach (Categoria c in ObtenerTodas())
            {
                if (c.Codigo == codigo)
                    return c;
            }

            return null;
        }

        // Buscar categoría por nombre
        public Categoria BuscarPorNombre(string nombre)
        {
            nombre = nombre.Trim().ToLower();

            foreach (Categoria c in ObtenerTodas())
            {
                if (c.NombreCategoria.ToLower() == nombre)
                {
                    return c;
                }
            }

            return null;
        }

        // Obtener cantidad total de categorías
        public int ObtenerTotal()
        {
            return _sistema.Categorias.Count;
        }

        // Validar si existe una categoría por nombre
        public bool Existe(string nombre)
        {
            foreach (Categoria c in ObtenerTodas())
            {
                if (c.NombreCategoria.ToLower() == nombre.Trim().ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
