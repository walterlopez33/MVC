using Microsoft.Data.SqlClient;

namespace DataAccess.ACME
{
    public class Conexion
    {
        private readonly string? _cadenaConexion;

        public Conexion()
        {
            string? cadenaConexion;

            // Obtener la cadena de conexion desde la variable de entorno
            cadenaConexion = Environment.GetEnvironmentVariable("SQLServerXE");

            _cadenaConexion = cadenaConexion;
        }

        public SqlConnection Conectar ()
        {
            SqlConnection sqlConn;

            //Instancias la conexion utilizando la cadena de conexion obtenida
            sqlConn = new SqlConnection (_cadenaConexion);

            return sqlConn;
        }
    }
}
