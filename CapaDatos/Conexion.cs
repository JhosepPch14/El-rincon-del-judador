using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia{
            get{ return Conexion._instancia; }
        }
        public SqlConnection Conectar() {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            return cn;
        }
    }
}
