using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Models.Enums;

namespace BiblioTech.Models
{
    public class Ejemplar
    {
        // Atributos privados
        private int _id;
        private string _codigoEjemplar;
        private Libro _libro;
        private Disponibilidad _estado;

        // ID autogenerado
        private static int _contadorId = 1;

        // Constructores
        public Ejemplar() { }

        public Ejemplar(Libro libro)
        {
            _id = _contadorId++;
            _codigoEjemplar = AsignarCodigo();
            _libro = libro;
            _estado = Disponibilidad.Disponible;
        }

        // Propiedades
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string CodigoEjemplar
        {
            get { return _codigoEjemplar; }
            private set { _codigoEjemplar = value; }
        }

        public Libro Libro
        {
            get { return _libro; }
            set { _libro = value; }
        }

        public Disponibilidad Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        // Método privado para asignar código
        private string AsignarCodigo()
        {
            return "EJE" + _contadorId.ToString("D4");
        }
    }
}
