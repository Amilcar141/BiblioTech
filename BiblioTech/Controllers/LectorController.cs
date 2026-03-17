using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Models;

namespace BiblioTech.Controllers
{
    public class LectorController
    {
        private List<Lector> _lectores;

        public LectorController()
        {
            _lectores = new List<Lector>();
        }

        // Registra un nuevo lector
        public bool RegistrarLector(string nombre, string correo, string password)
        {
            foreach (Lector l in _lectores)
            {
                if (l.Correo == correo)
                {
                    return false;
                }
            }

            Lector lector = new Lector(nombre, correo, password, true);
            _lectores.Add(lector);
            return true;
        }

        // Obtiene un lector por ID
        public Lector ObtenerLector(string id)
        {
            foreach (Lector l in _lectores)
            {
                if (l.NumeroCuenta == id)
                {
                    return l;
                }
            }

            return null;
        }

        // Obtiene un lector por correo
        public Lector ObtenerLectorPorCorreo(string correo)
        {
            foreach (Lector l in _lectores)
            {
                if (l.Correo == correo)
                {
                    return l;
                }
            }

            return null;
        }

        // Obtiene todos los lectores
        public List<Lector> ObtenerTodosLectores()
        {
            return _lectores;
        }

        // Obtiene todos los lectores activos
        public List<Lector> ObtenerLectoresActivos()
        {
            List<Lector> lectoresActivos = new List<Lector>();

            foreach (Lector l in _lectores)
            {
                if (l.Activo == true)
                {
                    lectoresActivos.Add(l);
                }
            }

            return lectoresActivos;
        }

        // Actualiza los datos de un lector
        public bool ActualizarLector(string id, string nombre, string correo, string password)
        {
            Lector lector = ObtenerLector(id);

            if (lector == null)
                return false;

            foreach (Lector l in _lectores)
            {
                if (l.Correo == correo && l.NumeroCuenta != id)
                {
                    return false;
                }
            }

            lector.Nombre = nombre;
            lector.Correo = correo;
            lector.Password = password;
            return true;
        }

        // Desactiva un lector
        public bool DesactivarLector(string id)
        {
            Lector lector = ObtenerLector(id);

            if (lector == null)
                return false;

            lector.Activo = false;
            return true;
        }

        // Activa un lector
        public bool ActivarLector(string id)
        {
            Lector lector = ObtenerLector(id);

            if (lector == null)
                return false;

            lector.Activo = true;
            return true;
        }

        // Elimina un lector
        public bool EliminarLector(string id)
        {
            Lector lector = ObtenerLector(id);

            if (lector == null)
                return false;

            _lectores.Remove(lector);
            return true;
        }

        // Aplica una restricción a un lector
        public bool RestringirLector(string id, int dias)
        {
            Lector lector = ObtenerLector(id);

            if (lector == null)
                return false;

            lector.AplicarRestriccion(dias);
            return true;
        }

        // Remueve la restricción de un lector
        public bool RemoverRestriccionLector(string id)
        {
            Lector lector = ObtenerLector(id);

            if (lector == null)
                return false;

            lector.RemoverRestriccion();
            return true;
        }

        // Obtiene el total de lectores registrados
        public int ObtenerTotalLectores()
        {
            return _lectores.Count;
        }
    }
}
