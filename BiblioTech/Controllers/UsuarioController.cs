using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Models;
using BiblioTech.Models.Enums;

namespace BiblioTech.Controllers
{
    public class UsuarioController
    {
        private List<Usuario> _usuarios;

        public UsuarioController()
        {
            _usuarios = new List<Usuario>();
        }

        // Registra un nuevo usuario
        public bool RegistrarUsuario(string nombre, string correo, string password, Rol rol)
        {
            Usuario usuario = new Usuario();

            usuario.Nombre = nombre;
            usuario.Correo = correo;
            usuario.Password = password;
            usuario.Rol = rol;
            usuario.Activo = true;

            _usuarios.Add(usuario);
            return true;
        }

        // Autentica un usuario
        public Usuario Autenticar(string correo, string password)
        {
            foreach (Usuario usuario in _usuarios)
            {
                if (usuario.Correo == correo)
                {
                    if (usuario.Autenticar(correo, password))
                    {
                        return usuario;
                    }
                }
            }

            return null;
        }

        // Obtiene un usuario por ID
        public Usuario ObtenerUsuario(string cuenta)
        {
            foreach (Usuario u in _usuarios)
            {
                if (u.NumeroCuenta == cuenta)
                {
                    return u;
                }
            }

            return null;
        }

        // Obtiene un usuario por correo
        public Usuario ObtenerUsuarioPorCorreo(string correo)
        {
            foreach (Usuario u in _usuarios)
            {
                if (u.Correo == correo)
                {
                    return u;
                }
            }

            return null;
        }

        // Obtiene todos los usuarios
        public List<Usuario> ObtenerTodosUsuarios()
        {
            return _usuarios;
        }

        // Obtiene todos los usuarios activos
        public List<Usuario> ObtenerUsuariosActivos()
        {
            List<Usuario> usuariosActivos = new List<Usuario>();

            foreach (Usuario u in _usuarios)
            {
                if (u.Activo == true)
                {
                    usuariosActivos.Add(u);
                }
            }

            return usuariosActivos;
        }

        // Actualiza los datos de un usuario
        public bool ActualizarUsuario(string cuenta, string nombre, 
            string correo, string password)
        {
            Usuario usuario = ObtenerUsuario(cuenta);

            if (usuario == null)
                return false;

            foreach (Usuario u in _usuarios)
            {
                if (u.Correo == correo)
                {
                    return false;
                }
            }

            usuario.Nombre = nombre;
            usuario.Correo = correo;
            usuario.Password = password;
            return true;
        }

        // Desactiva un usuario
        public bool DesactivarUsuario(string cuenta)
        {
            Usuario usuario = ObtenerUsuario(cuenta);

            if (usuario == null)
                return false;

            usuario.Activo = false;
            return true;
        }

        // Activa un usuario
        public bool ActivarUsuario(string cuenta)
        {
            Usuario usuario = ObtenerUsuario(cuenta);

            if (usuario == null)
                return false;

            usuario.Activo = true;
            return true;
        }

        // Elimina un usuario
        public bool EliminarUsuario(string cuenta)
        {
            Usuario usuario = ObtenerUsuario(cuenta);

            if (usuario == null)
                return false;

            _usuarios.Remove(usuario);
            return true;
        }

        // Obtiene el total de usuarios registrados
        public int ObtenerTotalUsuarios()
        {
            return _usuarios.Count;
        }
    }
}
