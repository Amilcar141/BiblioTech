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
         
        private int _idPrestamo;
        private string _codigo;
        private DateTime _fechaInicio;
        private DateTime _fechaLimite;
        private DateTime _fechaDevolucion;
        private EstadoPrestamo _estado;
        private Multa _multa;
        private List<Ejemplar> _libros;
        private List<Multa> _multas;
        private Lector _lector;
        private Administrador _gestionadoPor;
        private decimal _tarifaDiaria = 5.00m; // Extra: tarifa 

        // Contador autogenerado para ID
        private static int _contadorId = 1;

        // Constructores
        public Prestamo() { }

        public Prestamo(Lector lector, List<Ejemplar> libros, DateTime fechaInicio,
            DateTime fechaLimite, Administrador gestionadoPor)
        {
            _idPrestamo = _contadorId++;
            _codigo = AsignarCodigo();
            _libros = libros;
            _fechaInicio = fechaInicio;
            _fechaLimite = fechaLimite;
            _lector = lector;
            _gestionadoPor = gestionadoPor;
            _multas = new List<Multa>();
            _estado = EstadoPrestamo.Activo;
        }

        // Propiedades
        public string Codigo
        {
            get { return _codigo; }
            private set { _codigo = value; }
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

        public List<Ejemplar> Libros
        {
            get { return _libros; }
            set { _libros = value; }
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



        // Métodos

        // Método privado para asignar código
        private string AsignarCodigo()
        {
            return "PREST" + _contadorId.ToString("D3");
        }

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

        // Registra la devolución del préstamo 
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
                _multa = multa; 
            }
        }
    }
}
