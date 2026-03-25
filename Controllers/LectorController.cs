using System;
using System.Collections.Generic;
using System.Linq;
using BiblioTech.Models;

namespace BiblioTech.Controllers
{
    public class LectorController
    {
        // Instancia del SistemaLibreria para el manejo de datos
        private SistemaLibreria _sistema;

        // Constructor
        public LectorController(SistemaLibreria sistema)
        {
            _sistema = sistema;
        }

        // Métodos principales

        // Obtener todos los lectores
        public List<Lector> ObtenerTodos()
        {
            return _sistema.Lectores;
        }

        // Agregar un nuevo lector
        public bool AgregarLector(Lector lector)
        {
            // Verificar correo duplicado
            if (ExisteCorreo(lector.Correo))
                return false;

            _sistema.Lectores.Add(lector);
            return true;
        }

        // Editar un lector
        public bool EditarLector(Lector lector)
        {
            // Verificar que el correo no lo use otro lector
            if (ObtenerTodos().Any(l => l.Cuenta != lector.Cuenta && l.Correo.ToLower() == lector.Correo.ToLower()))
                return false;

            Lector lectorExistente = ObtenerPorCuenta(lector.Cuenta);
            
            if (lectorExistente == null)
                return false;

            lectorExistente.Nombre = lector.Nombre;
            lectorExistente.Correo = lector.Correo;
            lectorExistente.Password = lector.Password;
            lectorExistente.Activo = lector.Activo;
            lectorExistente.MaxPrestamos = lector.MaxPrestamos;
            lectorExistente.DiasPrestamo = lector.DiasPrestamo;

            return true;
        }

        // Eliminar un lector por cuenta
        public bool EliminarLector(string cuenta)
        {
            if (ExisteCuenta(cuenta))
            {
                Lector lectorAEliminar = ObtenerPorCuenta(cuenta);
                _sistema.Lectores.Remove(lectorAEliminar);
                return true;
            }
            return false;
        }

        // Métodos de búsqueda

        // Obtener un lector por cuenta
        public Lector ObtenerPorCuenta(string cuenta)
        {
            foreach (Lector lector in ObtenerTodos())
            {
                if (lector.Cuenta == cuenta)
                    return lector;
            }
            return null;
        }

        // Obtener un lector por correo
        public Lector ObtenerPorCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
                return null;

            foreach (Lector lector in ObtenerTodos())
            {
                if (lector.Correo.ToLower() == correo.ToLower())
                    return lector;
            }
            return null;
        }

        // Obtener lectores activos
        public List<Lector> ObtenerActivos()
        {
            return ObtenerTodos()
                .Where(l => l.Activo)
                .ToList();
        }

        // Obtener lectores inactivos
        public List<Lector> ObtenerInactivos()
        {
            return ObtenerTodos()
                .Where(l => !l.Activo)
                .ToList();
        }

        // Validar si existe un correo
        private bool ExisteCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
                return false;

            foreach (Lector lector in ObtenerTodos())
            {
                if (lector.Correo.ToLower() == correo.ToLower())
                    return true;
            }
            return false;
        }

        // Validar si existe una cuenta
        private bool ExisteCuenta(string cuenta)
        {
            if (string.IsNullOrWhiteSpace(cuenta))
                return false;

            foreach (Lector lector in ObtenerTodos())
            {
                if (lector.Cuenta == cuenta)
                    return true;
            }
            return false;
        }

        // Otros métodos

        // Obtener cantidad total de lectores
        public int ObtenerTotal()
        {
            return ObtenerTodos().Count;
        }

        // Obtener cantidad de lectores activos
        public int ObtenerTotalActivos()
        {
            return ObtenerActivos().Count;
        }

        // Obtener cantidad de lectores inactivos
        public int ObtenerTotalInactivos()
        {
            return ObtenerInactivos().Count;
        }

        // Buscar lectores por término (nombre, correo o cuenta)
        public List<Lector> Buscar(string termino)
        {
            if (string.IsNullOrWhiteSpace(termino))
                return ObtenerTodos();

            termino = termino.Trim().ToLower();

            return ObtenerTodos()
                .Where(l =>
                    l.Nombre.ToLower().Contains(termino) ||
                    l.Correo.ToLower().Contains(termino) ||
                    l.Cuenta.ToLower().Contains(termino))
                .ToList();
        }

        // Activar un lector
        public bool ActivarLector(string cuenta)
        {
            Lector lector = ObtenerPorCuenta(cuenta);
            
            if (lector == null)
                return false;

            lector.Activo = true;
            return true;
        }

        // Desactivar un lector
        public bool DesactivarLector(string cuenta)
        {
            Lector lector = ObtenerPorCuenta(cuenta);
            
            if (lector == null)
                return false;

            lector.Activo = false;
            return true;
        }

        // Obtener lectores con restricción activa
        public List<Lector> ObtenerLectoresConRestriccion()
        {
            return ObtenerTodos()
                .Where(l => l.RestriccionActiva)
                .ToList();
        }

        // Obtener lectores sin restricción
        public List<Lector> ObtenerLectoresSinRestriccion()
        {
            return ObtenerTodos()
                .Where(l => !l.RestriccionActiva)
                .ToList();
        }
    }
}
