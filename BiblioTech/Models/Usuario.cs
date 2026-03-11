using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    internal class Usuario
    {
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }


        public Usuario()
        {

        }

        public Usuario(int idUsuario, string usuario, string password)
        {
            this.idUsuario = idUsuario;
            this.usuario = usuario;
            this.password = password;
        }
    }
}
