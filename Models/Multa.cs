using BiblioTech.Models.Enums;
using System;

namespace BiblioTech.Models
{//7
    public class Multa
    {
        // Atributos privados
        private int _id;
        private string _codigoMulta;
        private decimal _monto;
        private string _descripcion;
        private EstadoMulta _estado;
        private TipoMulta _tipoMulta;
        private DateTime _fechaGeneracion;
        private DateTime _fechaPago;
        private Lector _lector;
        private Administrador _administrador;

        // Contador para los Ids
        private static int _contadorIds = 1;

        // Constructores
        public Multa() { }
 
        public Multa(string descripcion, decimal monto, TipoMulta tipoMulta)
        {
            _id = _contadorIds++;
            _codigoMulta = AsignarCodigo(tipoMulta);
            _descripcion = descripcion;
            _monto = monto;
            _estado = EstadoMulta.Pendiente; // Por defecto, la multa se genera como pendiente
            _tipoMulta = tipoMulta;
            _fechaGeneracion = DateTime.Now;
            _lector = null; // Se asignará posteriormente
            _administrador = null; // Se asignará posteriormente

        }

        // Metodos getters y setter
        public int ID { get { return _id; } }

        public string CodigoMulta
        {
            get { return _codigoMulta; }
            private set { _codigoMulta = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public decimal Monto
        {
            get { return _monto; }
            set { if (value > 0) _monto = value; }
        }

        public TipoMulta Tipo
        {
            get { return _tipoMulta; }
            set { _tipoMulta = value; }
        }

        public EstadoMulta Estado
        {
            get { return _estado; }
            set { _estado = value; }
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

        public Administrador Administrador
        {
            get { return _administrador; }
            set { _administrador = value; }
        }

        // Métodos
        private string AsignarCodigo(TipoMulta tipoMulta)
        {
            // Toma la primera letra del tipo de multa
            string prefijo = _tipoMulta.ToString().Substring(0, 1);

            // Genera el codigo
            return $"MLT-{prefijo}-{_id.ToString("D4")}";
        }

        public void Pagar()
        {
            _estado = EstadoMulta.Pagada;
            _fechaPago = DateTime.Now;
        }

        public bool EstaPendiente()
        {
            if (_estado == EstadoMulta.Pagada)
                return false;
            return true;
        }
    }
}
