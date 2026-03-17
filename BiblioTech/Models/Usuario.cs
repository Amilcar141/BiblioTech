using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Usuario
    {
        // Atributos de la clase
        private int _id;
        private string _nombre;
        private string _correo;
        private string _password;
        private Rol _rol;
        private bool _activo;
        private List<Prestamo> _historialPrestamos;

        // Constructores
        public Usuario()
        {
        }

        public Usuario(int id, string nombre, string correo, string password, Rol rol, bool activo)
        {
            _id = id;
            _nombre = nombre;
            _correo = correo;
            _password = password;
            _rol = rol;
            _activo = activo;
            _historialPrestamos = new List<Prestamo>();
        }

        // Metodos get y set
        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        // Otros metodos adicionales
        public bool Autenticar(string correo, string password)
        {
            if (_correo == correo && _password == password)
                return true;
            else
                return false;
        }

        public List<Prestamo> GetPrestamosActivos()
        {
            return _historialPrestamos;
        }

        public bool TienePrestamosActivos()
        {
            foreach (Prestamo p in _historialPrestamos)
            {
                if (p.Estado == EstadoPrestamo.Activo)
                    return true;
            }

            return false;
        }

        public bool TienePrestamoPendiente()
        {
            foreach (Prestamo p in _historialPrestamos)
            {
                if (p.Multa.Estado == EstadoMulta.Pendiente)
                    return true;
            }

            return false;
        }

        public bool PuedeRealizarPrestamo()
        {
            if (_activo && !TienePrestamoPendiente())
                return true;
            return false;
        }
    }
}
