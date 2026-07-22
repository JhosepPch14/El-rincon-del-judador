using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datComprobantePago : IdatComprobantePago
    {
        private static readonly datComprobantePago _instance = new datComprobantePago();
        public static datComprobantePago Instancia { get { return _instance; } }

        public List<entComprobantePago> ListarComprobantes()
        {
            List<entComprobantePago> lista = new List<entComprobantePago>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarComprobantes", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new entComprobantePago
                        {
                            ComprobanteID = Convert.ToInt32(dr["ComprobanteDeVentaID"]),
                            PedidoID = Convert.ToInt32(dr["OrdenpedidoID"]),
                            ClienteID = Convert.ToInt32(dr["ClienteID"]),
                            FechaEmision = Convert.ToDateTime(dr["FechaEmision"]),
                            TipoComprobante = dr["TipoComprobante"].ToString(),
                            MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                            EstadoComprobante = Convert.ToBoolean(dr["EstadoComprobante"])
                        });
                    }
                }
            }
            return lista;
        }

        public int registrarComprobante(entComprobantePago cop)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(ComprobanteDeVentaID), 0) + 1 FROM ComprobanteDeVenta", cn))
                {
                    cop.ComprobanteID = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spInsertarComprobante", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ComprobanteDeVentaID", cop.ComprobanteID);
                    cmd.Parameters.AddWithValue("@ClienteID", cop.ClienteID);
                    cmd.Parameters.AddWithValue("@OrdenpedidoID", cop.PedidoID);
                    cmd.Parameters.AddWithValue("@TipoComprobante", cop.TipoComprobante);
                    cmd.Parameters.AddWithValue("@MontoTotal", cop.MontoTotal);
                    cmd.Parameters.AddWithValue("@FechaEmision", cop.FechaEmision);
                    cmd.Parameters.AddWithValue("@EstadoComprobante", cop.EstadoComprobante);
                    cmd.ExecuteNonQuery();
                }
            }
            return cop.ComprobanteID;
        }

        public bool deshabilitarComprobante(int comprobanteID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spAnularComprobante", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ComprobanteDeVentaID", comprobanteID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
