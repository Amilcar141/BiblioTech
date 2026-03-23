using BiblioTech.Models;
using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;

namespace BiblioTech.Controllers
{ 
    public class MultaController//4
    {
        // Lista de las multas registradas en el sistema
        private static List<Multa> _multas;

        public MultaController() 
        { 
            _multas = new List<Multa>();
        }

        // Metodos del controlador
        public List<Multa> ObtenerMultas()
        { 
            return _multas; 
        }

        // Metodos Principales
        // Registrar multa 
        public bool RegistrarMulta(string descripcion, decimal monto, TipoMulta tipo)
        {
            if (monto <= 0) 
                return false;

            Multa nueva = new Multa(descripcion, monto, tipo);
            _multas.Add(nueva);

            return true;
        }

        // Editar multa en caso de error en el registro
        public bool EditarMulta(string codigo, string descripcion, decimal monto, TipoMulta tipo)
        {
            if (monto <= 0) 
                return false;

            foreach (Multa m in _multas)
            {
                if (m.CodigoMulta == codigo)
                {
                    m.Descripcion = descripcion;
                    m.Monto = monto;
                    m.Tipo = tipo;
                    return true;
                }
            }

            return false;
        }

        // Pagar Multa
        public bool PagarMulta(string codigo)
        {
            Multa m = ObtenerMultaPorCodigo(codigo);

            if (m == null) 
                return false;

            m.Pagar();
            return true;
        }

        public bool EliminarMulta(string codigo)
        {
            Multa m = ObtenerMultaPorCodigo(codigo);

            if (m == null) 
                return false;

            _multas.Remove(m);
            return true;
        }

        // Otros metodos
        public List<Multa> ObtenerMultasPendientes()
        {
            List<Multa> lista = new List<Multa>();

            foreach (Multa m in _multas)
            {
                if (m.EstaPendiente())
                    lista.Add(m);
            }

            return lista;
        }

        public List<Multa> ObtenerMultasPagadas()
        {
            List<Multa> lista = new List<Multa>();

            foreach (Multa m in _multas)
            {
                if (!m.EstaPendiente())
                    lista.Add(m);
            }

            return lista;
        }

        public Multa ObtenerMultaPorCodigo(string codigo)
        {
            foreach (Multa m in _multas)
            {
                if (m.CodigoMulta == codigo)
                    return m;
            }

            return null;
        }

        public List<Multa> ObtenerMultaPorTipo(TipoMulta tipo)
        {
            List<Multa> multas = new List<Multa>();

            foreach (Multa m in _multas)
            {
                if (m.Tipo == tipo)
                    multas.Add(m);
            }

            return multas;
        }

        public List<Multa> ObtenerMultaPorLector(Lector lector)
        {
            List<Multa> multas = new List<Multa>();

            foreach (Multa m in _multas)
            {
                if (m.Lector != null && m.Lector.Cuenta == lector.Cuenta)
                    multas.Add(m);
            }
            return multas;
        }

        // Calcular días de mora a partir de la fecha de generación de la multa
        public int CalcularDiasMora(DateTime fechaGeneracion)
        {
            TimeSpan diff = DateTime.Now - fechaGeneracion;
            return (int)diff.TotalDays;
        }

        // Obtiene el total de multas pendientes
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
    }
}
