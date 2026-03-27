using System;
using System.Data;
using System.Data.SqlClient;

namespace BiblioTech.Data
{
    /// <summary>
    /// Clase de conexión dedicada a todas las operaciones de base de datos
    /// relacionadas con la tabla Multas y TipoMulta.
    /// </summary>
    public class ConexionMulta
    {
        private const string CADENA =
            "Server=CROKIEE\\SQLEXPRESS;Database=master;" +
            "Trusted_Connection=True;";

        public SqlConnection AbrirConexion()
        {
            SqlConnection con = new SqlConnection(CADENA);
            con.Open();
            return con;
        }

        public bool ProbarConexion(out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection con = AbrirConexion())
                {
                    mensaje = "Conexión a Multas exitosa.";
                    return true;
                }
            }
            catch (SqlException ex)
            {
                mensaje = "Error SQL (multas): " + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error inesperado (multas): " + ex.Message;
                return false;
            }
        }

        public int EjecutarComando(string sql, Action<SqlCommand> parametros = null)
        {
            using (SqlConnection con = AbrirConexion())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                parametros?.Invoke(cmd);
                return cmd.ExecuteNonQuery();
            }
        }

        public object EjecutarScalar(string sql, Action<SqlCommand> parametros = null)
        {
            using (SqlConnection con = AbrirConexion())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                parametros?.Invoke(cmd);
                return cmd.ExecuteScalar();
            }
        }

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