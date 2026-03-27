using BiblioTech.Data;
using BiblioTech.Models;
using BiblioTech.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BiblioTech.Controllers
{
    /// <summary>
    /// Controller de Multas.
    /// Toda persistencia contra la tabla Multas (+ EstadoMulta y TipoMulta).
    /// </summary>
    public class MultaController //4
    {
        private readonly ConexionMulta _db = new ConexionMulta();

        // ── Obtener todas ──────────────────────────────────────────────
        public List<Multa> ObtenerMultas()
        {
            List<Multa> lista = new List<Multa>();
            try
            {
                string sql = BuildSelectMulta() +
                    "WHERE m.DeletedAt IS NULL " +
                    "ORDER BY m.FechaGeneracion DESC";

                DataTable dt = _db.EjecutarConsulta(sql);
                foreach (DataRow row in dt.Rows)
                    lista.Add(MapearMulta(row));
            }
            catch (Exception) { }
            return lista;
        }

        // ── Pendientes ─────────────────────────────────────────────────
        public List<Multa> ObtenerMultasPendientes()
        {
            List<Multa> lista = new List<Multa>();
            try
            {
                string sql = BuildSelectMulta() +
                    "WHERE m.IdEstadoMulta = 1 AND m.DeletedAt IS NULL " +  // 1 = PENDIENTE
                    "ORDER BY m.FechaGeneracion DESC";

                DataTable dt = _db.EjecutarConsulta(sql);
                foreach (DataRow row in dt.Rows)
                    lista.Add(MapearMulta(row));
            }
            catch (Exception) { }
            return lista;
        }

        // ── Pagadas ────────────────────────────────────────────────────
        public List<Multa> ObtenerMultasPagadas()
        {
            List<Multa> lista = new List<Multa>();
            try
            {
                string sql = BuildSelectMulta() +
                    "WHERE m.IdEstadoMulta = 2 AND m.DeletedAt IS NULL " +  // 2 = PAGADA
                    "ORDER BY m.FechaPago DESC";

                DataTable dt = _db.EjecutarConsulta(sql);
                foreach (DataRow row in dt.Rows)
                    lista.Add(MapearMulta(row));
            }
            catch (Exception) { }
            return lista;
        }

        // ── Por ID ─────────────────────────────────────────────────────
        public Multa ObtenerMultaPorId(int id)
        {
            try
            {
                string sql = BuildSelectMulta() +
                    "WHERE m.IdMulta = @id AND m.DeletedAt IS NULL";

                DataTable dt = _db.EjecutarConsulta(sql, cmd =>
                    cmd.Parameters.AddWithValue("@id", id));

                if (dt.Rows.Count == 0) return null;
                return MapearMulta(dt.Rows[0]);
            }
            catch (Exception) { return null; }
        }

        // ── Por lector ─────────────────────────────────────────────────
        public List<Multa> ObtenerMultasPorLector(int idLector)
        {
            List<Multa> lista = new List<Multa>();
            try
            {
                string sql = BuildSelectMulta() +
                    "WHERE m.IdLector = @idLector AND m.DeletedAt IS NULL " +
                    "ORDER BY m.FechaGeneracion DESC";

                DataTable dt = _db.EjecutarConsulta(sql, cmd =>
                    cmd.Parameters.AddWithValue("@idLector", idLector));

                foreach (DataRow row in dt.Rows)
                    lista.Add(MapearMulta(row));
            }
            catch (Exception) { }
            return lista;
        }

        // ── Registrar multa simple (manual) ────────────────────────────
        public bool RegistrarMulta(int idIgnorado, double monto)
        {
            if (monto <= 0) return false;
            try
            {
                string codigo = "MU" + DateTime.Now.ToString("yyMMddHHmmss");
                string sql =
                    "INSERT INTO Multas (IdEstadoMulta, IdTipoMulta, IdLector, CodigoMulta, " +
                    "                    Descripcion, Monto, FechaGeneracion, CreatedAt) " +
                    "VALUES (1, 1, 0, @codigo, @desc, @monto, GETDATE(), GETDATE())";
                // IdLector=0 es una multa sin lector asignado; en uso real pasarías el idLector real

                _db.EjecutarComando(sql, cmd =>
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@desc", "Multa manual");
                    cmd.Parameters.AddWithValue("@monto", monto);
                });
                return true;
            }
            catch (Exception) { return false; }
        }

        // ── Registrar multa completa por préstamo vencido ──────────────
        public Multa RegistrarMultaPrestamo(double monto, string nombreUsuario,
            string tituloLibro, int idPrestamo, int diasMora)
        {
            if (monto <= 0) return null;
            try
            {
                string codigo = "MU" + DateTime.Now.ToString("yyMMddHHmmss");
                string descripcion = $"Devolucion tardía: {diasMora} día(s) de retraso - {tituloLibro}";

                // Obtener idLector desde el préstamo
                int idLector = ObtenerIdLectorDePrestamo(idPrestamo);

                string sql =
                    "INSERT INTO Multas (IdEstadoMulta, IdTipoMulta, IdLector, IdPrestamo, CodigoMulta, " +
                    "                    Descripcion, Monto, FechaGeneracion, CreatedAt) " +
                    "VALUES (1, 1, @idLector, @idPrestamo, @codigo, @desc, @monto, GETDATE(), GETDATE()); " +
                    "SELECT SCOPE_IDENTITY();";

                object resultado = _db.EjecutarScalar(sql, cmd =>
                {
                    cmd.Parameters.AddWithValue("@idLector", idLector > 0 ? (object)idLector : DBNull.Value);
                    cmd.Parameters.AddWithValue("@idPrestamo", idPrestamo > 0 ? (object)idPrestamo : DBNull.Value);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@desc", descripcion);
                    cmd.Parameters.AddWithValue("@monto", monto);
                });

                Multa nueva = new Multa(Convert.ToInt32(resultado), monto,
                    nombreUsuario, tituloLibro, idPrestamo, diasMora);
                nueva.CodigoMulta = codigo;
                return nueva;
            }
            catch (Exception) { return null; }
        }

        // ── Pagar multa ────────────────────────────────────────────────
        public bool PagarMulta(int id)
        {
            try
            {
                string sql =
                    "UPDATE Multas SET IdEstadoMulta = 2, FechaPago = GETDATE() " +  // 2 = PAGADA
                    "WHERE IdMulta = @id AND IdEstadoMulta = 1 AND DeletedAt IS NULL";

                return _db.EjecutarComando(sql, cmd =>
                    cmd.Parameters.AddWithValue("@id", id)) > 0;
            }
            catch (Exception) { return false; }
        }

        // ── Eliminar multa (soft delete) ───────────────────────────────
        public bool EliminarMulta(int id)
        {
            try
            {
                string sql = "UPDATE Multas SET DeletedAt = GETDATE() " +
                             "WHERE IdMulta = @id AND DeletedAt IS NULL";
                return _db.EjecutarComando(sql, cmd =>
                    cmd.Parameters.AddWithValue("@id", id)) > 0;
            }
            catch (Exception) { return false; }
        }

        // ── Total pendiente ────────────────────────────────────────────
        public double ObtenerTotalMultasPendientes()
        {
            try
            {
                object r = _db.EjecutarScalar(
                    "SELECT ISNULL(SUM(Monto), 0) FROM Multas WHERE IdEstadoMulta = 1 AND DeletedAt IS NULL");
                return r != null ? Convert.ToDouble(r) : 0;
            }
            catch (Exception) { return 0; }
        }

        // ── Calcular días de mora ──────────────────────────────────────
        public int CalcularDiasMora(DateTime fechaLimite)
        {
            if (DateTime.Now <= fechaLimite) return 0;
            return (int)(DateTime.Now - fechaLimite).TotalDays;
        }

        // ── Helpers privados ───────────────────────────────────────────
        private int ObtenerIdLectorDePrestamo(int idPrestamo)
        {
            try
            {
                object r = _db.EjecutarScalar(
                    "SELECT IdLector FROM Prestamos WHERE IdPrestamo = @id",
                    cmd => cmd.Parameters.AddWithValue("@id", idPrestamo));
                return r != null && r != DBNull.Value ? Convert.ToInt32(r) : 0;
            }
            catch (Exception) { return 0; }
        }

        private string BuildSelectMulta()
        {
            return
                "SELECT m.IdMulta, m.IdEstadoMulta, m.IdTipoMulta, m.IdLector, m.IdPrestamo, " +
                "       m.CodigoMulta, m.Descripcion, m.Monto, m.FechaGeneracion, m.FechaPago, " +
                "       m.CreatedAt, " +
                "       em.EstadoMulta AS EstadoTexto, " +
                "       tm.TipoMulta  AS TipoTexto, " +
                "       ub.Nombre     AS NombreLector, " +
                "       ISNULL(l.TituloLibro, '') AS TituloLibro, " +
                "       ISNULL(DATEDIFF(DAY, p.FechaLimite, ISNULL(p.FechaDevolucion, GETDATE())), 0) AS DiasMora " +
                "FROM Multas m " +
                "INNER JOIN EstadoMulta em     ON m.IdEstadoMulta = em.IdEstadoMulta " +
                "INNER JOIN TipoMulta tm       ON m.IdTipoMulta   = tm.IdTipoMulta " +
                "INNER JOIN Lectores lec       ON m.IdLector       = lec.IdUsuario " +
                "INNER JOIN UsuarioBase ub     ON lec.IdUsuario    = ub.IdUsuario " +
                "LEFT  JOIN Prestamos p        ON m.IdPrestamo     = p.IdPrestamo " +
                "LEFT  JOIN Ejemplares ej      ON p.IdEjemplar     = ej.IdEjemplar " +
                "LEFT  JOIN Libros l           ON ej.IdLibro       = l.IdLibro ";
        }

        private Multa MapearMulta(DataRow row)
        {
            Multa m = new Multa();
            m.Id = Convert.ToInt32(row["IdMulta"]);
            m.IdEstadoMulta = Convert.ToInt32(row["IdEstadoMulta"]);
            m.IdTipoMulta = Convert.ToInt32(row["IdTipoMulta"]);
            m.IdLector = Convert.ToInt32(row["IdLector"]);
            m.CodigoMulta = row["CodigoMulta"].ToString();
            m.Monto = row["Monto"] != DBNull.Value ? Convert.ToDouble(row["Monto"]) : 0;
            m.Descripcion = row["Descripcion"].ToString();
            m.NombreUsuario = row["NombreLector"].ToString();
            m.TituloLibro = row["TituloLibro"].ToString();
            m.DiasMora = Convert.ToInt32(row["DiasMora"]);

            if (row["IdPrestamo"] != DBNull.Value)
                m.IdPrestamo = Convert.ToInt32(row["IdPrestamo"]);

            if (row["FechaGeneracion"] != DBNull.Value)
                m.FechaGeneracion = Convert.ToDateTime(row["FechaGeneracion"]);

            if (row["FechaPago"] != DBNull.Value)
                m.FechaPago = Convert.ToDateTime(row["FechaPago"]);

            if (row["CreatedAt"] != DBNull.Value)
                m.CreatedAt = Convert.ToDateTime(row["CreatedAt"]);

            // El Motivo se usa en vistas existentes como alias de Descripcion
            m.Motivo = m.Descripcion;

            return m;
        }
    }
}