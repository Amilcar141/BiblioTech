using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Multa
    {
        // Atributos privados
        private int _id;
        private string _codigoMulta;
        private double _monto;
        private EstadoMulta _estado;
        private DateTime _fechaGeneracion;
        private DateTime _fechaPago;

        // Constructores}
        public Multa()
        {
        }

        public Multa(int id, double monto)
        {
            _id = id;
            _monto = monto;
            _estado = EstadoMulta.Pendiente;
            _fechaGeneracion = DateTime.Now;
        }

        // Metodos get y set
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public double Monto
        {
            get { return _monto; }
            set
            {
                if (value > 0)
                    _monto = value;
            }
        }

        public EstadoMulta Estado
        {
            get { return _estado; }
            private set { _estado = value; }
        }

        public DateTime FechaGeneracion
        {
            get { return _fechaGeneracion; }
            private set { _fechaGeneracion = value; }
        }

        public DateTime FechaPago
        {
            get { return _fechaPago; }
            private set { _fechaPago = value; }
        }

        // Metodos de la multa
        public void Pagar()
        {
            _estado = EstadoMulta.Pagada;
            _fechaPago = DateTime.Now;
        }

        public bool EstaPendiente()
        {
            if (_estado == EstadoMulta.Pendiente)
                return true;
            else
                return false;
        }

    }
}
