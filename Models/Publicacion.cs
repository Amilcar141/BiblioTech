using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Publicacion
    {
        private int _id;
        private string _codigo;
        private Libro _libro;
        private DateTime _fechaPublicacion;

        // ID autogenerado
        private static int _contadorId = 1;

        // Constructores
        public Publicacion() { }

        public Publicacion(Libro libro, DateTime fechaPublicacion)
        {
            _id = _contadorId++;
            _codigo = AsignarCodigo();
            _libro = libro;
            _fechaPublicacion = fechaPublicacion;
        }

        // Propiedades

        public string Codigo
        {
            get { return _codigo; }
            private set { _codigo = value; }
        }

        public Libro Libro
        {
            get { return _libro; }
            set { _libro = value; }
        }

        public DateTime FechaPublicacion
        {
            get { return _fechaPublicacion; }
            set { _fechaPublicacion = value; }
        }

        // Método privado para asignar código
        private string AsignarCodigo()
        {
            return "PUB" + _contadorId.ToString("D4");
        }
    }
}
