using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datProveedor : IdatProveedor
    {
        private static readonly datProveedor _instance = new datProveedor();
        public static datProveedor Instancia { get { return _instance; } }

        public List<entProveedor> ListarProveedor()
        {
            List<entProveedor> lista = new List<entProveedor>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarProveedores", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new entProveedor
                        {
                            IdProveedor = Convert.ToInt32(dr["ProveedorID"]),
                            NombreProveedor = dr["NombreProveedor"].ToString(),
                            RUC = dr["RUC"].ToString(),
                            EmailProveedor = dr["EmailProveedor"].ToString(),
                            FechaRProveedor = Convert.ToDateTime(dr["FechaProveedor"]),
                            EstadoProveedor = Convert.ToBoolean(dr["EstadoProveedor"])
                        });
                    }
                }
            }
            return lista;
        }

        public int InsertarProveedor(entProveedor pr)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(ProveedorID), 0) + 1 FROM Proveedor", cn))
                {
                    pr.IdProveedor = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spInsertarProveedor", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProveedorID", pr.IdProveedor);
                    cmd.Parameters.AddWithValue("@NombreProveedor", pr.NombreProveedor);
                    cmd.Parameters.AddWithValue("@RUC", pr.RUC);
                    cmd.Parameters.AddWithValue("@EmailProveedor", pr.EmailProveedor);
                    cmd.Parameters.AddWithValue("@FechaProveedor", pr.FechaRProveedor);
                    cmd.Parameters.AddWithValue("@EstadoProveedor", pr.EstadoProveedor);
                    cmd.ExecuteNonQuery();
                }
            }
            return pr.IdProveedor;
        }

        public bool EditarProveedor(entProveedor pr)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spEditarProveedor", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", pr.IdProveedor);
                cmd.Parameters.AddWithValue("@NombreProveedor", pr.NombreProveedor);
                cmd.Parameters.AddWithValue("@RUC", pr.RUC);
                cmd.Parameters.AddWithValue("@EmailProveedor", pr.EmailProveedor);
                cmd.Parameters.AddWithValue("@FechaProveedor", pr.FechaRProveedor);
                cmd.Parameters.AddWithValue("@EstadoProveedor", pr.EstadoProveedor);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeshabilitarProveedor(int proveedorID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spDeshabilitarProveedor", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", proveedorID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
