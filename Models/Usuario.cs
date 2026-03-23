using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;

namespace BiblioTech.Models
{
    public abstract class Usuario
    {
        // Atributos de la clase
        private int _id;
        private string _cuenta;
        private string _nombre;
        private string _correo;
        private string _password;
        private Rol _rol;
        private bool _activo;
        private List<Prestamo> _historialPrestamos;

        // Contador para el manejo de los IDs
        private static int _contadorIds = 1;

        public Usuario() {}

        public Usuario(string nombre, string correo, string password, Rol rol, bool activo)
        {
            _id = _contadorIds++;
            _cuenta = AsignarCuenta();
            _nombre = nombre;
            _correo = correo;
            _password = password;
            _rol = rol;
            _activo = activo;
        }

        // Métodos getters y setters
        public string Cuenta
        {
            get { return _cuenta; }
            private set { _cuenta = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Correo
        {             
            get { return _correo; }
            set { _correo = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Rol Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public List<Prestamo> HistorialPrestamos
        {
            get { return _historialPrestamos; }
            set { _historialPrestamos = value; }
        }

        // Metodos
        private string AsignarCuenta()
        {
            if (_rol == Rol.Administrador)
                return $"ADM-{DateTime.Now.ToString("yy")}-{_id:D4}";

            return $"LEC-{DateTime.Now.ToString("yy")}-{_id:D4}";
        }

        protected bool Autenticar(string correo, string password)
        {
            return _correo == correo && _password == password;
        }

        public bool TienePrestamosActivos()
        {
            foreach (Prestamo p in _historialPrestamos)
                if (p.Estado == EstadoPrestamo.Activo) return true;
            return false;
        }
    }
}
