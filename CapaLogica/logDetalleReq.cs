using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logDetalleReq : IlogDetalleReq
    {
        private static readonly logDetalleReq _instancia = new logDetalleReq();
        public static logDetalleReq Instancia { get { return _instancia; } }

        public List<entDetalleReq> ListarDetallesReq(int requerimientoID)
        {
            return datDetalleReq.Instancia.ListarDetalles(requerimientoID);
        }

        public bool registrarDetalleReq(List<entDetalleReq> ldr, int requerimientoID)
        {
            if (ldr == null || ldr.Count == 0)
                return false;

            return datDetalleReq.Instancia.registrarDetalleReq(ldr, requerimientoID);
        }
    }
}
