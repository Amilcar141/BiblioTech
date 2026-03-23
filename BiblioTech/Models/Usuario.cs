using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Usuario
    {        
        public string Cuenta { get; set; }
        public string Contrasenia { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }

        public Usuario()
        {

        }

        public Usuario(string Cuenta, string Contrasenia, 
            string Nombres = "", string Apellidos = "",
                       string Correo = "", string Rol = "Lector")

        {
            this.Cuenta = Cuenta;
            this.Contrasenia = Contrasenia;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Correo = Correo;
            this.Rol = Rol;
        }
    }
}
