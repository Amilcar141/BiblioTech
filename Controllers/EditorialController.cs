using BiblioTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Controllers
{
    public class EditorialController
    {
        // Instancia del SistemaLibreria para el manejo de datos
        private SistemaLibreria _sistema;

        // Constructor
        public EditorialController(SistemaLibreria sistema)
        {
            _sistema = sistema;
        }


        // Metodos principales

        // Obtener todas las editoriales
        public List<Editorial> ObtenerTodas()
        {
            return _sistema.Editoriales;
        }

        // Agregar una nueva editorial
        public bool AgregarEditorial(string nombre, Nacionalidad pais)
        {
            // Validar que no exista una editorial con el mismo nombre
            if (Existe(nombre))
                return false;

            // Crear y agregar la nueva editorial
            Editorial nuevaEditorial = new Editorial(nombre, pais);
            _sistema.Editoriales.Add(nuevaEditorial);
            return true;
        }

        // Editar una editorial existente
        public bool EditarEditorial(string codigo, string nuevoNombre, Nacionalidad nuevoPais)
        {
            Editorial editorial = BuscarEditorial(codigo);

            if (editorial == null)
                return false;

            editorial.Nombre = nuevoNombre;
            editorial.PaisOrigen = nuevoPais;
            return true;
        }

        // Eliminar una editorial
        public bool EliminarEditorial(string codigo)
        {
            Editorial editorial = BuscarEditorial(codigo);

            _sistema.Editoriales.Remove(editorial);
            return true;
        }


        // Metodos de busqueda y filtrado

        // Buscar editoriales por término (nombre o código)
        public Editorial BuscarEditorial(string termino)
        {
            termino = termino.Trim().ToLower();

            if (Existe(termino))
            {
                foreach (Editorial e in ObtenerTodas())
                {
                    if (e.Nombre.ToLower() == termino || e.Codigo.ToLower() == termino)
                    {
                        return e;
                    }
                }
            }

            return null;
        }

        // Obtener cantidad total de editoriales
        public int ObtenerTotal()
        {
            return _sistema.Editoriales.Count;
        }

        // Validar si existe una editorial por nombre
        public bool Existe(string nombre)
        {

            foreach (Editorial e in ObtenerTodas())
            {
                if (e.Nombre.ToLower() == nombre.ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
