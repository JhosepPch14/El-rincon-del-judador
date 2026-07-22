using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datPlatillo : IdatPlatillo
    {
        private static readonly datPlatillo _instance = new datPlatillo();
        public static datPlatillo Instancia { get { return _instance; } }

        public List<entPlatillo> ListarPlatillo()
        {
            List<entPlatillo> list = new List<entPlatillo>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarPlatillos", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new entPlatillo
                        {
                            IdPlatillo = Convert.ToInt32(dr["PlatilloID"]),
                            NombrePlatillo = dr["NombrePlatillo"].ToString(),
                            PrecioPlatillo = Convert.ToDecimal(dr["Precio"]),
                            EstadoPlatillo = Convert.ToBoolean(dr["EstadoPlatillo"]),
                            IdTipoPlatillo = Convert.ToInt32(dr["TipoPlatilloID"])
                        });
                    }
                }
            }
            return list;
        }

        public int InsertarPlatillo(entPlatillo pl)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(PlatilloID), 0) + 1 FROM Platillo", cn))
                {
                    pl.IdPlatillo = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spInsertarPlatillo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlatilloID", pl.IdPlatillo);
                    cmd.Parameters.AddWithValue("@NombrePlatillo", pl.NombrePlatillo);
                    cmd.Parameters.AddWithValue("@Precio", pl.PrecioPlatillo);
                    cmd.Parameters.AddWithValue("@TipoPlatilloID", pl.IdTipoPlatillo);
                    cmd.Parameters.AddWithValue("@EstadoPlatillo", pl.EstadoPlatillo);
                    cmd.ExecuteNonQuery();
                }
            }
            return pl.IdPlatillo;
        }

        public bool EditarPlatillo(entPlatillo pl)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spEditarPlatillo", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlatilloID", pl.IdPlatillo);
                cmd.Parameters.AddWithValue("@NombrePlatillo", pl.NombrePlatillo);
                cmd.Parameters.AddWithValue("@Precio", pl.PrecioPlatillo);
                cmd.Parameters.AddWithValue("@EstadoPlatillo", pl.EstadoPlatillo);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeshabilitarPlatillo(int platilloID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spDeshabilitarPlatillo", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlatilloID", platilloID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
