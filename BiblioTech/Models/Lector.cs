using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    // Lector hereda de Usuario
    public class Lector : Usuario
    {
        // Atributos propios del lector
        private int _maxPrestamosSimultaneos;
        private int _diasPrestamo;
        private bool _restriccionActiva;
        private DateTime _fechaRestriccion;

        // Constructores
        public Lector() : base()
        {
            _maxPrestamosSimultaneos = 3;
            _diasPrestamo = 14; // Maximo de 14 días para el préstamo
            _restriccionActiva = false;
        }

        public Lector(string nombre, string correo, string password, bool activo)
            : base(nombre, correo, password, Rol.Lector, activo)
        {
            _maxPrestamosSimultaneos = 3;
            _diasPrestamo = 14;
            _restriccionActiva = false;
        }

        // Propiedades
        public int MaxPrestamosSimultaneos
        {
            get { return _maxPrestamosSimultaneos; }
            set { _maxPrestamosSimultaneos = value; }
        }

        public int DiasPrestamo
        {
            get { return _diasPrestamo; }
            set { _diasPrestamo = value; }
        }

        public bool RestriccionActiva
        {
            get { return _restriccionActiva; }
            set { _restriccionActiva = value; }
        }

        public DateTime FechaRestriccion
        {
            get { return _fechaRestriccion; }
            set { _fechaRestriccion = value; }
        }

        // Métodos propios del lector

        // Obtiene los préstamos activos del lector
        public List<Prestamo> GetPrestamosActivos()
        {
            List<Prestamo> prestamosActivos = new List<Prestamo>();

            foreach (Prestamo p in HistorialPrestamos)
            {
                if (p.Estado.ToString() == "Activo")
                {
                    prestamosActivos.Add(p);
                }
            }

            return prestamosActivos;
        }

        // Verifica si el lector tiene un préstamo pendiente
        public bool TienePrestamoPendiente()
        {
            foreach (Prestamo p in HistorialPrestamos)
            {
                if (p.Estado.ToString() == "Pendiente")
                    return true;
            }

            return false;
        }

        // Verifica si el lector puede realizar un préstamo
        public bool PuedeRealizarPrestamo()
        {
            if (!Activo)
                return false;

            if (RestriccionActiva && FechaRestriccion > DateTime.Now)
                return false;

            if (GetPrestamosActivos().Count >= MaxPrestamosSimultaneos)
                return false;

            return true;
        }

        // Aplica una restricción temporal al lector
        public void AplicarRestriccion(int dias)
        {
            _restriccionActiva = true;
            _fechaRestriccion = DateTime.Now.AddDays(dias);
        }

        // Remueve la restricción del lector
        public void RemoverRestriccion()
        {
            _restriccionActiva = false;
            _fechaRestriccion = DateTime.MinValue;
        }
    }
}
