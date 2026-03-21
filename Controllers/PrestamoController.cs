using System;
using System.Collections.Generic;
using BiblioTech.Models;
using BiblioTech.Models.Enums;

namespace BiblioTech.Controllers
{
    public class PrestamoController 
    {
        // Lista  para que todas las vistas compartan los mismos préstamos
        private static List<Prestamo> _historial = new List<Prestamo>();
        private static int _nextId = 1;

        public PrestamoController() { }

        public List<Prestamo> Historial
        {
            get { return _historial; }
        }

        // Registrar un nuevo préstamo
        public bool RegistrarPrestamo(Prestamo prestamo)
        {
            if (prestamo == null) return false;
            prestamo.IdPrestamo = _nextId++;
            _historial.Add(prestamo);
            return true;
        }

        // Obtener préstamo por ID
        public Prestamo ObtenerPorId(int id)
        {
            foreach (Prestamo p in _historial)
                if (p.IdPrestamo == id) return p;
            return null;
        }

        // Obtener préstamos activos
        public List<Prestamo> ObtenerActivos()
        {
            List<Prestamo> activos = new List<Prestamo>();
            foreach (Prestamo p in _historial)
                if (p.Estado == EstadoPrestamo.Activo) activos.Add(p);
            return activos;
        }

        // Obtener préstamos vencidos
        public List<Prestamo> ObtenerVencidos()
        {
            List<Prestamo> vencidos = new List<Prestamo>();
            foreach (Prestamo p in _historial)
                if (p.EstaVencido() && p.Estado != EstadoPrestamo.Devuelto) vencidos.Add(p);
            return vencidos;
        }

        // Devolver un préstamo
        public bool DevolverPrestamo(int id)
        {
            Prestamo p = ObtenerPorId(id);
            if (p == null) return false;
            p.RegistrarDevolucion(DateTime.Now, new Models.Administrador("Admin"));
            if (p.Libro != null) p.Libro.SetDisponible(true);
            return true;
        }
    }
}
