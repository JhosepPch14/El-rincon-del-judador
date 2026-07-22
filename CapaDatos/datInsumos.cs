using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datInsumos : IdatInsumos
    {
        private static readonly datInsumos _instance = new datInsumos();
        public static datInsumos Instancia { get { return _instance; } }

        public List<entInsumos> ListarInsumos()
        {
            List<entInsumos> list = new List<entInsumos>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarInsumos", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new entInsumos
                        {
                            IdInsumo = Convert.ToInt32(dr["InsumosID"]),
                            NombreInsumo = dr["Nombre"].ToString(),
                            Cantidad = Convert.ToDecimal(dr["Cantidad"]),
                            EstadoInsumos = Convert.ToBoolean(dr["Estado"])
                        });
                    }
                }
            }
            return list;
        }

        public int InsertarInsumo(entInsumos ins)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(InsumosID), 0) + 1 FROM Insumos", cn))
                {
                    ins.IdInsumo = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spInsertarInsumo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@InsumosID", ins.IdInsumo);
                    cmd.Parameters.AddWithValue("@Nombre", ins.NombreInsumo);
                    cmd.Parameters.AddWithValue("@Cantidad", ins.Cantidad);
                    cmd.Parameters.AddWithValue("@Estado", ins.EstadoInsumos);
                    cmd.ExecuteNonQuery();
                }
            }
            return ins.IdInsumo;
        }

        public bool ModificarInsumo(entInsumos ins)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spModificarInsumo", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InsumosID", ins.IdInsumo);
                cmd.Parameters.AddWithValue("@Nombre", ins.NombreInsumo);
                cmd.Parameters.AddWithValue("@Cantidad", ins.Cantidad);
                cmd.Parameters.AddWithValue("@Estado", ins.EstadoInsumos);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool InhabilitarInsumo(int insumoID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spInhabilitarInsumo", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InsumosID", insumoID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
