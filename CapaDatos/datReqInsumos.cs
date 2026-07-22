using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datReqInsumos : IdatReqInsumos
    {
        private static readonly datReqInsumos _instance = new datReqInsumos();
        public static datReqInsumos Instancia { get { return _instance; } }

        public List<entReqInsumos> ListarReq()
        {
            List<entReqInsumos> list = new List<entReqInsumos>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spListarRequerimientos", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new entReqInsumos
                        {
                            IDRequerimiento = Convert.ToInt32(dr["RequerimientoDeInsumoID"]),
                            FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                            Estado = Convert.ToBoolean(dr["Estado"]),
                            IDEncargado = Convert.ToInt32(dr["IDEncargado"])
                        });
                    }
                }
            }
            return list;
        }

        public int registrarReq(entReqInsumos req)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                using (SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(RequerimientoDeInsumoID), 0) + 1 FROM RequerimientoDeInsumo", cn))
                {
                    req.IDRequerimiento = (int)cmdMax.ExecuteScalar();
                }
                using (SqlCommand cmd = new SqlCommand("spRegistrarRequerimiento", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RequerimientoDeInsumoID", req.IDRequerimiento);
                    cmd.Parameters.AddWithValue("@Estado", req.Estado);
                    cmd.Parameters.AddWithValue("@FechaRegistro", req.FechaRegistro);
                    cmd.Parameters.AddWithValue("@EncargadoalmacenID", req.IDEncargado);
                    cmd.ExecuteNonQuery();
                }
            }
            return req.IDRequerimiento;
        }

        public bool anularReq(int reqID)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand("spAnularRequerimiento", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequerimientoDeInsumoID", reqID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
