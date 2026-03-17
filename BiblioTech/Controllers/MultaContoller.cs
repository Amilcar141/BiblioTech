using BiblioTech.Models;
using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech.Controllers
{
    public class MultaController
    {
        private List<Multa> _multas;

        public MultaController()
        {
            _multas = new List<Multa>();
        }

        // Métodos de multa

        // Obtiene todas las multas registradas
        public List<Multa> ObtenerMultas()
        {
            return _multas;
        }

        // Obtiene todas las multas pendientes de pago
        public List<Multa> ObtenerMultasPendientes()
        {
            List<Multa> multasPendientes = new List<Multa>();

            foreach (Multa m in _multas)
            {
                if (m.EstaPendiente())
                {
                    multasPendientes.Add(m);
                }
            }

            return multasPendientes;
        }

        // Obtiene todas las multas pagadas
        public List<Multa> ObtenerMultasPagadas()
        {
            List<Multa> multasPagadas = new List<Multa>();

            foreach (Multa m in _multas)
            {
                if (!m.EstaPendiente())
                {
                    multasPagadas.Add(m);
                }
            }

            return multasPagadas;
        }

        // Obtiene todas las multas de un lector específico
        public List<Multa> ObtenerMultasPorLector(string idLector)
        {
            List<Multa> multasLector = new List<Multa>();

            foreach (Multa m in _multas)
            {
                if (m.Lector != null && m.Lector.NumeroCuenta == idLector)
                {
                    multasLector.Add(m);
                }
            }

            return multasLector;
        }

        // Obtiene todas las multas de un préstamo específico
        public List<Multa> ObtenerMultasPorPrestamo(string codigoPrestamo)
        {
            List<Multa> multasPrestamo = new List<Multa>();

            foreach (Multa m in _multas)
            {
                if (m.Prestamo != null && m.Prestamo.CodigoPrestamo == codigoPrestamo)
                {
                    multasPrestamo.Add(m);
                }
            }

            return multasPrestamo;
        }

        // Busca una multa por su codigo
        public Multa BuscarMulta(string codigo)
        {
            foreach (Multa m in _multas)
            {
                if (m.CodigoMulta == codigo)
                {
                    return m;
                }
            }

            return null;
        }

        // Calcular días de mora desde la fecha de generación
        public int CalcularDiasMora(DateTime fechaGeneracion)
        {
            TimeSpan diferencia = DateTime.Now - fechaGeneracion;
            return (int)diferencia.TotalDays;
        }

        // Obtner total a cobrar de multas pendientes
        public decimal ObtenerTotalMultasPendientes()
        {
            decimal total = 0;

            foreach (Multa m in _multas)
            {
                if (m.EstaPendiente())
                    total += m.Monto;
            }

            return total;
        }


        // Registra una nueva multa sin préstamo asociado
        public bool RegistrarMulta(TipoMulta tipo, decimal monto, string descripcion)
        {
            if (monto <= 0)
                return false;

            Multa nuevaMulta = new Multa(tipo, monto, descripcion);
            _multas.Add(nuevaMulta);
            return true;
        }

        // Registra una nueva multa con lector asociado
        public bool RegistrarMulta(TipoMulta tipo, decimal monto, string descripcion, Lector lector)
        {
            if (monto <= 0)
                return false;

            Multa nuevaMulta = new Multa(tipo, monto, descripcion);
            nuevaMulta.Lector = lector;
            _multas.Add(nuevaMulta);
            return true;
        }

        // Registra una nueva multa con prestamo y lector asociados
        public bool RegistrarMulta(TipoMulta tipo, decimal monto, string descripcion, Lector lector, Prestamo prestamo)
        {
            if (monto <= 0)
                return false;

            Multa nuevaMulta = new Multa(tipo, monto, descripcion);
            nuevaMulta.Lector = lector;
            nuevaMulta.Prestamo = prestamo;
            _multas.Add(nuevaMulta);
            return true;
        }

        // Edita una multa
        public bool EditarMulta(string codigo, TipoMulta tipo, decimal monto, string descripcion)
        {
            foreach (Multa m in _multas)
            {
                if (m.CodigoMulta == codigo)
                {
                    m.CodigoMulta = codigo;
                    m.TipoMulta = tipo;
                    m.Monto = monto;
                    m.Descripcion = descripcion;

                    return true;
                }
            }

            return false;
        }

        // Procesa el pago de una multa
        public bool PagarMulta(string codigo)
        {
            Multa multa = BuscarMulta(codigo);

            if (multa == null)
                return false;

            multa.Pagar();
            return true;
        }

        // Elimina una multa del sistema
        public bool EliminarMulta(string codigo)
        {
            Multa multa = BuscarMulta(codigo);

            if (multa == null)
                return false;

            _multas.Remove(multa);
            return true;
        }
    }
}
