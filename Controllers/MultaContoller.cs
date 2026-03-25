using BiblioTech.Models;
using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BiblioTech.Controllers
{
    public class MultaController
    {
        // Instancia del SistemaLibreria para el manejo de datos
        private SistemaLibreria _sistema;

        // Constructor
        public MultaController(SistemaLibreria sistema)
        {
            _sistema = sistema;
        }

        // Metodos principales

        // Obtener todas las multas
        public List<Multa> ObtenerTodas()
        {
            return _sistema.Multas;
        }

        // Registrar multa
        public bool RegistrarMulta(string descripcion, decimal monto, TipoMulta tipo)
        {
            if (monto <= 0)
                return false;

            Multa nueva = new Multa(descripcion, monto, tipo);
            _sistema.Multas.Add(nueva);

            return true;
        }

        // Editar multa en caso de error en el registro
        public bool EditarMulta(string codigo, string descripcion, decimal monto, TipoMulta tipo)
        {
            if (monto <= 0)
                return false;

            Multa multa = ObtenerPorCodigo(codigo);

            if (multa == null)
                return false;

            multa.Descripcion = descripcion;
            multa.Monto = monto;
            multa.Tipo = tipo;
            return true;
        }

        // Pagar multa
        public bool PagarMulta(string codigo)
        {
            Multa multa = ObtenerPorCodigo(codigo);

            if (multa == null)
                return false;

            multa.Pagar();
            return true;
        }

        // Eliminar multa
        public bool EliminarMulta(string codigo)
        {
            Multa multa = ObtenerPorCodigo(codigo);

            if (multa == null)
                return false;

            _sistema.Multas.Remove(multa);
            return true;
        }

        // Metodos de busqueda y filtrado

        // Obtener multa por código
        public Multa ObtenerPorCodigo(string codigo)
        {
            foreach (Multa m in ObtenerTodas())
            {
                if (m.CodigoMulta == codigo)
                    return m;
            }

            return null;
        }

        // Obtener multas pendientes
        public List<Multa> ObtenerMultasPendientes()
        {
            return ObtenerTodas()
                .Where(m => m.EstaPendiente())
                .ToList();
        }

        // Obtener multas pagadas
        public List<Multa> ObtenerMultasPagadas()
        {
            return ObtenerTodas()
                .Where(m => !m.EstaPendiente())
                .ToList();
        }

        // Obtener multas por tipo
        public List<Multa> ObtenerPorTipo(TipoMulta tipo)
        {
            return ObtenerTodas()
                .Where(m => m.Tipo == tipo)
                .ToList();
        }

        // Obtener multas por lector
        public List<Multa> ObtenerPorLector(Lector lector)
        {
            if (lector == null)
                return new List<Multa>();

            return ObtenerTodas()
                .Where(m => m.Lector != null && m.Lector.Cuenta == lector.Cuenta)
                .ToList();
        }

        // Otros metodos

        // Calcular días de mora a partir de la fecha de generación de la multa
        public int CalcularDiasMora(DateTime fechaGeneracion)
        {
            TimeSpan diff = DateTime.Now - fechaGeneracion;
            return (int)diff.TotalDays;
        }

        // Obtener el total de multas pendientes
        public decimal ObtenerTotalMultasPendientes()
        {
            return ObtenerMultasPendientes()
                .Sum(m => m.Monto);
        }

        // Obtener el total de multas pagadas
        public decimal ObtenerTotalMultasPagadas()
        {
            return ObtenerMultasPagadas()
                .Sum(m => m.Monto);
        }

        // Obtener total general de multas
        public decimal ObtenerTotalMultas()
        {
            return ObtenerTodas()
                .Sum(m => m.Monto);
        }
    }
}
