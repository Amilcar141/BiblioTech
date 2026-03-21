using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTech.Models;
using System.Collections.Generic;

 

namespace BiblioTech.Controllers
{
    internal class FavoritoController
    {
        private List<Favorito> lista = new List<Favorito>();

        public List<Favorito> ObtenerFavoritos()
        {
            return lista;
        }

        public bool Agregar(Favorito f, out string mensaje)
        {
            mensaje = "";

            // Validar ISBN 
            if (f.ISBN <= 0)
            {
                mensaje = "Debe ingresar un ISBN válido (número mayor que cero).";
                return false;
            }

            // Validar alias
            if (string.IsNullOrWhiteSpace(f.AliasUsuario) || f.AliasUsuario.Length < 3)
            {
                mensaje = "El alias de usuario no puede estar vacío y debe tener al menos 3 caracteres.";
                return false;
            }

            // Validar título
            if (string.IsNullOrWhiteSpace(f.Titulo))
            {
                mensaje = "El título no puede estar vacío.";
                return false;
            }

            // Validar autor
            if (string.IsNullOrWhiteSpace(f.Autor))
            {
                mensaje = "El autor no puede estar vacío.";
                return false;
            }

            // Validar género
            if (string.IsNullOrWhiteSpace(f.genero))
            {
                mensaje = "El género no puede estar vacío.";
                return false;
            }

            // Validar fecha
            DateTime fecha;
            if (!DateTime.TryParse(f.Anio, out fecha))
            {
                mensaje = "La fecha ingresada no es válida.";
                return false;
            }
            if (fecha > DateTime.Now)
            {
                mensaje = "La fecha no puede ser futura.";
                return false;
            }

            
            lista.Add(f);
            mensaje = "Favorito agregado correctamente.";
            return true;
        }

        public void Eliminar(int id)
        {
            lista.RemoveAll(x => x.idFavorito == id);
        }
    }
}

