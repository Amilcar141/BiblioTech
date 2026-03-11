using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTech.Models
{
    public class Prestamo
    {
        public int idPrestamo { get; set; }
        public int idLibro { get; set; }
        public int idUsuario { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool FueDevuelto { get; set; }

        public Prestamo()
        {
        }

        public Prestamo(int idPrestamo, int idLibro, int idUsuario, string Titulo, bool Disponibilidad, string usuario, DateTime FechaSalida, DateTime FechaEntrega, bool FueDevuelto)
        {
            this.idPrestamo = idPrestamo;
            this.idLibro = idLibro;
            this.idUsuario = idUsuario;
            this.FechaSalida = FechaSalida;
            this.FechaEntrega = FechaEntrega;
            this.FueDevuelto = FueDevuelto;
        }
    }
}
