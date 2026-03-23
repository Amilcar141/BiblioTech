using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;

namespace BiblioTech.Models
{
    public class Administrador : Usuario
    {
        // Atributos específicos del administrador
        private int _nivelAcceso;
        private string _departamento;
        private DateTime _fechaAsignacion;
        private List<string> _actividadesRegistradas;

        // Constructores
        public Administrador() : base()
        {
            _nivelAcceso = 1;
            _departamento = string.Empty;
            _fechaAsignacion = DateTime.Now;
            _actividadesRegistradas = new List<string>();
        }

        public Administrador(string nombre, string correo, string password, bool activo,
            int nivelAcceso, string departamento)
            : base(nombre, correo, password, Rol.Administrador, activo)
        {
            _nivelAcceso = nivelAcceso;
            _departamento = departamento;
            _fechaAsignacion = DateTime.Now;
            _actividadesRegistradas = new List<string>();
        }

        // Propiedades
        public int NivelAcceso
        {
            get { return _nivelAcceso; }
            set { _nivelAcceso = value; }
        }

        public string Departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

        public DateTime FechaAsignacion
        {
            get { return _fechaAsignacion; }
            set { _fechaAsignacion = value; }
        }

        public List<string> ActividadesRegistradas
        {
            get { return _actividadesRegistradas; }
            set
            {
                if (value != null)
                    _actividadesRegistradas = value;
            }
        }

        // Métodos específicos del administrador

        // Obtiene el historial de actividades del administrador
        public List<string> GetActividadesRegistradas()
        {
            return _actividadesRegistradas;
        }

        // Registra una actividad del administrador
        public void RegistrarActividad(string actividad)
        {
            string registro = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + actividad;
            _actividadesRegistradas.Add(registro);
        }

        // Verifica si el administrador tiene permiso para una acción específica
        public bool TienePermiso(string accion)
        {
            if (_nivelAcceso < 1 || _nivelAcceso > 5)
                return false;

            // Permisos según nivel de acceso
            // Nivel 1: Solo lectura
            // Nivel 2: Gestión de lectores
            // Nivel 3: Gestión de préstamos y multas
            // Nivel 4: Gestión de inventario
            // Nivel 5: Control total

            if (accion.ToLower() == "leer")
                return _nivelAcceso >= 1;

            if (accion.ToLower() == "crear lector" || accion.ToLower() == "editar lector" || accion.ToLower() == "eliminar lector")
                return _nivelAcceso >= 2;

            if (accion.ToLower() == "crear prestamo" || accion.ToLower() == "editar prestamo" || accion.ToLower() == "crear multa")
                return _nivelAcceso >= 3;

            if (accion.ToLower() == "gestionar inventario")
                return _nivelAcceso >= 4;

            if (accion.ToLower() == "control total")
                return _nivelAcceso >= 5;

            return false;
        }

        // Cambia el nivel de acceso del administrador
        public void CambiarNivelAcceso(int nuevoNivel)
        {
            if (nuevoNivel >= 1 && nuevoNivel <= 5)
            {
                _nivelAcceso = nuevoNivel;
                RegistrarActividad("Nivel de acceso cambiado a " + nuevoNivel);
            }
        }
    }
}