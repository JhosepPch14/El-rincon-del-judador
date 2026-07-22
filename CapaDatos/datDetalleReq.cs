using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datDetalleReq : IdatDetalleReq
    {
        private static readonly datDetalleReq _instance = new datDetalleReq();
        public static datDetalleReq Instancia { get { return _instance; } }

        public List<entDetalleReq> ListarDetalles(int requerimientoID)
        {
            List<entDetalleReq> list = new List<entDetalleReq>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarDetalleReq", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequerimientoDeInsumoID", requerimientoID);
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new entDetalleReq
                        {
                            IDDetalle = Convert.ToInt32(dr["DetallesreqID"]),
                            IDRequerimiento = Convert.ToInt32(dr["RequerimientoDeInsumoID"]),
                            IDInsumo = Convert.ToInt32(dr["InsumosID"]),
                            NombreInsumo = dr["Nombre"].ToString(),
                            Cantidad = Convert.ToDecimal(dr["Cantidad"])
                        });
                    }
                }
            }
            return list;
        }

        public bool registrarDetalleReq(List<entDetalleReq> ldr, int requerimientoID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlTransaction tran = cn.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in ldr)
                        {
                            using (SqlCommand cmd = new SqlCommand("spInsertarDetalleReq", cn, tran))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@RequerimientoDeInsumoID", requerimientoID);
                                cmd.Parameters.AddWithValue("@InsumosID", item.IDInsumo);
                                cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        tran.Commit();
                        return true;
                    }
                    catch
                    {
                        tran.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}
