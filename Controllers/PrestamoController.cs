using System;
using System.Collections.Generic;
using System.Linq;
using BiblioTech.Models;
using BiblioTech.Models.Enums;

namespace BiblioTech.Controllers
{
    public class PrestamoController
    {
        // Instancia del SistemaLibreria para el manejo de datos
        private SistemaLibreria _sistema;

        // Constructor
        public PrestamoController(SistemaLibreria sistema)
        {
            _sistema = sistema;
        }

        // Métodos principales

        // Obtener todos los préstamos
        public List<Prestamo> ObtenerTodos()
        {
            return _sistema.Prestamos;
        }

        // Registrar un nuevo préstamo
        public bool RegistrarPrestamo(Prestamo prestamo)
        {
            if (prestamo == null)
                return false;

            _sistema.Prestamos.Add(prestamo);
            return true;
        }

        // Devolver un préstamo
        public bool DevolverPrestamo(int id)
        {
            Prestamo prestamo = ObtenerPorId(id);
            if (prestamo == null)
                return false;

            prestamo.RegistrarDevolucion(DateTime.Now, new Models.Administrador("Admin", "admin@system.com", "1234", true, 1, ""));
            return true;
        }

        // Métodos de búsqueda y filtrado

        // Obtener préstamo por ID (usando el código como identificador)
        public Prestamo ObtenerPorCodigo(string codigo)
        {
            return ObtenerTodos()
                .FirstOrDefault(p => p.Codigo == codigo);
        }

        // Obtener préstamo por ID (para compatibilidad)
        public Prestamo ObtenerPorId(int id)
        {
            // Como IdPrestamo no es público, usamos el índice de la lista
            if (id >= 0 && id < ObtenerTodos().Count)
                return ObtenerTodos()[id];
            return null;
        }

        // Obtener préstamos activos
        public List<Prestamo> ObtenerActivos()
        {
            return ObtenerTodos()
                .Where(p => p.Estado == EstadoPrestamo.Activo)
                .ToList();
        }

        // Obtener préstamos devueltos
        public List<Prestamo> ObtenerDevueltos()
        {
            return ObtenerTodos()
                .Where(p => p.Estado == EstadoPrestamo.Devuelto)
                .ToList();
        }

        // Obtener préstamos vencidos
        public List<Prestamo> ObtenerVencidos()
        {
            return ObtenerTodos()
                .Where(p => p.EstaVencido() && p.Estado != EstadoPrestamo.Devuelto)
                .ToList();
        }

        // Obtener préstamos por lector
        public List<Prestamo> ObtenerPorLector(Lector lector)
        {
            if (lector == null)
                return new List<Prestamo>();

            return ObtenerTodos()
                .Where(p => p.Lector != null && p.Lector.Cuenta == lector.Cuenta)
                .ToList();
        }

        // Obtener préstamos activos de un lector
        public List<Prestamo> ObtenerActivosPorLector(Lector lector)
        {
            if (lector == null)
                return new List<Prestamo>();

            return ObtenerPorLector(lector)
                .Where(p => p.Estado == EstadoPrestamo.Activo)
                .ToList();
        }

        // Obtener préstamos por ejemplar/libro
        public List<Prestamo> ObtenerPorLibro(Libro libro)
        {
            if (libro == null)
                return new List<Prestamo>();

            return ObtenerTodos()
                .Where(p => p.Libros != null && p.Libros.Any(e => e.Libro.ISBN == libro.ISBN))
                .ToList();
        }

        // Obtener préstamos por ejemplar específico
        public List<Prestamo> ObtenerPorEjemplar(Ejemplar ejemplar)
        {
            if (ejemplar == null)
                return new List<Prestamo>();

            return ObtenerTodos()
                .Where(p => p.Libros != null && p.Libros.Any(e => e.CodigoEjemplar == ejemplar.CodigoEjemplar))
                .ToList();
        }

        // Otros métodos

        // Obtener total de préstamos activos
        public int ObtenerTotalActivos()
        {
            return ObtenerActivos().Count;
        }

        // Obtener total de préstamos vencidos
        public int ObtenerTotalVencidos()
        {
            return ObtenerVencidos().Count;
        }

        // Obtener total de préstamos
        public int ObtenerTotal()
        {
            return ObtenerTodos().Count;
        }

        // Verificar si existe un préstamo activo para un libro
        public bool TienePrestamoActivo(Libro libro)
        {
            if (libro == null)
                return false;

            return ObtenerPorLibro(libro)
                .Any(p => p.Estado == EstadoPrestamo.Activo);
        }
    }
}
