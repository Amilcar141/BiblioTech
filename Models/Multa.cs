using BiblioTech.Models.Enums;
using System;

namespace BiblioTech.Models
{
    public class Multa
    {
        private int           _id;
        private double        _monto;
        private EstadoMulta   _estado; 
        private DateTime      _fechaGeneracion;
        private DateTime      _fechaPago;
        private string        _nombreUsuario;   
        private string        _tituloLibro;     
        private int           _idPrestamo;      
        private int           _diasMora;        
        private string        _motivo;          

        
        public Multa()
        {
            _nombreUsuario = "";
            _tituloLibro   = "";
            _motivo        = "";
        }

        // Constructor para multas generadas manualmente 
        public Multa(int id, double monto)
        {
            _id              = id;
            _monto           = monto;
            _estado          = EstadoMulta.Pendiente;
            _fechaGeneracion = DateTime.Now;
            _nombreUsuario   = "";
            _tituloLibro     = "";
            _motivo          = "Multa manual";
        }

        // Constructor completo para multas generadas por préstamos vencidos
        public Multa(int id, double monto, string nombreUsuario, string tituloLibro,
                     int idPrestamo, int diasMora)
        {
            _id              = id;
            _monto           = monto;
            _estado          = EstadoMulta.Pendiente;
            _fechaGeneracion = DateTime.Now;
            _nombreUsuario   = nombreUsuario ?? "";
            _tituloLibro     = tituloLibro   ?? "";
            _idPrestamo      = idPrestamo;
            _diasMora        = diasMora;
            _motivo          = "Devolucion tardía: " + diasMora + " día(s) de retraso";
        }

        //  Propiedades 
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public double Monto
        {
            get { return _monto; }
            set { if (value > 0) _monto = value; }
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

        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value ?? ""; }
        }

        public string TituloLibro
        {
            get { return _tituloLibro; }
            set { _tituloLibro = value ?? ""; }
        }

        public int IdPrestamo
        {
            get { return _idPrestamo; }
            set { _idPrestamo = value; }
        }

        public int DiasMora
        {
            get { return _diasMora; }
            set { _diasMora = value; }
        }

        public string Motivo
        {
            get { return _motivo; }
            set { _motivo = value ?? ""; }
        }

        // Métodos
        public void Pagar()
        {
            _estado    = EstadoMulta.Pagada;
            _fechaPago = DateTime.Now;
        }

        public bool EstaPendiente()
        {
            return _estado == EstadoMulta.Pendiente;
        }
    }
}
