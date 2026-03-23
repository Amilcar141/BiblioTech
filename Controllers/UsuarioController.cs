using System;
using System.Collections.Generic;
using BiblioTech.Models;
using BiblioTech.Models.Enums;

namespace BiblioTech.Controllers
{
    public class UsuarioController//6
    { 
        // ESTÁTICA: todos los formularios comparten la misma lista
        private static List<Usuario> _usuarios = new List<Usuario>();
        private static int _nextId = 1;

        public UsuarioController() { }

        // Registra un nuevo usuario
        public bool RegistrarUsuario(int id, string nombre, string correo, string password, Rol rol)
        {
            // Verificar correo duplicado
            foreach (Usuario u in _usuarios)
            {
                if (u.Correo.ToLower() == correo.ToLower())
                    return false;
            }

            Usuario nuevo = new Usuario();
            nuevo.Id       = _nextId++;
            nuevo.Nombre   = nombre;
            nuevo.Correo   = correo;
            nuevo.Password = password;
            nuevo.Rol      = rol;
            nuevo.Activo   = true;

            _usuarios.Add(nuevo);
            return true;
        }

        // Autentica un usuario
        public Usuario Autenticar(string correo, string password)
        {
            foreach (Usuario u in _usuarios)
            {
                if (u.Correo.ToLower() == correo.ToLower() && u.Password == password)
                    return u;
            }
            return null;
        }

        // Obtiene un usuario por ID
        public Usuario ObtenerUsuario(int id)
        {
            foreach (Usuario u in _usuarios)
                if (u.Id == id) return u;
            return null;
        }

        // Obtiene un usuario por correo
        public Usuario ObtenerUsuarioPorCorreo(string correo)
        {
            foreach (Usuario u in _usuarios)
                if (u.Correo.ToLower() == correo.ToLower()) return u;
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
            List<Usuario> activos = new List<Usuario>();
            foreach (Usuario u in _usuarios)
                if (u.Activo) activos.Add(u);
            return activos;
        }

        // Actualiza los datos de un usuario
        
        public bool ActualizarUsuario(int id, string nombre, string correo, string password)
        {
            Usuario usuario = ObtenerUsuario(id);
            if (usuario == null) return false;

            // Verificar que el correo no lo use OTRO usuario
            foreach (Usuario u in _usuarios)
            {
                if (u.Id != id && u.Correo.ToLower() == correo.ToLower())
                    return false;
            }

            usuario.Nombre   = nombre;
            usuario.Correo   = correo;
            usuario.Password = password;
            return true;
        }

        // Activa / Desactiva un usuario
        public bool DesactivarUsuario(int id)
        {
            Usuario u = ObtenerUsuario(id);
            if (u == null) return false;
            u.Activo = false;
            return true;
        }

        public bool ActivarUsuario(int id)
        {
            Usuario u = ObtenerUsuario(id);
            if (u == null) return false;
            u.Activo = true;
            return true;
        }

        // Elimina un usuario
        public bool EliminarUsuario(int id)
        {
            Usuario u = ObtenerUsuario(id);
            if (u == null) return false;
            _usuarios.Remove(u);
            return true;
        }

        public int ObtenerTotalUsuarios() { return _usuarios.Count; }
    }
}
