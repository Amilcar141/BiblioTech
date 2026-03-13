using BiblioTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Busca una multa por su ID
        public Multa ObtenerMultaPorId(int idMulta)
        {
            foreach (Multa m in _multas)
            {
                if (m.Id == idMulta)
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
        public double ObtenerTotalMultasPendientes()
        {
            double total = 0;

            foreach (Multa m in _multas)
            {
                if (m.EstaPendiente())
                    total += m.Monto;
            }

            return total;
        }


        // Registra una nueva multa
        public bool RegistrarMulta(int idMulta, double monto)
        {
            if (idMulta <= 0 || monto <= 0)
                return false;

            // Verificar que no exista una multa con el mismo ID
            if (ObtenerMultaPorId(idMulta) != null)
                return false;

            Multa nuevaMulta = new Multa(idMulta, monto);
            _multas.Add(nuevaMulta);
            return true;
        }

        // Procesa el pago de una multa
        public bool PagarMulta(int idMulta)
        {
            Multa multa = ObtenerMultaPorId(idMulta);

            if (multa == null)
                return false;

            multa.Pagar();
            return true;
        }

        // Elimina una multa del sistema
        public bool EliminarMulta(int idMulta)
        {
            Multa multa = ObtenerMultaPorId(idMulta);
            if (multa == null)
                return false;

            _multas.Remove(multa);
            return true;
        }
    }
}
