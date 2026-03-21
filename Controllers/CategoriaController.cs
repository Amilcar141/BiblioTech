using System;
using System.Collections.Generic;
using BiblioTech.Models;
 
namespace BiblioTech.Controllers
{ 
    public class CategoriaController
    {
        
        private static List<Categoria> _categorias = new List<Categoria>();
        private static int _nextId = 1;

        // Constructor
        public CategoriaController()
        {
        }

        
        public List<Categoria> ObtenerTodas()
        {
            List<Categoria> ordenada = new List<Categoria>(_categorias);
            ordenada.Sort((a, b) => string.Compare(a.GetNombreCategoria(), b.GetNombreCategoria()));
            return ordenada;
        }

        public Categoria ObtenerPorId(int id)
        {
            foreach (Categoria cat in _categorias)
            {
                if (cat.GetIdCategoria() == id)
                    return cat;
            }
            return null;
        }

        public Categoria ObtenerPorNombre(string nombre)
        {
            foreach (Categoria cat in _categorias)
            {
                if (cat.GetNombreCategoria().ToLower() == nombre.Trim().ToLower())
                    return cat;
            }
            return null;
        }

        // Guardar
        public bool Guardar(string nombreCategoria, out string mensaje)
        {
            mensaje = "";

            // Validaciones
            if (string.IsNullOrWhiteSpace(nombreCategoria))
            {
                mensaje = "El nombre de categoría no puede estar vacío.";
                return false;
            }

            if (nombreCategoria.Trim().Length < 2)
            {
                mensaje = "El nombre debe tener al menos 2 caracteres.";
                return false;
            }

            if (nombreCategoria.Trim().Length > 100)
            {
                mensaje = "El nombre no puede superar los 100 caracteres.";
                return false;
            }

            if (ObtenerPorNombre(nombreCategoria) != null)
            {
                mensaje = "Ya existe una categoría llamada '" + nombreCategoria.Trim() + "'.";
                return false;
            }

            // Crear y agregar
            Categoria nuevaCategoria = new Categoria();
            nuevaCategoria.SetIdCategoria(_nextId);
            nuevaCategoria.SetNombreCategoria(nombreCategoria.Trim());

            _categorias.Add(nuevaCategoria);
            _nextId++;

            mensaje = "Categoría '" + nombreCategoria.Trim() + "' guardada correctamente.";
            return true;
        }

        //  Editar
        public bool Editar(int id, string nuevoNombre, out string mensaje)
        {
            mensaje = "";

            // Validaciones
            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                mensaje = "El nombre de categoría no puede estar vacío.";
                return false;
            }

            if (nuevoNombre.Trim().Length < 2)
            {
                mensaje = "El nombre debe tener al menos 2 caracteres.";
                return false;
            }

            Categoria cat = ObtenerPorId(id);
            if (cat == null)
            {
                mensaje = "No se encontró la categoría.";
                return false;
            }

            // Verificar duplicado
            foreach (Categoria c in _categorias)
            {
                if (c.GetIdCategoria() != id &&
                    c.GetNombreCategoria().ToLower() == nuevoNombre.Trim().ToLower())
                {
                    mensaje = "Ya existe otra categoría llamada '" + nuevoNombre.Trim() + "'.";
                    return false;
                }
            }

            cat.SetNombreCategoria(nuevoNombre.Trim());
            mensaje = "Categoría actualizada a '" + nuevoNombre.Trim() + "'.";
            return true;
        }

        // Eliminar
        public bool Eliminar(int id, out string mensaje)
        {
            mensaje = "";

            Categoria cat = ObtenerPorId(id);
            if (cat == null)
            {
                mensaje = "No se encontró la categoría.";
                return false;
            }

            // Verificar libros asociados
            LibroController libroCtrl = new LibroController();
            int librosAsociados = 0;

            foreach (Libro lib in libroCtrl.ObtenerTodos())
            {
                if (lib.GetIdCategoria() == id)
                    librosAsociados++;
            }

            if (librosAsociados > 0)
            {
                mensaje = "No se puede eliminar: tiene " + librosAsociados + " libro(s) asociado(s).";
                return false;
            }

            _categorias.Remove(cat);
            mensaje = "Categoría eliminada correctamente.";
            return true;
        }
    }
}
