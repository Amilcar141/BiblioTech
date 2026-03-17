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
        private string _descripcion;
        private decimal _monto;
        private EstadoMulta _estado;
        private TipoMulta _tipoMulta;
        private DateTime _fechaGeneracion;
        private DateTime _fechaPago;
        private Lector _lector;
        private Prestamo _prestamo;

        // Contador para el manejo de los IDs
        private static int _contadorIds = 1;

        // Constructores}
        public Multa()
        {
        }

        public Multa(TipoMulta tipo, decimal monto, string descripcion)
        {
            _id = _contadorIds++;
            _tipoMulta = tipo;
            _descripcion = descripcion;
            _monto = monto;
            _estado = EstadoMulta.Pendiente;
            _fechaGeneracion = DateTime.Now;
            _codigoMulta = AsignarCodigo();
        }

        // Metodos get y set
        public string CodigoMulta
        {
            get { return _codigoMulta; }
            set { _codigoMulta = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public decimal Monto
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

        public TipoMulta TipoMulta
        {
            get { return _tipoMulta; }
            set { _tipoMulta = value; }
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

        public Lector Lector
        {
            get { return _lector; }
            set { _lector = value; }
        }

        public Prestamo Prestamo
        {
            get { return _prestamo; }
            set { _prestamo = value; }
        }

        // Metodos de la multa

        // Metodo para asignar un codigo unico a cada multa
        private string AsignarCodigo()
        {
            // Obtinene la inicial identificadora del tipo de multa
            char tipoMulta = _tipoMulta.ToString()[0];

            return "MLT-" + tipoMulta + "-" + _id.ToString("D4");
        }

        public void Pagar()
        {
            if (_estado == EstadoMulta.Pagada)
                return;

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
