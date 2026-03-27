using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;

namespace BiblioTech.Models
{
    /// <summary>
    /// Representa a un usuario del sistema.
    /// Mapea la tabla UsuarioBase (+ Lectores / Administradores según rol).
    /// Los campos extra de Lector/Administrador se cargan cuando aplican.
    /// </summary>
    public class Usuario //7
    {
        // ── Campos privados ────────────────────────────────────────────
        private int _id;
        private int _idRol;
        private string _numeroCuenta;
        private string _nombre;
        private string _correo;
        private string _password;
        private Rol _rol;
        private bool _activo;
        private DateTime _createdAt;
        private DateTime _deletedAt;

        // Campos extra de la tabla Lectores
        private int _maxPrestamosSimultaneos;
        private int _diasPrestamo;
        private bool _restriccionActiva;
        private DateTime _fechaRestriccion;

        // Campos extra de la tabla Administradores
        private int _nivelAcceso;
        private DateTime _fechaAsignacion;

        // Historial en memoria (no persiste aquí, lo gestiona PrestamoController)
        private List<Prestamo> _historialPrestamos;

        // ── Constructores ──────────────────────────────────────────────
        public Usuario()
        {
            _numeroCuenta = "";
            _nombre = "";
            _correo = "";
            _password = "";
            _historialPrestamos = new List<Prestamo>();
        }

        public Usuario(int id, string nombre, string correo, string password, Rol rol, bool activo)
        {
            _id = id;
            _nombre = nombre;
            _correo = correo;
            _password = password;
            _rol = rol;
            _activo = activo;
            _numeroCuenta = "";
            _historialPrestamos = new List<Prestamo>();
        }

        // ── Propiedades — tabla UsuarioBase ────────────────────────────
        public int Id { get { return _id; } set { _id = value; } }
        public int IdRol { get { return _idRol; } set { _idRol = value; } }
        public string NumeroCuenta { get { return _numeroCuenta; } set { _numeroCuenta = value ?? ""; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Correo { get { return _correo; } set { _correo = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public Rol Rol { get { return _rol; } set { _rol = value; _idRol = (int)value + 1; } }
        public bool Activo { get { return _activo; } set { _activo = value; } }
        public DateTime CreatedAt { get { return _createdAt; } set { _createdAt = value; } }
        public DateTime DeletedAt { get { return _deletedAt; } set { _deletedAt = value; } }

        // ── Propiedades — tabla Lectores ───────────────────────────────
        public int MaxPrestamosSimultaneos { get { return _maxPrestamosSimultaneos; } set { _maxPrestamosSimultaneos = value; } }
        public int DiasPrestamo { get { return _diasPrestamo; } set { _diasPrestamo = value; } }
        public bool RestriccionActiva { get { return _restriccionActiva; } set { _restriccionActiva = value; } }
        public DateTime FechaRestriccion { get { return _fechaRestriccion; } set { _fechaRestriccion = value; } }

        // ── Propiedades — tabla Administradores ────────────────────────
        public int NivelAcceso { get { return _nivelAcceso; } set { _nivelAcceso = value; } }
        public DateTime FechaAsignacion { get { return _fechaAsignacion; } set { _fechaAsignacion = value; } }

        // Historial en memoria
        public List<Prestamo> HistorialPrestamos
        {
            get { return _historialPrestamos; }
            set { _historialPrestamos = value; }
        }

        // ── Métodos de negocio ─────────────────────────────────────────
        public bool Autenticar(string correo, string password)
        {
            return _correo == correo && _password == password;
        }

        public bool TienePrestamosActivos()
        {
            foreach (Prestamo p in _historialPrestamos)
                if (p.Estado == EstadoPrestamo.Activo) return true;
            return false;
        }

        public bool PuedeRealizarPrestamo()
        {
            return _activo && !_restriccionActiva;
        }
    }
}
