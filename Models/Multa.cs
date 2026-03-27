using BiblioTech.Models.Enums;
using System;

namespace BiblioTech.Models
{
    /// <summary>
    /// Representa una multa del sistema.
    /// Mapea la tabla Multas junto con EstadoMulta y TipoMulta de la BD.
    /// </summary>
    public class Multa //7
    {
        // ── Campos privados ────────────────────────────────────────────
        private int _id;
        private int _idEstadoMulta;   // FK → EstadoMulta
        private int _idTipoMulta;     // FK → TipoMulta (1=RETRASO,2=DETERIORO,3=PERDIDA)
        private int _idLector;        // FK → Lectores
        private int _idPrestamo;      // FK → Prestamos (nullable)
        private string _codigoMulta;
        private double _monto;
        private string _descripcion;
        private EstadoMulta _estado;
        private DateTime _fechaGeneracion;
        private DateTime _fechaPago;
        private DateTime _createdAt;
        private DateTime _deletedAt;

        // Campos resumen (cargados por JOIN en el controller, no columnas directas)
        private string _nombreUsuario;
        private string _tituloLibro;
        private int _diasMora;
        private string _motivo;          // alias amigable de _descripcion

        // ── Constructores ──────────────────────────────────────────────
        public Multa()
        {
            _codigoMulta = "";
            _nombreUsuario = "";
            _tituloLibro = "";
            _descripcion = "";
            _motivo = "";
            _idTipoMulta = 1; // RETRASO por defecto
        }

        /// <summary>Constructor para multa manual (desde formulario).</summary>
        public Multa(int id, double monto)
        {
            _id = id;
            _monto = monto;
            _idEstadoMulta = 1;  // PENDIENTE
            _idTipoMulta = 1;  // RETRASO
            _estado = EstadoMulta.Pendiente;
            _fechaGeneracion = DateTime.Now;
            _codigoMulta = "";
            _nombreUsuario = "";
            _tituloLibro = "";
            _descripcion = "Multa manual";
            _motivo = "Multa manual";
        }

        /// <summary>Constructor completo para multas generadas por préstamo vencido.</summary>
        public Multa(int id, double monto, string nombreUsuario, string tituloLibro,
                     int idPrestamo, int diasMora)
        {
            _id = id;
            _monto = monto;
            _idEstadoMulta = 1;  // PENDIENTE
            _idTipoMulta = 1;  // RETRASO
            _estado = EstadoMulta.Pendiente;
            _fechaGeneracion = DateTime.Now;
            _nombreUsuario = nombreUsuario ?? "";
            _tituloLibro = tituloLibro ?? "";
            _idPrestamo = idPrestamo;
            _diasMora = diasMora;
            _codigoMulta = "";
            _descripcion = "Devolucion tardía: " + diasMora + " día(s) de retraso";
            _motivo = _descripcion;
        }

        // ── Propiedades — columnas de la tabla Multas ──────────────────
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int IdEstadoMulta
        {
            get { return _idEstadoMulta; }
            set
            {
                _idEstadoMulta = value;
                _estado = value == 1 ? EstadoMulta.Pendiente : EstadoMulta.Pagada;
            }
        }

        public int IdTipoMulta
        {
            get { return _idTipoMulta; }
            set { _idTipoMulta = value; }
        }

        public int IdLector
        {
            get { return _idLector; }
            set { _idLector = value; }
        }

        public int IdPrestamo
        {
            get { return _idPrestamo; }
            set { _idPrestamo = value; }
        }

        public string CodigoMulta
        {
            get { return _codigoMulta; }
            set { _codigoMulta = value ?? ""; }
        }

        public double Monto
        {
            get { return _monto; }
            set { if (value >= 0) _monto = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value ?? ""; _motivo = _descripcion; }
        }

        public EstadoMulta Estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
                _idEstadoMulta = value == EstadoMulta.Pendiente ? 1 : 2;
            }
        }

        public DateTime FechaGeneracion
        {
            get { return _fechaGeneracion; }
            set { _fechaGeneracion = value; }
        }

        public DateTime FechaPago
        {
            get { return _fechaPago; }
            set { _fechaPago = value; }
        }

        public DateTime CreatedAt { get { return _createdAt; } set { _createdAt = value; } }
        public DateTime DeletedAt { get { return _deletedAt; } set { _deletedAt = value; } }

        // ── Propiedades auxiliares (cargadas por JOIN) ─────────────────
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

        public int DiasMora
        {
            get { return _diasMora; }
            set { _diasMora = value; }
        }

        // Alias amigable de Descripcion (compatibilidad con vistas existentes)
        public string Motivo
        {
            get { return _motivo; }
            set { _motivo = value ?? ""; _descripcion = _motivo; }
        }

        // ── Métodos de negocio ─────────────────────────────────────────
        public void Pagar()
        {
            _estado = EstadoMulta.Pagada;
            _idEstadoMulta = 2;
            _fechaPago = DateTime.Now;
        }

        public bool EstaPendiente()
        {
            return _estado == EstadoMulta.Pendiente;
        }
    }
}