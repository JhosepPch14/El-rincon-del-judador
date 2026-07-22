using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datTipoBebida : IdatTipoBebida
    {
        private static readonly datTipoBebida _instance = new datTipoBebida();
        public static datTipoBebida Instancia => _instance;

        public List<entTipoBebida> ListarTBebida()
        {
            List<entTipoBebida> list = new List<entTipoBebida>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarTipoBebida", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new entTipoBebida
                        {
                            IdTipoBebida = Convert.ToInt32(dr["IdTipoBebida"]),
                            NombreTipo = dr["NombreTipo"].ToString(),
                            Estado = Convert.ToBoolean(dr["Estado"])
                        });
                    }
                }
            }
            return list;
        }

        public int InsertarTBebida(entTipoBebida tb)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(IdTipoBebida), 0) + 1 FROM Tipobebida", cn))
                {
                    tb.IdTipoBebida = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spInsertarTipoBebida", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdTipoBebida", tb.IdTipoBebida);
                    cmd.Parameters.AddWithValue("@NombreTipo", tb.NombreTipo);
                    cmd.Parameters.AddWithValue("@Estado", tb.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
            return tb.IdTipoBebida;
        }

        public bool ModificarTBebida(entTipoBebida tb)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spModificarTipoBebida", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoBebida", tb.IdTipoBebida);
                cmd.Parameters.AddWithValue("@NombreTipo", tb.NombreTipo);
                cmd.Parameters.AddWithValue("@Estado", tb.Estado);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool InhabilitarTBebida(int idTipo)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spInhabilitarTipoBebida", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoBebida", idTipo);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
