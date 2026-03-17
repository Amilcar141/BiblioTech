using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Models;
using BiblioTech.Models.Enums;

namespace BiblioTech.Controllers
{
    public class PrestamoController
    {
        private List<Prestamo> _prestamos;

        public PrestamoController()
        {
            _prestamos = new List<Prestamo>();
        }

        // Registra un nuevo préstamo
        public bool RegistrarPrestamo(Prestamo prestamo)
        {
            if (prestamo == null)
                return false;

            _prestamos.Add(prestamo);
            return true;
        }

        // Obtiene un préstamo por código
        public Prestamo ObtenerPrestamoPorCodigo(string codigo)
        {
            foreach (Prestamo p in _prestamos)
            {
                if (p.CodigoPrestamo == codigo)
                {
                    return p;
                }
            }

            return null;
        }

        // Obtiene todos los préstamos de un lector
        public List<Prestamo> ObtenerPrestamosPorLector(string idLector)
        {
            List<Prestamo> prestamosLector = new List<Prestamo>();

            foreach (Prestamo p in _prestamos)
            {
                if (p.Lector != null && p.Lector.NumeroCuenta == idLector)
                {
                    prestamosLector.Add(p);
                }
            }

            return prestamosLector;
        }

        // Obtiene todos los préstamos activos
        public List<Prestamo> ObtenerPrestamosActivos()
        {
            List<Prestamo> prestamosActivos = new List<Prestamo>();

            foreach (Prestamo p in _prestamos)
            {
                if (p.Estado == EstadoPrestamo.Activo)
                {
                    prestamosActivos.Add(p);
                }
            }

            return prestamosActivos;
        }

        // Obtiene todos los préstamos vencidos
        public List<Prestamo> ObtenerPrestamosVencidos()
        {
            List<Prestamo> prestamosVencidos = new List<Prestamo>();

            foreach (Prestamo p in _prestamos)
            {
                if (p.FechaLimite < DateTime.Now && p.Estado == EstadoPrestamo.Activo)
                {
                    prestamosVencidos.Add(p);
                }
            }

            return prestamosVencidos;
        }

        // Obtiene todos los préstamos
        public List<Prestamo> ObtenerTodosPrestamos()
        {
            return _prestamos;
        }

        // Devuelve un préstamo
        public bool DevolverPrestamo(string codigoPrestamo)
        {
            Prestamo prestamo = ObtenerPrestamoPorCodigo(codigoPrestamo);

            if (prestamo == null)
                return false;

            prestamo.FechaDevolucion = DateTime.Now;
            prestamo.Estado = EstadoPrestamo.Devuelto;
            return true;
        }

        // Actualiza el estado de un préstamo
        public bool ActualizarEstadoPrestamo(string codigoPrestamo, EstadoPrestamo nuevoEstado)
        {
            Prestamo prestamo = ObtenerPrestamoPorCodigo(codigoPrestamo);

            if (prestamo == null)
                return false;

            prestamo.Estado = nuevoEstado;
            return true;
        }

        // Elimina un préstamo
        public bool EliminarPrestamo(string codigoPrestamo)
        {
            Prestamo prestamo = ObtenerPrestamoPorCodigo(codigoPrestamo);

            if (prestamo == null)
                return false;

            _prestamos.Remove(prestamo);
            return true;
        }

        // Obtiene el total de préstamos registrados
        public int ObtenerTotalPrestamos()
        {
            return _prestamos.Count;
        }
    }
}

