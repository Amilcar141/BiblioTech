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
        // Lista de ejemplares asociados a un libro
        List<Ejemplar> _ejemplares;

        public EjemplarController()
        {
            _ejemplares = new List<Ejemplar>();
        }

        // Metodos

        // Obtiene el total de ejemplares disponibles para préstamo
        public int ObtenerEjemplaresDisponibles()
        {
            int disponibles = 0;
            foreach (Ejemplar e in _ejemplares)
            {
                if (e.Estado == EstadoPublicacion.Disponible)
                    disponibles++;
            }
            return disponibles;
        }

        // Obtiene el total de ejemplares registrados
        public int ObtenerTotalEjemplares()
        {
            return _ejemplares.Count;
        }

        // Verifica si el libro tiene stock disponible
        public bool VerificarDisponibilidad()
        {
            return ObtenerEjemplaresDisponibles() > 0;
        }

        // Agrega un ejemplar al libro
        public void AgregarEjemplar(Ejemplar ejemplar)
        {
            if (ejemplar != null)
            {
                _ejemplares.Add(ejemplar);
            }
        }

        // Remueve un ejemplar del libro
        public bool RemoverEjemplar(Ejemplar ejemplar)
        {
            if (ejemplar != null && _ejemplares.Contains(ejemplar))
            {
                _ejemplares.Remove(ejemplar);
                return true;
            }
            return false;
        }

    }
}
