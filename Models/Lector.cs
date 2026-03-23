using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;

namespace BiblioTech.Models
{
    public class Lector : Usuario
    {
        // Atributos específicos del lector
        private int _maxPrestamos;
        private int _diasPrestamo;
        private int _diasRestrincion;
        private int _multasActuales;
        private bool _restriccionActiva;
        private DateTime _fechaRegistro;
        private List<Prestamo> _prestamosActivos;
        private List<Reserva> _reservas;

        // Constructores
        public Lector() : base() {}

        public Lector(string nombre, string correo, string password, bool activo)
            : base(nombre, correo, password, Rol.Lector, activo)
        {
            _maxPrestamos = 5;
            _diasPrestamo = 14; // Plazo estándar de préstamo
            _diasPrestamo = 0; // Sin restricción inicial
            _multasActuales = 0;
            _restriccionActiva = false;
            _fechaRegistro = DateTime.Now;
            _prestamosActivos = new List<Prestamo>();
            _reservas = new List<Reserva>();
        }

        // Getters y Setters
        public int MaxPrestamos
        {
            get { return _maxPrestamos; }
            set { if (value > 0) _maxPrestamos = value; }
        }

        public int DiasPrestamo
        {
            get { return _diasPrestamo; }
            set { if (value > 0) _diasPrestamo = value; }
        }

        public bool RestriccionActiva
        {
            get { return _restriccionActiva; }
            set { _restriccionActiva = value; }
        }

        public DateTime FechaRegistro
        {
            get { return _fechaRegistro; }
            private set { _fechaRegistro = value; }
        }

        public int MultasActuales
        {
            get { return _multasActuales; }
            set { if (value >= 0) _multasActuales = value; }
        }

        public List<Prestamo> PrestamosActivos
        {
            get { return _prestamosActivos; }
            set
            {
                if (value != null)
                    _prestamosActivos = value;
            }
        }

        public List<Reserva> Reservas
        {
            get { return _reservas; }
            set
            {
                if (value != null)
                    _reservas = value;
            }
        }

        // Métodos

        public bool PuedeRealizarPrestamo()
        {
            return !_restriccionActiva && _prestamosActivos.Count < _maxPrestamos;
        }

        public void AplicarRestrinccion(int dias)
        {
            _diasRestrincion = dias;
            _restriccionActiva = true;
        }

        public void QuitarRestriccion()
        {
            _diasRestrincion = 0;
            _restriccionActiva = false;
        }
    }
}
//7