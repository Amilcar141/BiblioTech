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
    /// Controller de Usuarios.
    /// Reemplaza la versión con listas en memoria.
    /// Toda persistencia se realiza contra las tablas UsuarioBase, Lectores y Administradores.
    /// </summary>
    public class UsuarioController //6
    {
        private readonly ConexionUsuario _db = new ConexionUsuario();

        // ── Registrar usuario ──────────────────────────────────────────
        /// <summary>
        /// Inserta en UsuarioBase y en la tabla de rol correspondiente.
        /// El parámetro <paramref name="id"/> se ignora (lo genera IDENTITY).
        /// </summary>
        public bool RegistrarUsuario(int id, string nombre, string correo, string password, Rol rol)
        {
            try
            {
                // Verificar correo duplicado
                if (ExisteCorreo(correo, 0)) return false;

                int idRol = rol == Rol.Lector ? 1 : 2;

                // Generar número de cuenta único (UC + timestamp corto)
                string numeroCuenta = "UC" + DateTime.Now.ToString("yyMMddHHmmss");

                // INSERT en UsuarioBase
                string sqlBase =
                    "INSERT INTO UsuarioBase (IdRol, NumeroCuenta, Nombre, Correo, Contrasenia, Activo, CreatedAt) " +
                    "VALUES (@idRol, @cuenta, @nombre, @correo, @pass, 1, GETDATE()); " +
                    "SELECT SCOPE_IDENTITY();";

                object resultado = _db.EjecutarScalar(sqlBase, cmd =>
                {
                    cmd.Parameters.AddWithValue("@idRol", idRol);
                    cmd.Parameters.AddWithValue("@cuenta", numeroCuenta);
                    cmd.Parameters.AddWithValue("@nombre", nombre.Trim());
                    cmd.Parameters.AddWithValue("@correo", correo.Trim().ToLower());
                    cmd.Parameters.AddWithValue("@pass", password);
                });

                int nuevoId = Convert.ToInt32(resultado);

                // INSERT en tabla de rol
                if (rol == Rol.Lector)
                {
                    string sqlLector =
                        "INSERT INTO Lectores (IdUsuario, MaxPrestamosSimultaneos, DiasPrestamo, RestriccionActiva) " +
                        "VALUES (@id, 3, 14, 0)";
                    _db.EjecutarComando(sqlLector, cmd =>
                        cmd.Parameters.AddWithValue("@id", nuevoId));
                }
                else
                {
                    string sqlAdmin =
                        "INSERT INTO Administradores (IdUsuario, NivelAcceso, FechaAsignacion) " +
                        "VALUES (@id, 1, CAST(GETDATE() AS DATE))";
                    _db.EjecutarComando(sqlAdmin, cmd =>
                        cmd.Parameters.AddWithValue("@id", nuevoId));
                }

                return true;
            }
            catch (SqlException)
            {
                // Correo duplicado u otra restricción de BD
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ── Autenticar ─────────────────────────────────────────────────
        public Usuario Autenticar(string correo, string password)
        {
            try
            {
                string sql =
                    "SELECT u.IdUsuario, u.IdRol, u.NumeroCuenta, u.Nombre, u.Correo, " +
                    "       u.Contrasenia, u.Activo, u.CreatedAt " +
                    "FROM UsuarioBase u " +
                    "WHERE u.Correo = @correo AND u.Contrasenia = @pass AND u.Activo = 1 AND u.DeletedAt IS NULL";

                DataTable dt = _db.EjecutarConsulta(sql, cmd =>
                {
                    cmd.Parameters.AddWithValue("@correo", correo.Trim().ToLower());
                    cmd.Parameters.AddWithValue("@pass", password);
                });

                if (dt.Rows.Count == 0) return null;

                return MapearUsuario(dt.Rows[0]);
            }
            catch (Exception)
            {
                return null;
            }
        }

        // ── Obtener por ID ─────────────────────────────────────────────
        public Usuario ObtenerUsuario(int id)
        {
            try
            {
                string sql =
                    "SELECT u.IdUsuario, u.IdRol, u.NumeroCuenta, u.Nombre, u.Correo, " +
                    "       u.Contrasenia, u.Activo, u.CreatedAt " +
                    "FROM UsuarioBase u " +
                    "WHERE u.IdUsuario = @id AND u.DeletedAt IS NULL";

                DataTable dt = _db.EjecutarConsulta(sql, cmd =>
                    cmd.Parameters.AddWithValue("@id", id));

                if (dt.Rows.Count == 0) return null;
                return MapearUsuario(dt.Rows[0]);
            }
            catch (Exception)
            {
                return null;
            }
        }

        // ── Obtener por correo ─────────────────────────────────────────
        public Usuario ObtenerUsuarioPorCorreo(string correo)
        {
            try
            {
                string sql =
                    "SELECT u.IdUsuario, u.IdRol, u.NumeroCuenta, u.Nombre, u.Correo, " +
                    "       u.Contrasenia, u.Activo, u.CreatedAt " +
                    "FROM UsuarioBase u " +
                    "WHERE u.Correo = @correo AND u.DeletedAt IS NULL";

                DataTable dt = _db.EjecutarConsulta(sql, cmd =>
                    cmd.Parameters.AddWithValue("@correo", correo.Trim().ToLower()));

                if (dt.Rows.Count == 0) return null;
                return MapearUsuario(dt.Rows[0]);
            }
            catch (Exception)
            {
                return null;
            }
        }

        // ── Obtener todos ──────────────────────────────────────────────
        public List<Usuario> ObtenerTodosUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                string sql =
                    "SELECT u.IdUsuario, u.IdRol, u.NumeroCuenta, u.Nombre, u.Correo, " +
                    "       u.Contrasenia, u.Activo, u.CreatedAt " +
                    "FROM UsuarioBase u " +
                    "WHERE u.DeletedAt IS NULL " +
                    "ORDER BY u.Nombre";

                DataTable dt = _db.EjecutarConsulta(sql);
                foreach (DataRow row in dt.Rows)
                    lista.Add(MapearUsuario(row));
            }
            catch (Exception) { }
            return lista;
        }

        // ── Obtener activos ────────────────────────────────────────────
        public List<Usuario> ObtenerUsuariosActivos()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                string sql =
                    "SELECT u.IdUsuario, u.IdRol, u.NumeroCuenta, u.Nombre, u.Correo, " +
                    "       u.Contrasenia, u.Activo, u.CreatedAt " +
                    "FROM UsuarioBase u " +
                    "WHERE u.Activo = 1 AND u.DeletedAt IS NULL " +
                    "ORDER BY u.Nombre";

                DataTable dt = _db.EjecutarConsulta(sql);
                foreach (DataRow row in dt.Rows)
                    lista.Add(MapearUsuario(row));
            }
            catch (Exception) { }
            return lista;
        }

        // ── Actualizar ─────────────────────────────────────────────────
        public bool ActualizarUsuario(int id, string nombre, string correo, string password)
        {
            try
            {
                if (ExisteCorreo(correo, id)) return false;

                string sql =
                    "UPDATE UsuarioBase SET Nombre = @nombre, Correo = @correo, " +
                    "Contrasenia = @pass WHERE IdUsuario = @id AND DeletedAt IS NULL";

                int filas = _db.EjecutarComando(sql, cmd =>
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre.Trim());
                    cmd.Parameters.AddWithValue("@correo", correo.Trim().ToLower());
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@id", id);
                });

                return filas > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ── Activar / Desactivar ───────────────────────────────────────
        public bool DesactivarUsuario(int id)
        {
            try
            {
                string sql = "UPDATE UsuarioBase SET Activo = 0 WHERE IdUsuario = @id AND DeletedAt IS NULL";
                return _db.EjecutarComando(sql, cmd => cmd.Parameters.AddWithValue("@id", id)) > 0;
            }
            catch (Exception) { return false; }
        }

        public bool ActivarUsuario(int id)
        {
            try
            {
                string sql = "UPDATE UsuarioBase SET Activo = 1 WHERE IdUsuario = @id AND DeletedAt IS NULL";
                return _db.EjecutarComando(sql, cmd => cmd.Parameters.AddWithValue("@id", id)) > 0;
            }
            catch (Exception) { return false; }
        }

        // ── Eliminar (soft delete) ─────────────────────────────────────
        public bool EliminarUsuario(int id)
        {
            try
            {
                string sql = "UPDATE UsuarioBase SET DeletedAt = GETDATE(), Activo = 0 " +
                             "WHERE IdUsuario = @id AND DeletedAt IS NULL";
                return _db.EjecutarComando(sql, cmd => cmd.Parameters.AddWithValue("@id", id)) > 0;
            }
            catch (Exception) { return false; }
        }

        // ── Total ──────────────────────────────────────────────────────
        public int ObtenerTotalUsuarios()
        {
            try
            {
                object r = _db.EjecutarScalar("SELECT COUNT(*) FROM UsuarioBase WHERE DeletedAt IS NULL");
                return r != null ? Convert.ToInt32(r) : 0;
            }
            catch (Exception) { return 0; }
        }

        // ── Helpers privados ───────────────────────────────────────────
        private bool ExisteCorreo(string correo, int excluirId)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM UsuarioBase WHERE Correo = @correo " +
                             "AND IdUsuario <> @excluir AND DeletedAt IS NULL";
                object r = _db.EjecutarScalar(sql, cmd =>
                {
                    cmd.Parameters.AddWithValue("@correo", correo.Trim().ToLower());
                    cmd.Parameters.AddWithValue("@excluir", excluirId);
                });
                return r != null && Convert.ToInt32(r) > 0;
            }
            catch (Exception) { return false; }
        }

        /// <summary>Convierte un DataRow de UsuarioBase en un objeto Usuario.</summary>
        private Usuario MapearUsuario(DataRow row)
        {
            Usuario u = new Usuario();
            u.Id = Convert.ToInt32(row["IdUsuario"]);
            u.IdRol = Convert.ToInt32(row["IdRol"]);
            u.NumeroCuenta = row["NumeroCuenta"].ToString();
            u.Nombre = row["Nombre"].ToString();
            u.Correo = row["Correo"].ToString();
            u.Password = row["Contrasenia"].ToString();
            u.Activo = Convert.ToBoolean(row["Activo"]);

            if (row["CreatedAt"] != DBNull.Value)
                u.CreatedAt = Convert.ToDateTime(row["CreatedAt"]);

            // Mapear rol desde IdRol
            u.Rol = u.IdRol == 1 ? Rol.Lector : Rol.Administrador;

            return u;
        }
    }
}