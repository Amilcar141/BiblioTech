using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Prestamo
    {
        // Atributos privados
        private int _idPrestamo;
        private DateTime _fechaInicio;
        private DateTime _fechaLimite;
        private DateTime _fechaDevolucion;
        private EstadoPrestamo _estado;
        private Multa _multa;
        private Lector _lector;
        private Libro _libro;
        private List<Multa> _multas;
        private Administrador _gestionadoPor;
        private decimal _tarifaDiaria = 5.00m; // Extra: tarifa diaria por retraso

        // Propiedades
        public int IdPrestamo
        {
            get { return _idPrestamo; }
            set { _idPrestamo = value; }
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

        public Multa Multa
        {
            get { return _multa; }
            set { _multa = value; }
        }

        public Lector Lector
        {
            get { return _lector; }
            set { _lector = value; }
        }

        public Libro Libro
        {
            get { return _libro; }
            set { _libro = value; }
        }

        public List<Multa> Multas
        {
            get { return _multas; }
            set { _multas = value; }
        }

        public Administrador GestionadoPor
        {
            get { return _gestionadoPor; }
            set { _gestionadoPor = value; }
        }

        public decimal TarifaDiaria
        {
            get { return _tarifaDiaria; }
            set { _tarifaDiaria = value; }
        }

        // Constructores
        public Prestamo()
        {
            _multas = new List<Multa>();
            _estado = EstadoPrestamo.Activo;
        }

        public Prestamo(int idPrestamo, Lector lector, Libro libro, DateTime fechaInicio, DateTime fechaLimite, Administrador gestionadoPor)
        {
            _idPrestamo = idPrestamo;
            _lector = lector;
            _libro = libro;
            _fechaInicio = fechaInicio;
            _fechaLimite = fechaLimite;
            _gestionadoPor = gestionadoPor;
            _multas = new List<Multa>();
            _estado = EstadoPrestamo.Activo;
        }

        // Métodos
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

        // Calcula la multa por retraso en la devolución
        public decimal CalcularMulta()
        {
            int diasRetraso = ObtenerDiasDeRetraso();

            decimal multa = diasRetraso * _tarifaDiaria;

            return multa;
        }

        // Registra la devolución del préstamo y el administrador que registro el libro
        public void RegistrarDevolucion(DateTime fechaDevolucion, Administrador administrador)
        {
            _fechaDevolucion = fechaDevolucion;
            _estado = EstadoPrestamo.Devuelto;
            _gestionadoPor = administrador;

            // Si hay retraso creaa una multa
            int diasRetraso = ObtenerDiasDeRetraso();

            if (diasRetraso > 0)
            {
                decimal montoMulta = CalcularMulta();
                Multa multa = new Multa();

                _multas.Add(multa);
                _multa = multa; // Asignar la multa más reciente
            }
        }
    }
}
