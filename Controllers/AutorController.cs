using BiblioTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Controllers
{
    public class AutorController
    {
        // Instancia del SistemaLibreria para el manejo de datos
        private SistemaLibreria _sistema;

        // Constructor
        public AutorController(SistemaLibreria sistema)
        {
            _sistema = sistema;
        }


        // Metodos principales

        // Obtener todos los autores
        public List<Autor> ObtenerTodos()
        {
            return _sistema.Autores;
        }

        // Agregar un nuevo autor
        public bool AgregarAutor(string nombres, string apellidos, Nacionalidad nacionalidad)
        {
            // Validar que no exista un autor con el mismo nombre completo
            if (Existe(nombres + " " + apellidos))
                return false;

            // Crear y agregar el nuevo autor
            Autor nuevoAutor = new Autor(nombres, apellidos, nacionalidad);
            _sistema.Autores.Add(nuevoAutor);
            return true;
        }

        // Editar un autor existente
        public bool EditarAutor(string codigo, string nuevoNombres, string nuevoApellidos, Nacionalidad nuevaNacionalidad)
        {
            Autor autor = BuscarAutor(codigo);

            if (autor == null)
                return false;

            autor.Nombres = nuevoNombres;
            autor.Apellidos = nuevoApellidos;
            autor.Nacionalidad = nuevaNacionalidad;
            return true;
        }

        // Eliminar un autor
        public bool EliminarAutor(string codigo)
        {
            Autor autor = BuscarAutor(codigo);

            if (autor == null)
                return false;

            _sistema.Autores.Remove(autor);
            return true;
        }


        // Metodos de busqueda y filtrado

        // Buscar autor por código (string)
        public Autor BuscarAutor(string codigo)
        {
            codigo = codigo.Trim().ToUpper();

            foreach (Autor a in ObtenerTodos())
            {
                if (a.Codigo.ToUpper() == codigo)
                {
                    return a;
                }
            }

            return null;
        }

        // Buscar autor por apellido (primer o último apellido)
        public Autor BuscarAutorPorApellido(string apellido)
        {
            apellido = apellido.Trim().ToLower();

            foreach (Autor a in ObtenerTodos())
            {
                // Dividir apellidos en caso de múltiples apellidos
                string[] apellidos = a.Apellidos.ToLower().Split(new[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);

                // Verificar si el apellido buscado coincide con alguno de los apellidos
                foreach (string ap in apellidos)
                {
                    if (ap == apellido)
                    {
                        return a;
                    }
                }
            }

            return null;
        }

        // Obtener cantidad total de autores
        public int ObtenerTotal()
        {
            return _sistema.Autores.Count;
        }

        // Validar si existe un autor por nombre completo
        public bool Existe(string nombreCompleto)
        {
            foreach (Autor a in ObtenerTodos())
            {
                if (a.NombreCompleto().ToLower() == nombreCompleto.ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
