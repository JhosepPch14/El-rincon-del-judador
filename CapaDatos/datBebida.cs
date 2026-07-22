using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datBebida : IdatBebida
    {
        private static readonly datBebida _instance = new datBebida();
        public static datBebida Instancia { get { return _instance; } }

        public List<entBebida> ListarBebida()
        {
            List<entBebida> list = new List<entBebida>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarBebidas", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new entBebida
                        {
                            IdBebida = Convert.ToInt32(dr["BebidaID"]),
                            NombreBebida = dr["Nombre_Bebida"].ToString(),
                            Precio = Convert.ToDecimal(dr["Precio"]),
                            Tamaño = dr["TamañoBebida"].ToString(),
                            EstadoBebida = Convert.ToBoolean(dr["EstadoBebida"]),
                            TipoBebida = Convert.ToInt32(dr["TipobebidaID"])
                        });
                    }
                }
            }
            return list;
        }

        public int agregarBebida(entBebida b)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(BebidaID), 0) + 1 FROM Bebida", cn))
                {
                    b.IdBebida = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spInsertarBebida", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BebidaID", b.IdBebida);
                    cmd.Parameters.AddWithValue("@Nombre_Bebida", b.NombreBebida);
                    cmd.Parameters.AddWithValue("@Precio", b.Precio);
                    cmd.Parameters.AddWithValue("@TamañoBebida", b.Tamaño);
                    cmd.Parameters.AddWithValue("@EstadoBebida", b.EstadoBebida);
                    cmd.Parameters.AddWithValue("@TipobebidaID", b.TipoBebida);
                    cmd.ExecuteNonQuery();
                }
            }
            return b.IdBebida;
        }

        public bool modificarBebida(entBebida b)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spEditarBebida", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BebidaID", b.IdBebida);
                cmd.Parameters.AddWithValue("@Nombre_Bebida", b.NombreBebida);
                cmd.Parameters.AddWithValue("@Precio", b.Precio);
                cmd.Parameters.AddWithValue("@TamañoBebida", b.Tamaño);
                cmd.Parameters.AddWithValue("@EstadoBebida", b.EstadoBebida);
                cmd.Parameters.AddWithValue("@TipobebidaID", b.TipoBebida);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool inhabilitarBebida(int bebidaID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spDeshabilitarBebida", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BebidaID", bebidaID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
