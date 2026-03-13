using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTech.Models;


namespace BiblioTech.Controllers
{
    internal class FavoritoController
    {

        private List<Favorito> lista = new List<Favorito>();

        public List<Favorito> ObtenerFavoritos()
        {
            return lista;
        }

        public void Agregar(Favorito f)
        {
            lista.Add(f);
        }

        public void Eliminar(int id)
        {
            lista.RemoveAll(x => x.idFavorito == id);
        }

    }
}
