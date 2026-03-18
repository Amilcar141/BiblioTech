using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BiblioTech.Models;

namespace BiblioTech.Controllers
{ 
    public class CategoriaController
    {
        // Estructura de datos privada para Categorias
        private static List<Categoria> _categorias;

        // Constructor
        public CategoriaController()
        {
            _categorias = new List<Categoria>();
        }

        // Metodos de consulta
        public List<Categoria> ObtenerTodas()
        {
            return _categorias;
        }

        public Categoria ObtenerPorCodigo(string codigo)
        {
            foreach (Categoria cat in _categorias)
            {
                if (cat.CodigoCategoria == codigo)
                    return cat;
            }
            return null;
        }

        public Categoria ObtenerPorNombre(string nombre)
        {
            foreach (Categoria cat in _categorias)
            {
                if (cat.NombreCategoria.ToLower() == nombre.Trim().ToLower())
                    return cat;
            }
            return null;
        }

        // Metodo Guardar
        public bool Guardar(string nombreCategoria, string descripcion)
        {
            foreach (Categoria cat in _categorias)
            {
                if (cat.NombreCategoria.ToLower() == nombreCategoria.Trim().ToLower())
                    return false;
            }

            Categoria nuevaCategoria = new Categoria(nombreCategoria, descripcion);
            _categorias.Add(nuevaCategoria);
            return true;
        }

        // Metodo Editar
        public bool Editar(string codigo, string nuevoNombre, string decripcion)
        {
            foreach (Categoria cat in _categorias)
            {
                if (cat.CodigoCategoria == codigo)
                {
                    cat.NombreCategoria = nuevoNombre;
                    cat.Descripcion = decripcion;
                    return true;
                }
            }
            return false;
        }

        // Metodo Eliminar
        public bool Eliminar(string codigo)
        {
            foreach (Categoria cat in _categorias)
            {
                if (cat.CodigoCategoria == codigo)
                {
                    _categorias.Remove(cat);
                    return true;
                }
            }
            return false;
        }
    }
}
