using System;
using System.Data;
using System.Data.SqlClient;

El contenido es generado por usuarios y no está verificado.
1
using System;
using System.Data;
using System.Data.SqlClient;

namespace BiblioTech.Data
{
    /// <summary>
    /// Clase de conexión dedicada a todas las operaciones de base de datos
    /// relacionadas con la tabla UsuarioBase, Lectores y Administradores.
    /// La cadena de conexión apunta al servidor CROKIEE\SQLEXPRESS / database master.
    /// </summary>
    public class ConexionUsuario
    {
        // ── Cadena de conexión ─────────────────────────────────────────
        private const string CADENA =
            "Server=CROKIEE\\SQLEXPRESS;Database=master;" +
            "Trusted_Connection=True;";

        // ── Abrir conexión ─────────────────────────────────────────────
        /// <summary>
        /// Abre y devuelve una nueva SqlConnection lista para usar.
        /// El llamador es responsable de cerrarla (usar dentro de using).
        /// </summary>
        public SqlConnection AbrirConexion()
        {
            SqlConnection con = new SqlConnection(CADENA);
            con.Open();
            return con;
        }

        // ── Probar conexión ────────────────────────────────────────────
        /// <summary>
        /// Verifica si se puede establecer conexión con el servidor.
        /// Útil para mostrar un mensaje en el arranque de la aplicación.
        /// </summary>
        public bool ProbarConexion(out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection con = AbrirConexion())
                {
                    mensaje = "Conexión a UsuarioBase exitosa.";
                    return true;
                }
            }
            catch (SqlException ex)
            {
                mensaje = "Error SQL (usuarios): " + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error inesperado (usuarios): " + ex.Message;
                return false;
            }
        }

        // ── Ejecutar comando sin resultado ─────────────────────────────
        /// <summary>
        /// Ejecuta un INSERT, UPDATE o DELETE y devuelve las filas afectadas.
        /// Lanza excepción si falla (el controller la captura).
        /// </summary>
        public int EjecutarComando(string sql, Action<SqlCommand> parametros = null)
        {
            using (SqlConnection con = AbrirConexion())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                parametros?.Invoke(cmd);
                return cmd.ExecuteNonQuery();
            }
        }

        // ── Ejecutar scalar ────────────────────────────────────────────
        /// <summary>
        /// Ejecuta un SELECT que devuelve un solo valor (ej. SELECT @@IDENTITY).
        /// </summary>
        public object EjecutarScalar(string sql, Action<SqlCommand> parametros = null)
        {
            using (SqlConnection con = AbrirConexion())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                parametros?.Invoke(cmd);
                return cmd.ExecuteScalar();
            }
        }

        // ── Ejecutar consulta ──────────────────────────────────────────
        /// <summary>
        /// Ejecuta un SELECT y devuelve un DataTable con los resultados.
        /// </summary>
        public DataTable EjecutarConsulta(string sql, Action<SqlCommand> parametros = null)
        {
            using (SqlConnection con = AbrirConexion())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                parametros?.Invoke(cmd);
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    da.Fill(dt);
                return dt;
            }
        }
    }
}