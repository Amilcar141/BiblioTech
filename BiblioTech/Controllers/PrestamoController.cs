using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Models;

namespace BiblioTech.Controllers
{
    public class PrestamoController
    {
        public static List<Prestamo> Historial;

        public PrestamoController()
        {
            Historial = new List<Prestamo>();
        }

        public string RegistrarPrestamo(int idLibro, int idUsuario)
        {
            // Buscamos el libro en el inventario
            var libro = LibroController.Inventario.Find(l => l.idLibro == idLibro);

            // Si no existe o no está disponible, avisamos
            if (libro == null || !libro.Disponibilidad)
                return "Libro no disponible";

            // Creamos el nuevo objeto (Nota los paréntesis () antes de la llave)
            Prestamo nuevo = new Prestamo()
            {
                idPrestamo = Historial.Count + 1, 
                idLibro = idLibro,
                idUsuario = idUsuario,
                FechaSalida = System.DateTime.Now,
                FechaEntrega = System.DateTime.Now.AddDays(7), // Se entrega en 7 días
                FueDevuelto = false
            };

            Historial.Add(nuevo);
            libro.Disponibilidad = false; // Marcamos el libro como prestado
            return "¡Préstamo registrado con éxito!";
        }

        public void RegistrarDevolucion(int idPrestamo)
        {
            var prestamo = Historial.Find(p => p.idPrestamo == idPrestamo);
            if (prestamo != null)
            {
                prestamo.FueDevuelto = true;
                var libro = LibroController.Inventario.Find(l => l.idLibro == prestamo.idLibro);
                if (libro != null) libro.Disponibilidad = true;
            }
        }
    }
}

