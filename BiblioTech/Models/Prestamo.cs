using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Prestamo
    {
        // Atributos privados
        private int _idPrestamo;
        private string _codigoPrestamo;
        private DateTime _fechaInicio;
        private DateTime _fechaLimite;
        private DateTime _fechaDevolucion;
        private EstadoPrestamo _estado;
        private List<Libro> _libros;
        private List<Multa> _multas;
        private Lector _lector;
        private Administrador _gestionadoPor;

        // Asignar un id unico al préstamo
        private static int _contadorIds = 1;

        // Constructores
        public Prestamo() { }

        public Prestamo(Lector lector, DateTime fechaInicio, DateTime fechaLimite, Administrador gestionadoPor)
        {
            _idPrestamo = _contadorIds++;
            _codigoPrestamo = AsignarCodigo();
            _lector = lector;
            _fechaInicio = fechaInicio;
            _fechaLimite = fechaLimite;
            _gestionadoPor = gestionadoPor;
            _libros = new List<Libro>(3);
            _multas = new List<Multa>();
            _estado = EstadoPrestamo.Activo;
        }

        // Propiedades
        public string CodigoPrestamo
        {
            get { return _codigoPrestamo; }
            private set { _codigoPrestamo = value; }
        }

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public DateTime FechaLimite
        {
            get { return _fechaLimite; }
            set { _fechaLimite = value; }
        }

        public DateTime FechaDevolucion
        {
            get { return _fechaDevolucion; }
            set { _fechaDevolucion = value; }
        }

        public EstadoPrestamo Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public List<Libro> Libros
        {
            get { return _libros; }
            set { _libros = value; }
        }

        public List<Multa> Multas
        {
            get { return _multas; }
            set { _multas = value; }
        }

        public Lector Lector
        {
            get { return _lector; }
            set { _lector = value; }
        }

        public Administrador GestionadoPor
        {
            get { return _gestionadoPor; }
            set { _gestionadoPor = value; }
        }


        // Métodos

        // Metodo para asignar un codigo unico a cada multa
        private string AsignarCodigo()
        {
            return "PRST-" + _idPrestamo.ToString("D4");
        }

        // Valida si el préstamo está vencido comparando la fecha actual con la fecha límite
        public bool EstaVencido()
        {
            if (DateTime.Now > _fechaLimite)
                return true;
            return false;
        }

        // Obtiene la cantidad de días de retraso
        public int ObtenerDiasDeRetraso()
        {
            if (!EstaVencido())
                return 0;

            // Compara las fechas, si se devolvio usa la fecha de devolucion, sino
            // usa la fecha actual
            DateTime fechaComparacion = _fechaDevolucion != DateTime.MinValue 
                ? _fechaDevolucion : DateTime.Now;

            // Diferencia de dias
            TimeSpan diferencia = fechaComparacion - _fechaLimite;

            // Retorna la cantidad de días de retraso y no sera negativa
            return (int)Math.Max(0, diferencia.TotalDays);
        }

        // Calcula la multa según el tipo y los libros involucrados
        public decimal CalcularMontoMulta(TipoMulta tipo)
        {
            int diasRetraso = ObtenerDiasDeRetraso();
            decimal precioTotalLibros = 0;

            foreach (Libro l in _libros)
            {
                // Usamos tu lógica de páginas * 2 si no hay precio real
                precioTotalLibros += l.Precio;
            }

            // Determina el tipo de multa a aplicar
            switch (tipo)
            {
                case TipoMulta.Retraso:
                    // Multa de 1% por cada dia de retraso 
                    if (diasRetraso > 0)
                        return diasRetraso * 0.01m * precioTotalLibros;
                    return 0;

                case TipoMulta.Deterioro:
                    // Si se daño cobra un 25%
                    return precioTotalLibros * 0.25m;

                case TipoMulta.Perdida:
                    // Si se perdio o extravio se cobra el libro + 20%
                    return precioTotalLibros * 1.20m;

                default:
                    return 0;
            }
        }

        // Agrega un libro al préstamo
        public void AgregarLibro(Libro libro)
        {
            if (libro == null)
                return;

            if (_libros.Count >= 3)
                return;

            _libros.Add(libro);
        }

        // Registra la devolución del préstamo y el administrador que registro el libro
        public void FinalizarPrestamo(Administrador administrador)
        {
            _fechaDevolucion = DateTime.Now;
            _estado = EstadoPrestamo.Devuelto;
            _gestionadoPor = administrador;
        }
    }
}
