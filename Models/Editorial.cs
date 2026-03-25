using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Editorial
    {
        // Atributos privados
        private int _id;
        private string _codigo;
        private string _nombre;
        private Nacionalidad _paisOrigen;

        // ID autogenerado
        private static int _contadorId = 1;

        // Constructores
        public Editorial() { }

        public Editorial(string nombre, Nacionalidad paisOrigen)
        {
            _id = _contadorId++;
            _codigo = AsignarCodigo();
            _nombre = nombre;
            _paisOrigen = paisOrigen;
        }

        // Propiedades Get y Set
        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        public Nacionalidad PaisOrigen
        {
            get { return _paisOrigen; }
            set { _paisOrigen = value; }
        }

        // Método privado para asignar código
        private string AsignarCodigo()
        {
            return "EDIT" + _contadorId.ToString("D4");
        }
    }
}
