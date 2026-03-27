using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;

namespace BiblioTech.Models
{
    /// <summary>
    /// Representa un préstamo del sistema.
    /// Mapea la tabla Prestamos. Los objetos Lector, Libro y Administrador
    /// se cargan opcionalmente por JOIN en el controller.
    /// </summary>
    public class Prestamo //7
    {
        // ── Campos privados — columnas directas ────────────────────────
        private int _idPrestamo;
        private int _idEstadoPrestamo;   // FK → EstadoPrestamo
        private int _idEjemplar;         // FK → Ejemplares
        private int _idLector;           // FK → Lectores
        private int _idAdministrador;    // FK → Administradores (nullable)
        private string _codigoPrestamo;
        private DateTime _fechaInicio;
        private DateTime _fechaLimite;
        private DateTime _fechaDevolucion;
        private DateTime _createdAt;
        private DateTime _deletedAt;
        private EstadoPrestamo _estado;
        private decimal _tarifaDiaria = 5.00m;

        // Objetos relacionados (cargados por JOIN, no almacenados en BD)
        private Lector _lector;
        private Libro _libro;
        private Administrador _gestionadoPor;
        private Multa _multa;
        private List<Multa> _multas;

        // ── Constructores ──────────────────────────────────────────────
        public Prestamo()
        {
            _codigoPrestamo = "";
            _multas = new List<Multa>();
            _estado = EstadoPrestamo.Activo;
            _idEstadoPrestamo = 1;
        }

        public Prestamo(int idPrestamo, Lector lector, Libro libro,
                        DateTime fechaInicio, DateTime fechaLimite,
                        Administrador gestionadoPor)
        {
            _idPrestamo = idPrestamo;
            _lector = lector;
            _libro = libro;
            _fechaInicio = fechaInicio;
            _fechaLimite = fechaLimite;
            _gestionadoPor = gestionadoPor;
            _codigoPrestamo = "";
            _multas = new List<Multa>();
            _estado = EstadoPrestamo.Activo;
            _idEstadoPrestamo = 1;
        }

        // ── Propiedades — columnas de la tabla Prestamos ───────────────
        public int IdPrestamo
        {
            get { return _idPrestamo; }
            set { _idPrestamo = value; }
        }

        public int IdEstadoPrestamo
        {
            get { return _idEstadoPrestamo; }
            set
            {
                _idEstadoPrestamo = value;
                switch (value)
                {
                    case 1: _estado = EstadoPrestamo.Activo; break;
                    case 2: _estado = EstadoPrestamo.Devuelto; break;
                    case 3: _estado = EstadoPrestamo.Vencido; break;
                    default: _estado = EstadoPrestamo.Activo; break;
                }
            }
        }

        public int IdEjemplar
        {
            get { return _idEjemplar; }
            set { _idEjemplar = value; }
        }

        public int IdLector
        {
            get { return _idLector; }
            set { _idLector = value; }
        }

        public int IdAdministrador
        {
            get { return _idAdministrador; }
            set { _idAdministrador = value; }
        }

        public string CodigoPrestamo
        {
            get { return _codigoPrestamo; }
            set { _codigoPrestamo = value ?? ""; }
        }

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public DateTime FechaLimite
        {
            get { return _fechaLimite; }
            set { _fechaLimite = value; }
        }

        public DateTime FechaDevolucion
        {
            get { return _fechaDevolucion; }
            set { _fechaDevolucion = value; }
        }

        public DateTime CreatedAt { get { return _createdAt; } set { _createdAt = value; } }
        public DateTime DeletedAt { get { return _deletedAt; } set { _deletedAt = value; } }

        public EstadoPrestamo Estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
                switch (value)
                {
                    case EstadoPrestamo.Activo: _idEstadoPrestamo = 1; break;
                    case EstadoPrestamo.Devuelto: _idEstadoPrestamo = 2; break;
                    case EstadoPrestamo.Vencido: _idEstadoPrestamo = 3; break;
                }
            }
        }

        // ── Propiedades — objetos relacionados ─────────────────────────
        public Lector Lector { get { return _lector; } set { _lector = value; } }
        public Libro Libro { get { return _libro; } set { _libro = value; } }
        public Administrador GestionadoPor { get { return _gestionadoPor; } set { _gestionadoPor = value; } }
        public Multa Multa { get { return _multa; } set { _multa = value; } }
        public List<Multa> Multas { get { return _multas; } set { _multas = value; } }
        public decimal TarifaDiaria { get { return _tarifaDiaria; } set { _tarifaDiaria = value; } }

        // ── Métodos de negocio ─────────────────────────────────────────
        public bool EstaVencido()
        {
            return DateTime.Now > _fechaLimite;
        }

        public int ObtenerDiasDeRetraso()
        {
            if (!EstaVencido()) return 0;
            DateTime fechaComp = _fechaDevolucion != DateTime.MinValue
                ? _fechaDevolucion : DateTime.Now;
            TimeSpan dif = fechaComp - _fechaLimite;
            return (int)Math.Max(0, dif.TotalDays);
        }

        public decimal CalcularMulta()
        {
            return ObtenerDiasDeRetraso() * _tarifaDiaria;
        }

        public void RegistrarDevolucion(DateTime fechaDevolucion, Administrador administrador)
        {
            _fechaDevolucion = fechaDevolucion;
            _estado = EstadoPrestamo.Devuelto;
            _idEstadoPrestamo = 2;
            _gestionadoPor = administrador;

            int diasRetraso = ObtenerDiasDeRetraso();
            if (diasRetraso > 0)
            {
                Multa multa = new Multa();
                multa.Descripcion = "Devolucion tardía: " + diasRetraso + " día(s) de retraso";
                _multas.Add(multa);
                _multa = multa;
            }
        }
    }
}
