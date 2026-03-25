using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Catalogo
    {
        // Atributos propios
        private int _id;
        private string _codigo;
        private List<Publicacion> _publicaciones;
        private DateTime _ultimaActualizacion;

        // ID autogenerado
        private static int _contadorId = 1;

        // Constructores
        public Catalogo() { }

        public Catalogo(List<Publicacion> publicaciones)
        {
            _id = _contadorId++;
            _codigo = AsignarCodigo();
            _publicaciones = publicaciones;
            _ultimaActualizacion = DateTime.Now;
        }

        // Propiedades

        public string Codigo
        {
            get { return _codigo; }
            private set { _codigo = value; }
        }

        public List<Publicacion> Publicaciones
        {
            get { return _publicaciones; }
            private set { _publicaciones = value; }
        }

        public DateTime UltimaActualizacion
        {
            get { return _ultimaActualizacion; }
            private set { _ultimaActualizacion = value; }
        }

        // Métodos
        public void AgregarPublicacion(Publicacion publicacion)
        {
            if (publicacion != null)
            {
                _publicaciones.Add(publicacion);
                ActualizarFecha();
            }
        }

        public void RemoverPublicacion(Publicacion publicacion)
        {
            if (publicacion != null && _publicaciones.Contains(publicacion))
            {
                _publicaciones.Remove(publicacion);
                ActualizarFecha();
            }
        }

        public int ObtenerCantidadPublicaciones()
        {
            return _publicaciones.Count;
        }

        private void ActualizarFecha()
        {
            _ultimaActualizacion = DateTime.Now;
        }

        // Método privado para asignar código
        private string AsignarCodigo()
        {
            return "CAT" + _contadorId.ToString("D4");
        }
    }
}
