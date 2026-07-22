using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datOrdenPedido : IdatOrdenPedido
    {
        private static readonly datOrdenPedido _instance = new datOrdenPedido();
        public static datOrdenPedido Instancia { get { return _instance; } }

        public List<entOrdenPedido> ListarOrden()
        {
            List<entOrdenPedido> lista = new List<entOrdenPedido>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarOrdenPedido", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new entOrdenPedido
                        {
                            PedidoID = Convert.ToInt32(dr["OrdenpedidoID"]),
                            Fecha = Convert.ToDateTime(dr["Fecha"]),
                            NroMesa = Convert.ToInt32(dr["NroMesa"]),
                            Total = Convert.ToDecimal(dr["Total"]),
                            EstadoPedido = Convert.ToBoolean(dr["Estado"]),
                            NombreMesero = dr["Nombre_Mesero"].ToString(),
                            MeseroID = Convert.ToInt32(dr["MeseroID"])
                        });
                    }
                }
            }
            return lista;
        }

        public int agregarOrden(entOrdenPedido op)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(OrdenpedidoID), 0) + 1 FROM Ordenpedido", cn))
                {
                    op.PedidoID = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spAgregarOrdenPedido", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrdenpedidoID", op.PedidoID);
                    cmd.Parameters.AddWithValue("@Fecha", op.Fecha);
                    cmd.Parameters.AddWithValue("@NroMesa", op.NroMesa);
                    cmd.Parameters.AddWithValue("@Total", op.Total);
                    cmd.Parameters.AddWithValue("@Estado", op.EstadoPedido);
                    cmd.Parameters.AddWithValue("@MeseroID", op.MeseroID);
                    cmd.ExecuteNonQuery();
                }
            }
            return op.PedidoID;
        }

        public bool modificarOrden(entOrdenPedido op)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spModificarOrden", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenpedidoID", op.PedidoID);
                cmd.Parameters.AddWithValue("@NroMesa", op.NroMesa);
                cmd.Parameters.AddWithValue("@Total", op.Total);
                cmd.Parameters.AddWithValue("@Estado", op.EstadoPedido);
                cmd.Parameters.AddWithValue("@MeseroID", op.MeseroID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool inhabilitarOrden(int pedidoID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spDeshabilitarOrdenPedido", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenpedidoID", pedidoID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool actualizarTotal(int pedidoID, decimal total)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spActualizarTotalOrden", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PedidoID", pedidoID);
                cmd.Parameters.AddWithValue("@Total", total);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
