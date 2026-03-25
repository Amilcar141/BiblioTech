using BiblioTech.Models;
using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Controllers
{
    public class EjemplarController
    {
        // Instancia del SistemaLibreria para el manejo de datos
        private SistemaLibreria _sistema;

        // Constructor
        public EjemplarController(SistemaLibreria sistema)
        {
            _sistema = sistema;
        }


        // Metodos principales

        // Obtener todos los ejempplares
        public List<Ejemplar> ObtenerTodos()
        {
            return _sistema.Ejemplares;
        }

        // Agregar un nuevo autor
        public bool AgregarEjemplar(Libro libro, int cantidad)
        {
            if (libro == null || cantidad <= 0)
                return false;

            // Añade varios ejemplares del mismo libro
            for (int i = 0; i < cantidad; i++)
            {
                Ejemplar nuevoEjemplar = new Ejemplar(libro);
                _sistema.Ejemplares.Add(nuevoEjemplar);
            }

            return true;
        }

        // Remueve un solo ejemplar
        public bool RemoverEjemplar(string codigo)
        {
            Ejemplar ejem = BuscarEjemplar(codigo);

            if (ejem == null)
                return false;

            _sistema.Ejemplares.Remove(ejem);
            return true;
        }

        // Remueve todos los ejemplares de un libro específico
        public bool RemoverEjemplaresPorLibro(Libro libro)
        {
            if (libro == null)
                return false;

            // Elimina todos los ejemplares que correspondan al libro dado
            _sistema.Ejemplares.RemoveAll(e => e.Libro.ISBN == libro.ISBN);
            return true;
        }


        // Metodos de busqueda y filtrado

        // Buscar autor por código (string)
        public Ejemplar BuscarEjemplar(string codigo)
        {
            codigo = codigo.Trim().ToUpper();

            foreach (Ejemplar e in ObtenerTodos())
            {
                if (e.CodigoEjemplar.ToUpper() == codigo)
                {
                    return e;
                }
            }

            return null;
        }

        // Obtener cantidad total de autores
        public int ObtenerTotal()
        {
            return _sistema.Ejemplares.Count;
        }
    }
}
