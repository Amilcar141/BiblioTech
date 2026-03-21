using BiblioTech.Models;
using System;
using System.Collections.Generic;

namespace BiblioTech.Controllers
{ 
    public class MultaController
    {
        private static List<Multa> _multas  = new List<Multa>();
        private static int         _nextId  = 1;

        public MultaController() { }

        
        public List<Multa> ObtenerMultas()           { return _multas; }

        public List<Multa> ObtenerMultasPendientes()
        {
            List<Multa> lista = new List<Multa>();
            foreach (Multa m in _multas)
                if (m.EstaPendiente()) lista.Add(m);
            return lista;
        }

        public List<Multa> ObtenerMultasPagadas()
        {
            List<Multa> lista = new List<Multa>();
            foreach (Multa m in _multas)
                if (!m.EstaPendiente()) lista.Add(m);
            return lista;
        }

        public Multa ObtenerMultaPorId(int id)
        {
            foreach (Multa m in _multas)
                if (m.Id == id) return m;
            return null;
        }

        public int CalcularDiasMora(DateTime fechaGeneracion)
        {
            TimeSpan diff = DateTime.Now - fechaGeneracion;
            return (int)diff.TotalDays;
        }

        public double ObtenerTotalMultasPendientes()
        {
            double total = 0;
            foreach (Multa m in _multas)
                if (m.EstaPendiente()) total += m.Monto;
            return total;
        }

        // Registrar multa 
        public bool RegistrarMulta(int idIgnorado, double monto)
        {
            if (monto <= 0) return false;
            Multa nueva = new Multa(_nextId++, monto);
            _multas.Add(nueva);
            return true;
        }

        //  Registrar multa completa por préstamo vencido 
        // Llamado automáticamente desde FrmDevolverLibro al devolver vencido
        public Multa RegistrarMultaPrestamo(
            double monto, string nombreUsuario, string tituloLibro,
            int idPrestamo, int diasMora)
        {
            if (monto <= 0) return null;
            Multa nueva = new Multa(_nextId++, monto, nombreUsuario, tituloLibro, idPrestamo, diasMora);
            _multas.Add(nueva);
            return nueva;
        }

        //  Pagar / Eliminar 
        public bool PagarMulta(int id)
        {
            Multa m = ObtenerMultaPorId(id);
            if (m == null) return false;
            m.Pagar();
            return true;
        }

        public bool EliminarMulta(int id)
        {
            Multa m = ObtenerMultaPorId(id);
            if (m == null) return false;
            _multas.Remove(m);
            return true;
        }
    }
}
