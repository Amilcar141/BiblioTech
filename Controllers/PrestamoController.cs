using BiblioTech.Data;
using BiblioTech.Models;
using System;
using System.Collections.Generic;
using System.Data;

//El contenido es generado por usuarios y no está verificado.


namespace BiblioTech.Controllers
{
    /// <summary>
    /// Controller de Préstamos.
    /// Toda persistencia contra la tabla Prestamos (+ Ejemplares para disponibilidad).
    /// El historial ya no es estático en memoria: se consulta de la BD cada vez.
    /// </summary>
    public class PrestamoController //5
    {
        private readonly ConexionPrestamo _db = new ConexionPrestamo();

        // ── Propiedad Historial (compatibilidad con vistas existentes) ──
        /// <summary>
        /// Devuelve todos los préstamos de la BD.
        /// Las vistas que usaban _historial estático ahora llaman a este getter.
        /// </summary>
        public List<Prestamo> Historial
        {
            get { return ObtenerTodos(); }
        }

        // ── Registrar préstamo ─────────────────────────────────────────
        public bool RegistrarPrestamo(Prestamo prestamo)
        {
            if (prestamo == null) return false;
            try
            {
                // Generar código único
                string codigo = "PR" + DateTime.Now.ToString("yyMMddHHmmss");

                string sql =
                    "INSERT INTO Prestamos " +
                    "(IdEstadoPrestamo, IdEjemplar, IdLector, IdAdministrador, CodigoPrestamo, " +
                    " FechaInicio, FechaLimite, CreatedAt) " +
                    "VALUES (@estado, @ejemplar, @lector, @admin, @codigo, " +
                    "        @inicio, @limite, GETDATE()); " +
                    "SELECT SCOPE_IDENTITY();";

                object resultado = _db.EjecutarScalar(sql, cmd =>
                {
                    cmd.Parameters.AddWithValue("@estado", 1); // ACTIVO
                    cmd.Parameters.AddWithValue("@ejemplar", prestamo.IdEjemplar);
                    cmd.Parameters.AddWithValue("@lector", prestamo.IdLector);
                    cmd.Parameters.AddWithValue("@admin",
                        prestamo.IdAdministrador > 0
                            ? (object)prestamo.IdAdministrador
                            : DBNull.Value);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@inicio", prestamo.FechaInicio);
                    cmd.Parameters.AddWithValue("@limite", prestamo.FechaLimite.Date);
                });

                prestamo.IdPrestamo = Convert.ToInt32(resultado);
                prestamo.CodigoPrestamo = codigo;

                // Marcar ejemplar como PRESTADO (IdDisponibilidad = 2)
                ActualizarDisponibilidadEjemplar(prestamo.IdEjemplar, 2);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ── Obtener todos ──────────────────────────────────────────────
        public List<Prestamo> ObtenerTodos()
        {
            List<Prestamo> lista = new List<Prestamo>();
            try
            {
                string sql = BuildSelectPrestamo() +
                    "WHERE p.DeletedAt IS NULL " +
                    "ORDER BY p.FechaInicio DESC";

                DataTable dt = _db.EjecutarConsulta(sql);
                foreach (DataRow row in dt.Rows)
                    lista.Add(MapearPrestamo(row));
            }
            catch (Exception) { }
            return lista;
        }

        // ── Obtener por ID ─────────────────────────────────────────────
        public Prestamo ObtenerPorId(int id)
        {
            try
            {
                string sql = BuildSelectPrestamo() +
                    "WHERE p.IdPrestamo = @id AND p.DeletedAt IS NULL";

                DataTable dt = _db.EjecutarConsulta(sql, cmd =>
                    cmd.Parameters.AddWithValue("@id", id));

                if (dt.Rows.Count == 0) return null;
                return MapearPrestamo(dt.Rows[0]);
            }
            catch (Exception) { return null; }
        }

        // ── Obtener activos ────────────────────────────────────────────
        public List<Prestamo> ObtenerActivos()
        {
            List<Prestamo> lista = new List<Prestamo>();
            try
            {
                string sql = BuildSelectPrestamo() +
                    "WHERE p.IdEstadoPrestamo = 1 AND p.DeletedAt IS NULL " +
                    "ORDER BY p.FechaLimite";

                DataTable dt = _db.EjecutarConsulta(sql);
                foreach (DataRow row in dt.Rows)
                    lista.Add(MapearPrestamo(row));
            }
            catch (Exception) { }
            return lista;
        }

        // ── Obtener vencidos ───────────────────────────────────────────
        public List<Prestamo> ObtenerVencidos()
        {
            List<Prestamo> lista = new List<Prestamo>();
            try
            {
                // Activos cuya fecha límite ya pasó
                string sql = BuildSelectPrestamo() +
                    "WHERE p.IdEstadoPrestamo = 1 " +
                    "  AND p.FechaLimite < CAST(GETDATE() AS DATE) " +
                    "  AND p.DeletedAt IS NULL " +
                    "ORDER BY p.FechaLimite";

                DataTable dt = _db.EjecutarConsulta(sql);
                foreach (DataRow row in dt.Rows)
                    lista.Add(MapearPrestamo(row));
            }
            catch (Exception) { }
            return lista;
        }

        // ── Obtener por lector ─────────────────────────────────────────
        public List<Prestamo> ObtenerPorLector(int idLector)
        {
            List<Prestamo> lista = new List<Prestamo>();
            try
            {
                string sql = BuildSelectPrestamo() +
                    "WHERE p.IdLector = @idLector AND p.DeletedAt IS NULL " +
                    "ORDER BY p.FechaInicio DESC";

                DataTable dt = _db.EjecutarConsulta(sql, cmd =>
                    cmd.Parameters.AddWithValue("@idLector", idLector));

                foreach (DataRow row in dt.Rows)
                    lista.Add(MapearPrestamo(row));
            }
            catch (Exception) { }
            return lista;
        }

        // ── Devolver préstamo ──────────────────────────────────────────
        public bool DevolverPrestamo(int idPrestamo)
        {
            try
            {
                Prestamo p = ObtenerPorId(idPrestamo);
                if (p == null) return false;

                string sql =
                    "UPDATE Prestamos SET IdEstadoPrestamo = 2, " +   // 2 = DEVUELTO
                    "FechaDevolucion = GETDATE() " +
                    "WHERE IdPrestamo = @id AND DeletedAt IS NULL";

                int filas = _db.EjecutarComando(sql, cmd =>
                    cmd.Parameters.AddWithValue("@id", idPrestamo));

                // Marcar ejemplar como DISPONIBLE (IdDisponibilidad = 1)
                if (filas > 0)
                    ActualizarDisponibilidadEjemplar(p.IdEjemplar, 1);

                return filas > 0;
            }
            catch (Exception) { return false; }
        }

        // ── Renovar préstamo ───────────────────────────────────────────
        public bool RenovarPrestamo(int idPrestamo, DateTime nuevaFechaLimite)
        {
            try
            {
                string sql =
                    "UPDATE Prestamos SET FechaLimite = @nuevaFecha " +
                    "WHERE IdPrestamo = @id AND IdEstadoPrestamo = 1 AND DeletedAt IS NULL";

                int filas = _db.EjecutarComando(sql, cmd =>
                {
                    cmd.Parameters.AddWithValue("@nuevaFecha", nuevaFechaLimite.Date);
                    cmd.Parameters.AddWithValue("@id", idPrestamo);
                });

                return filas > 0;
            }
            catch (Exception) { return false; }
        }

        // ── Helpers ────────────────────────────────────────────────────
        private void ActualizarDisponibilidadEjemplar(int idEjemplar, int idDisponibilidad)
        {
            try
            {
                string sql = "UPDATE Ejemplares SET IdDisponibilidad = @disp WHERE IdEjemplar = @id";
                _db.EjecutarComando(sql, cmd =>
                {
                    cmd.Parameters.AddWithValue("@disp", idDisponibilidad);
                    cmd.Parameters.AddWithValue("@id", idEjemplar);
                });
            }
            catch (Exception) { }
        }

        /// <summary>SQL base con JOINs reutilizable en todos los SELECT.</summary>
        private string BuildSelectPrestamo()
        {
            return
                "SELECT p.IdPrestamo, p.IdEstadoPrestamo, p.IdEjemplar, p.IdLector, " +
                "       p.IdAdministrador, p.CodigoPrestamo, p.FechaInicio, p.FechaLimite, " +
                "       p.FechaDevolucion, p.CreatedAt, " +
                "       ep.Estado AS EstadoTexto, " +
                "       ub.Nombre AS NombreLector, " +
                "       l.TituloLibro, " +
                "       CONCAT(a.Nombres, ' ', a.Apellidos) AS NombreAutor, " +
                "       ej.CodigoEjemplar " +
                "FROM Prestamos p " +
                "INNER JOIN EstadoPrestamo ep ON p.IdEstadoPrestamo = ep.IdEstadoPrestamo " +
                "INNER JOIN Lectores lec      ON p.IdLector         = lec.IdUsuario " +
                "INNER JOIN UsuarioBase ub    ON lec.IdUsuario       = ub.IdUsuario " +
                "INNER JOIN Ejemplares ej     ON p.IdEjemplar        = ej.IdEjemplar " +
                "INNER JOIN Libros l          ON ej.IdLibro          = l.IdLibro " +
                "INNER JOIN Autores a         ON l.IdAutor           = a.IdAutor ";
        }

        /// <summary>Convierte un DataRow del SELECT base en un objeto Prestamo.</summary>
        private Prestamo MapearPrestamo(DataRow row)
        {
            Prestamo p = new Prestamo();
            p.IdPrestamo = Convert.ToInt32(row["IdPrestamo"]);
            p.IdEstadoPrestamo = Convert.ToInt32(row["IdEstadoPrestamo"]);
            p.IdEjemplar = Convert.ToInt32(row["IdEjemplar"]);
            p.IdLector = Convert.ToInt32(row["IdLector"]);
            p.CodigoPrestamo = row["CodigoPrestamo"].ToString();

            if (row["FechaInicio"] != DBNull.Value)
                p.FechaInicio = Convert.ToDateTime(row["FechaInicio"]);

            if (row["FechaLimite"] != DBNull.Value)
                p.FechaLimite = Convert.ToDateTime(row["FechaLimite"]);

            if (row["FechaDevolucion"] != DBNull.Value)
                p.FechaDevolucion = Convert.ToDateTime(row["FechaDevolucion"]);

            if (row["IdAdministrador"] != DBNull.Value)
                p.IdAdministrador = Convert.ToInt32(row["IdAdministrador"]);

            // --------------------
            // 1️⃣ Objeto Lector simplificado
            // --------------------

            // Usamos el constructor existente que requiere nombre, correo, password y activo
            Lector lector = new Lector(
                nombre: row["NombreLector"].ToString(),
                correo: "",       // si no tienes, puedes dejar vacío
                password: "",     // temporal o vacío
                activo: true      // por defecto activo
            );
            p.Lector = lector;

            // --------------------
            // 2️⃣ Objeto Libro simplificado
            // --------------------

            // Crear libro
            Libro libro = new Libro();

            // Asignar título directamente
            libro.Titulo = row["TituloLibro"].ToString();

            // Crear autor simplificado
            Autor autor = new Autor();
            autor.Nombres = row["NombreAutor"].ToString();

            // Asignar autor al libro
            libro.Autor = autor;

            // Asignar libro al objeto p
            p.Libro = libro;

            // --------------------
            // 3️⃣ Retornar el objeto p
            // --------------------
            return p;
        }
    }
}