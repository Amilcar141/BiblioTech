using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Models;

namespace BiblioTech.Controllers
{
    public class LoginController
    {
        public readonly List<Usuario> usuarios = new List<Usuario>
        {
        new Usuario("admin",     "1234"),
            };
                
        public bool ValidarCredenciales(string Cuenta, string Contrasenia)
        {
            return usuarios.Exists(u =>
                u.Cuenta == Cuenta &&
                u.Contrasenia == Contrasenia);

        }
    }
}
