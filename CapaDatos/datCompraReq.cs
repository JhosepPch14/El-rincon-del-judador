using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datCompraReq : IdatCompraReq
    {
        private static readonly datCompraReq _instance = new datCompraReq();
        public static datCompraReq Instancia { get { return _instance; } }

        public List<entCompraReq> ListarCompraReq()
        {
            List<entCompraReq> lista = new List<entCompraReq>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarCompraReq", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new entCompraReq
                        {
                            IdCompra = Convert.ToInt32(dr["ComprainsumosID"]),
                            Encargado = dr["Encargado"].ToString(),
                            FechaCompra = Convert.ToDateTime(dr["FechaCompra"]),
                            MetodoPago = dr["MetodoPago"].ToString(),
                            MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                            IDRequerimiento = Convert.ToInt32(dr["RequerimientoDeInsumoID"]),
                            IDProveedor = Convert.ToInt32(dr["ProveedorID"]),
                            EstadoCompra = Convert.ToBoolean(dr["EstadoCompra"])
                        });
                    }
                }
            }
            return lista;
        }

        public int registrarCompraReq(entCompraReq cr)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(ComprainsumosID), 0) + 1 FROM Comprainsumos", cn))
                {
                    cr.IdCompra = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spRegistrarCompraReq", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ComprainsumosID", cr.IdCompra);
                    cmd.Parameters.AddWithValue("@Encargado", cr.Encargado);
                    cmd.Parameters.AddWithValue("@FechaCompra", cr.FechaCompra);
                    cmd.Parameters.AddWithValue("@MetodoPago", cr.MetodoPago);
                    cmd.Parameters.AddWithValue("@MontoTotal", cr.MontoTotal);
                    cmd.Parameters.AddWithValue("@EstadoCompra", cr.EstadoCompra);
                    cmd.Parameters.AddWithValue("@RequerimientoDeInsumoID", cr.IDRequerimiento);
                    cmd.Parameters.AddWithValue("@ProveedorID", cr.IDProveedor);
                    cmd.ExecuteNonQuery();
                }
            }
            return cr.IdCompra;
        }

        public bool anularCompraReq(int idCompra)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spAnularCompraReq", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ComprainsumosID", idCompra);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
