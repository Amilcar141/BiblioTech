using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Reserva
    {
        // Atributos privados
        private int _id;
        private string _codigo;
        private Lector _lector;
        private Ejemplar _ejemplar;
        private DateTime _fechaReserva;
        private bool _activa;

        private static int _contadorId = 1;

        // Constructores
        public Reserva()
        {
        }

        public Reserva(string codigo, Lector lector, Ejemplar ejemplar, DateTime fechaReserva)
        {
            _id = _contadorId++;
            _codigo = codigo;
            _lector = lector;
            _ejemplar = ejemplar;
            _fechaReserva = fechaReserva;
            _activa = true;
        }

        // Metodos getters y setters
        public string Codigo
        {
            get { return _codigo; }
            private set { _codigo = value; }
        }

        public Lector Lector
        {
            get { return _lector; }
            private set { _lector = value; }
        }

        private Ejemplar Ejemplar
        {
            get { return _ejemplar; }
            set { _ejemplar = value; }
        }

        private DateTime FechaReserva
        {
            get { return _fechaReserva; }
            set { _fechaReserva = value; }
        }

        private bool Activa
        {
            get { return _activa; }
            set { _activa = value; }
        }

        // Otros metodos
        private string AsignarCodigo()
        {
            return $"RES-{_id.ToString("D4")}";
        }

    }
}
