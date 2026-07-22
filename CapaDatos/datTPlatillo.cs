using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datTPlatillo : IdatTPlatillo
    {
        private static readonly datTPlatillo _instance = new datTPlatillo();
        public static datTPlatillo Instancia { get { return _instance; } }

        public List<entTPlatillo> ListarTPlatillo()
        {
            List<entTPlatillo> list = new List<entTPlatillo>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarTiposPlatillo", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new entTPlatillo
                        {
                            IdTipoPlatillo = Convert.ToInt32(dr["IdTipoPlatillo"]),
                            NombreTipo = dr["NombreTipo"].ToString(),
                            EstadoTPlatillo = Convert.ToBoolean(dr["Estado"])
                        });
                    }
                }
            }
            return list;
        }

        public int agregarTPlatillo(entTPlatillo tp)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(IdTipoPlatillo), 0) + 1 FROM Tipoplatillo", cn))
                {
                    tp.IdTipoPlatillo = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spInsertarTipoPlatillo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdTipoPlatillo", tp.IdTipoPlatillo);
                    cmd.Parameters.AddWithValue("@NombreTipo", tp.NombreTipo);
                    cmd.Parameters.AddWithValue("@Estado", tp.EstadoTPlatillo);
                    cmd.ExecuteNonQuery();
                }
            }
            return tp.IdTipoPlatillo;
        }

        public bool modificarTPlatillo(entTPlatillo tp)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spEditarTipoPlatillo", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoPlatillo", tp.IdTipoPlatillo);
                cmd.Parameters.AddWithValue("@NombreTipo", tp.NombreTipo);
                cmd.Parameters.AddWithValue("@Estado", tp.EstadoTPlatillo);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool inhabilitarTPlatillo(int idTipo)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spDeshabilitarTipoPlatillo", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoPlatillo", idTipo);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
