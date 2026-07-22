using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datEnAlmacen : IdatEnAlmacen
    {
        private static readonly datEnAlmacen _instance = new datEnAlmacen();
        public static datEnAlmacen Instancia { get { return _instance; } }

        public List<entEnAlmacen> ListarEnAlmacen()
        {
            List<entEnAlmacen> lista = new List<entEnAlmacen>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarEnAlmacen", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new entEnAlmacen
                        {
                            IDEnAlmacen = Convert.ToInt32(dr["EncargadoalmacenID"]),
                            DNI = dr["DNI"].ToString(),
                            Nombre = dr["Nombre"].ToString(),
                            Numero = dr["Numero"].ToString(),
                            FechaIngreso = Convert.ToDateTime(dr["FechaRegistro"]),
                            Estado = Convert.ToBoolean(dr["Estado"])
                        });
                    }
                }
            }
            return lista;
        }

        public int agregarEnAlmacen(entEnAlmacen ea)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(EncargadoalmacenID), 0) + 1 FROM Encargadoalmacen", cn))
                {
                    ea.IDEnAlmacen = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spInsertarEnAlmacen", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EncargadoalmacenID", ea.IDEnAlmacen);
                    cmd.Parameters.AddWithValue("@DNI", ea.DNI);
                    cmd.Parameters.AddWithValue("@Nombre", ea.Nombre);
                    cmd.Parameters.AddWithValue("@Numero", ea.Numero);
                    cmd.Parameters.AddWithValue("@FechaRegistro", ea.FechaIngreso);
                    cmd.Parameters.AddWithValue("@Estado", ea.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
            return ea.IDEnAlmacen;
        }

        public bool modificarEnAlmacen(entEnAlmacen ea)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spEditarEnAlmacen", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EncargadoalmacenID", ea.IDEnAlmacen);
                cmd.Parameters.AddWithValue("@Nombre", ea.Nombre);
                cmd.Parameters.AddWithValue("@DNI", ea.DNI);
                cmd.Parameters.AddWithValue("@Numero", ea.Numero);
                cmd.Parameters.AddWithValue("@FechaIngreso", ea.FechaIngreso);
                cmd.Parameters.AddWithValue("@Estado", ea.Estado);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool inhabilitarEnAlmacen(int idAlmacen)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spDeshabilitarEnAlmacen", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EncargadoalmacenID", idAlmacen);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
