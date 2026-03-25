using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Autor
    {
        private int _id;
        private string _codigo;
        private string _nombres;
        private string _apellidos;
        private Nacionalidad _nacionalidad;

        // ID autogenerado
        private static int _contadorId = 1;

        // Constructores
        public Autor() { }

        public Autor(string nombres, string apellidos, Nacionalidad nacionalidad)
        {
            _id = _contadorId++;
            _codigo = AsignarCodigo();
            _nombres = nombres;
            _apellidos = apellidos;
            _nacionalidad = nacionalidad;
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

        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public Nacionalidad Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }

        // Método privado para asignar código
        private string AsignarCodigo()
        {
            return "AUT" + _contadorId.ToString("D4");
        }

        public string NombreCompleto()
        {
            return _nombres + " " + _apellidos;
        }
    }
}
