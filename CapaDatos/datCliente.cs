using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datCliente : IdatCliente
    {
        private static readonly datCliente _instance = new datCliente();
        public static datCliente Instancia { get { return _instance; } }

        public List<entCliente> ListarCliente()
        {
            List<entCliente> lista = new List<entCliente>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarClientes", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new entCliente
                        {
                            ClienteID = Convert.ToInt32(dr["ClienteID"]),
                            Nombre_Cliente = dr["Nombre_Cliente"].ToString(),
                            DNI = dr["DNI"].ToString(),
                            Numero = dr["Numero"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            Fecha = Convert.ToDateTime(dr["Fecha"]),
                            EstadoCliente = Convert.ToBoolean(dr["EstadoCliente"])
                        });
                    }
                }
            }
            return lista;
        }

        public int agregarCliente(entCliente Cli)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(ClienteID), 0) + 1 FROM Cliente", cn))
                {
                    Cli.ClienteID = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spInsertarCliente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
                    cmd.Parameters.AddWithValue("@Nombre_Cliente", Cli.Nombre_Cliente);
                    cmd.Parameters.AddWithValue("@DNI", Cli.DNI);
                    cmd.Parameters.AddWithValue("@Numero", Cli.Numero);
                    cmd.Parameters.AddWithValue("@Correo", Cli.Correo);
                    cmd.Parameters.AddWithValue("@Fecha", Cli.Fecha);
                    cmd.Parameters.AddWithValue("@EstadoCliente", Cli.EstadoCliente);
                    cmd.ExecuteNonQuery();
                }
            }
            return Cli.ClienteID;
        }

        public bool modificarCliente(entCliente Cli)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spEditarCliente", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
                cmd.Parameters.AddWithValue("@Nombre_Cliente", Cli.Nombre_Cliente);
                cmd.Parameters.AddWithValue("@DNI", Cli.DNI);
                cmd.Parameters.AddWithValue("@Numero", Cli.Numero);
                cmd.Parameters.AddWithValue("@Correo", Cli.Correo);
                cmd.Parameters.AddWithValue("@Fecha", Cli.Fecha);
                cmd.Parameters.AddWithValue("@EstadoCliente", Cli.EstadoCliente);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool inhabilitarCliente(int clienteID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spDeshabilitarCliente", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
