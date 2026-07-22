using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datMesero : IdatMesero
    {
        private static readonly datMesero _instance = new datMesero();
        public static datMesero Instancia { get { return _instance; } }

        public List<entMesero> ListarMesero()
        {
            List<entMesero> lista = new List<entMesero>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarMesero", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new entMesero
                        {
                            IdMesero = Convert.ToInt32(dr["MeseroID"]),
                            NombreMesero = dr["Nombre_Mesero"].ToString(),
                            DNIMesero = dr["DNI_Mesero"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]),
                            EstadoMesero = Convert.ToBoolean(dr["EstadoMesero"])
                        });
                    }
                }
            }
            return lista;
        }

        public int agregarMesero(entMesero m)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(MeseroID), 0) + 1 FROM Mesero", cn))
                {
                    m.IdMesero = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spInsertarMesero", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MeseroID", m.IdMesero);
                    cmd.Parameters.AddWithValue("@Nombre_Mesero", m.NombreMesero);
                    cmd.Parameters.AddWithValue("@DNI_Mesero", m.DNIMesero);
                    cmd.Parameters.AddWithValue("@Telefono", m.Telefono);
                    cmd.Parameters.AddWithValue("@FechaIngreso", m.FechaIngreso);
                    cmd.Parameters.AddWithValue("@EstadoMesero", m.EstadoMesero);
                    cmd.ExecuteNonQuery();
                }
            }
            return m.IdMesero;
        }

        public bool modificarMesero(entMesero m)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spEditarMesero", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MeseroID", m.IdMesero);
                cmd.Parameters.AddWithValue("@Nombre_Mesero", m.NombreMesero);
                cmd.Parameters.AddWithValue("@DNI_Mesero", m.DNIMesero);
                cmd.Parameters.AddWithValue("@Telefono", m.Telefono);
                cmd.Parameters.AddWithValue("@FechaIngreso", m.FechaIngreso);
                cmd.Parameters.AddWithValue("@EstadoMesero", m.EstadoMesero);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool inhabilitarMesero(int meseroID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spDeshabilitarMesero", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MeseroID", meseroID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
