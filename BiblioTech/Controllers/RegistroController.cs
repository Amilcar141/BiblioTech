using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Models;

namespace BiblioTech.Controllers
{
    public class RegistroController
    {
        private readonly List <Usuario> _usuarios;

        public RegistroController(List<Usuario> usuarios) 
        {
            _usuarios = usuarios;
        }

       
    public bool ValidarCredenciales(string Cuenta, string Contrasenia)
    {
        return _usuarios.Exists(u =>
            u.Cuenta == Cuenta &&
            u.Contrasenia == Contrasenia);
    }


        public bool CuentaExiste(string Cuenta)
        {
            return _usuarios.Exists(u => u.Cuenta == Cuenta);
        }
        public bool Registrar(string Nombres, string Apellidos,
                              string Cuenta, string Correo,
                              string Rol, string Contrasenia)
        {
            if (CuentaExiste(Cuenta))
                return false; //Indicaría que intenta duplicar una cuenta existente.
            _usuarios.Add(new Usuario(
                Cuenta, Contrasenia, Nombres, Apellidos, Correo, Rol));

            return true;
        }
    }
}

