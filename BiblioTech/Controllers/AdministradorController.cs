using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Models;

namespace BiblioTech.Controllers
{
    public class AdministradorController
    {
        private List<Administrador> _administradores;

        public AdministradorController()
        {
            _administradores = new List<Administrador>();
        }

        // Registra un nuevo administrador
        public bool RegistrarAdministrador(string nombre, string correo, string password, 
            int nivelAcceso, string departamento)
        {
            foreach (Administrador a in _administradores)
            {
                if (a.Correo == correo)
                {
                    return false;
                }
            }

            Administrador administrador = new Administrador(nombre, correo, password, true, nivelAcceso, departamento);
            _administradores.Add(administrador);
            return true;
        }

        // Obtiene un administrador por ID
        public Administrador ObtenerAdministrador(string id)
        {
            foreach (Administrador a in _administradores)
            {
                if (a.NumeroCuenta == id)
                {
                    return a;
                }
            }

            return null;
        }

        // Obtiene un administrador por correo
        public Administrador ObtenerAdministradorPorCorreo(string correo)
        {
            foreach (Administrador a in _administradores)
            {
                if (a.Correo == correo)
                {
                    return a;
                }
            }

            return null;
        }

        // Obtiene todos los administradores
        public List<Administrador> ObtenerTodosAdministradores()
        {
            return _administradores;
        }

        // Obtiene todos los administradores activos
        public List<Administrador> ObtenerAdministradoresActivos()
        {
            List<Administrador> administradoresActivos = new List<Administrador>();

            foreach (Administrador a in _administradores)
            {
                if (a.Activo == true)
                {
                    administradoresActivos.Add(a);
                }
            }

            return administradoresActivos;
        }

        // Actualiza los datos de un administrador
        public bool ActualizarAdministrador(string id, string nombre, string correo, string password)
        {
            Administrador administrador = ObtenerAdministrador(id);

            if (administrador == null)
                return false;

            foreach (Administrador a in _administradores)
            {
                if (a.Correo == correo && a.NumeroCuenta != id)
                {
                    return false;
                }
            }

            administrador.Nombre = nombre;
            administrador.Correo = correo;
            administrador.Password = password;
            administrador.RegistrarActividad("Datos actualizados");
            return true;
        }

        // Desactiva un administrador
        public bool DesactivarAdministrador(string id)
        {
            Administrador administrador = ObtenerAdministrador(id);

            if (administrador == null)
                return false;

            administrador.Activo = false;
            administrador.RegistrarActividad("Cuenta desactivada");
            return true;
        }

        // Activa un administrador
        public bool ActivarAdministrador(string id)
        {
            Administrador administrador = ObtenerAdministrador(id);

            if (administrador == null)
                return false;

            administrador.Activo = true;
            administrador.RegistrarActividad("Cuenta activada");
            return true;
        }

        // Elimina un administrador
        public bool EliminarAdministrador(string id)
        {
            Administrador administrador = ObtenerAdministrador(id);

            if (administrador == null)
                return false;

            _administradores.Remove(administrador);
            return true;
        }

        // Cambia el nivel de acceso de un administrador
        public bool CambiarNivelAcceso(string id, int nuevoNivel)
        {
            Administrador administrador = ObtenerAdministrador(id);

            if (administrador == null)
                return false;

            if (nuevoNivel < 1 || nuevoNivel > 5)
                return false;

            administrador.CambiarNivelAcceso(nuevoNivel);
            return true;
        }

        // Obtiene las actividades registradas de un administrador
        public List<string> ObtenerActividadesAdministrador(string id)
        {
            Administrador administrador = ObtenerAdministrador(id);

            if (administrador == null)
                return new List<string>();

            return administrador.GetActividadesRegistradas();
        }

        // Obtiene el total de administradores registrados
        public int ObtenerTotalAdministradores()
        {
            return _administradores.Count;
        }
    }
}
