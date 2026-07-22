using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datDetallePedido : IdatDetallePedido
    {
        private static readonly datDetallePedido _instance = new datDetallePedido();
        public static datDetallePedido Instancia { get { return _instance; } }

        public List<entDetallePedido> ListarDetalles(int pedidoID)
        {
            List<entDetallePedido> list = new List<entDetallePedido>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarDetallePorPedido", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenpedidoID", pedidoID);
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new entDetallePedido
                        {
                            PedidoID = Convert.ToInt32(dr["OrdenpedidoID"]),
                            DetalleID = Convert.ToInt32(dr["DetallepedidoID"]),
                            PlatilloID = Convert.ToInt32(dr["PlatilloID"]),
                            NombrePlatillo = dr["NombrePlatillo"].ToString(),
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            Precio = Convert.ToDecimal(dr["Precio"]),
                            Subtotal = Convert.ToDecimal(dr["Subtotal"])
                        });
                    }
                }
            }
            return list;
        }

        public bool registrarDetalle(List<entDetallePedido> ldp, int pedidoID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlTransaction tran = cn.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in ldp)
                        {
                            using (SqlCommand cmd = new SqlCommand("spInsertarDetallePedido", cn, tran))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@OrdenpedidoID", pedidoID);
                                cmd.Parameters.AddWithValue("@PlatilloID", item.PlatilloID);
                                cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                                cmd.Parameters.AddWithValue("@Subtotal", item.Subtotal);
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
