using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Reserva
    {
        private int _id;
        private string _codigo;
        private Lector _lector;
        private Ejemplar _ejemplar;
        private DateTime _fechaReserva;
        private bool _activa;

        // ID autogenerado
        private static int _contadorId = 1;

        // Constructores
        public Reserva() { }

        public Reserva(Lector lector, Ejemplar ejemplar)
        {
            _id = _contadorId++;
            _codigo = AsignarCodigo();
            _lector = lector;
            _ejemplar = ejemplar;
            _fechaReserva = DateTime.Now;
            _activa = true;
        }

        // Propiedades
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
            private set { _codigo = value; }
        }

        public Lector Lector
        {
            get { return _lector; }
            set { _lector = value; }
        }

        public Ejemplar Ejemplar
        {
            get { return _ejemplar; }
            set { _ejemplar = value; }
        }

        public DateTime FechaReserva
        {
            get { return _fechaReserva; }
            private set { _fechaReserva = value; }
        }

        public bool Activa
        {
            get { return _activa; }
            set { _activa = value; }
        }

        // Método privado para asignar código
        private string AsignarCodigo()
        {
            return "RES" + _contadorId.ToString("D4");
        }
    }
}
