using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Nacionalidad
    {
        // Atributos privados
        private int _id;
        private string _codigo;
        private string _nombre;

        // ID autogenerado
        private static int _contadorId = 1;

        // Constructores
        public Nacionalidad() { }

        // Constructor con parámetros
        public Nacionalidad(string nombre)
        {
            _id = _contadorId++;
            _codigo = AsignarCodigo();
            _nombre = nombre;
        }

        // Propiedades

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
            private set { _codigo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string AsignarCodigo()
        {
            return $"NAC-{_id.ToString("D4")}";
        }
    }
}
