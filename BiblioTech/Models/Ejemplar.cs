using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    // Clase para representar un ejemplar de un libro específico en la biblioteca
    public class Ejemplar
    {
        // Atributos privados
        private int _id;
        private string _codigoEjemplar;
        private EstadoPublicacion _estado;

        // Contador para generar IDs únicos
        private static int _contadorId = 1;

        // Constructores
        public Ejemplar() { }

        public Ejemplar(EstadoPublicacion estado)
        {
            _id = _contadorId++;
            _codigoEjemplar = AsignarCodigo();
            _estado = estado;
        }

        // Metodos Getters y Setters
        public string CodigoEjemplar
        {
            get { return _codigoEjemplar; }
            private set { _codigoEjemplar = value; }
        }

        public EstadoPublicacion Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        // Asignar un código único a cada ejemplar
        private string AsignarCodigo()
        {
            return "EJEM-" + _contadorId.ToString("D4");
        }

        // Obtine la cantidad de ejemplares disponibles
        public static int ContarDisponibles(List<Ejemplar> ejemplares)
        {
            int disponibles = 0;
            foreach (Ejemplar ejem in ejemplares)
            {
                if (ejem.Estado == EstadoPublicacion.Disponible)
                    disponibles++;
            }
            return disponibles;
        }
    }
}
