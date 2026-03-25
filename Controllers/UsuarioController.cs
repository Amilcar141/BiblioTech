using System;
using System.Collections.Generic;
using System.Linq;
using BiblioTech.Models;
using BiblioTech.Models.Enums;

namespace BiblioTech.Controllers
{
    public class UsuarioController
    {
        // Instancia del SistemaLibreria para el manejo de datos
        private SistemaLibreria _sistema;

        // Constructor
        public UsuarioController(SistemaLibreria sistema)
        {
            _sistema = sistema;
        }

        // Métodos principales

        // Obtener todos los lectores
        public List<Lector> ObtenerTodosLectores()
        {
            return _sistema.Lectores;
        }

        // Registrar un nuevo lector
        public bool RegistrarLector(string nombre, string correo, string password, bool activo = true)
        {
            // Verificar correo duplicado
            if (ExisteCorreoLector(correo))
                return false;

            Lector nuevoLector = new Lector(nombre, correo, password, activo);
            _sistema.Lectores.Add(nuevoLector);
            
            return true;
        }

        // Autenticar un lector
        public Lector AutenticarLector(string correo, string password)
        {
            return ObtenerTodosLectores()
                .FirstOrDefault(l => l.Correo.ToLower() == correo.ToLower() && l.Password == password && l.Activo);
        }

        // Actualizar lector
        public bool ActualizarLector(string cuenta, string nombre, string correo, string password)
        {
            Lector lector = ObtenerLectorPorCuenta(cuenta);
            
            if (lector == null)
                return false;

            // Verificar que el correo no lo use otro lector
            if (ObtenerTodosLectores().Any(l => l.Cuenta != cuenta && l.Correo.ToLower() == correo.ToLower()))
                return false;

            lector.Nombre = nombre;
            lector.Correo = correo;
            lector.Password = password;
            
            return true;
        }

        // Desactivar lector
        public bool DesactivarLector(string cuenta)
        {
            Lector lector = ObtenerLectorPorCuenta(cuenta);
            
            if (lector == null)
                return false;

            lector.Activo = false;
            return true;
        }

        // Activar lector
        public bool ActivarLector(string cuenta)
        {
            Lector lector = ObtenerLectorPorCuenta(cuenta);
            
            if (lector == null)
                return false;

            lector.Activo = true;
            return true;
        }

        // Eliminar lector
        public bool EliminarLector(string cuenta)
        {
            Lector lector = ObtenerLectorPorCuenta(cuenta);
            
            if (lector == null)
                return false;

            _sistema.Lectores.Remove(lector);
            return true;
        }

        // Métodos de búsqueda y filtrado

        // Obtener lector por cuenta
        public Lector ObtenerLectorPorCuenta(string cuenta)
        {
            if (string.IsNullOrWhiteSpace(cuenta))
                return null;

            return ObtenerTodosLectores()
                .FirstOrDefault(l => l.Cuenta == cuenta);
        }

        // Obtener lector por correo
        public Lector ObtenerLectorPorCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
                return null;

            return ObtenerTodosLectores()
                .FirstOrDefault(l => l.Correo.ToLower() == correo.ToLower());
        }

        // Obtener lectores activos
        public List<Lector> ObtenerLectoresActivos()
        {
            return ObtenerTodosLectores()
                .Where(l => l.Activo)
                .ToList();
        }

        // Obtener lectores inactivos
        public List<Lector> ObtenerLectoresInactivos()
        {
            return ObtenerTodosLectores()
                .Where(l => !l.Activo)
                .ToList();
        }

        // Otros métodos

        // Verificar si existe un correo
        private bool ExisteCorreoLector(string correo)
        {
            return ObtenerTodosLectores()
                .Any(l => l.Correo.ToLower() == correo.ToLower());
        }

        // Obtener total de lectores
        public int ObtenerTotal()
        {
            return ObtenerTodosLectores().Count;
        }

        // Obtener total de lectores activos
        public int ObtenerTotalActivos()
        {
            return ObtenerLectoresActivos().Count;
        }

        // Búsqueda de lectores
        public List<Lector> Buscar(string termino)
        {
            if (string.IsNullOrWhiteSpace(termino))
                return ObtenerTodosLectores();

            termino = termino.ToLower();

            return ObtenerTodosLectores()
                .Where(l => 
                    l.Nombre.ToLower().Contains(termino) ||
                    l.Correo.ToLower().Contains(termino) ||
                    l.Cuenta.ToLower().Contains(termino))
                .ToList();
        }
    }
}
