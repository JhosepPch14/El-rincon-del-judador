using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logReqInsumos : IlogReqInsumos
    {
        private static readonly logReqInsumos _instancia = new logReqInsumos();
        public static logReqInsumos Instancia { get { return _instancia; } }

        public List<entReqInsumos> ListarReqInsumos()
        {
            return datReqInsumos.Instancia.ListarReq();
        }

        public Result<int> registrarReq(entReqInsumos req)
        {
            if (req.IDEncargado <= 0)
                return Result<int>.Fail("Debe seleccionar un encargado.");

            try
            {
                int newId = datReqInsumos.Instancia.registrarReq(req);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar requerimiento: " + ex.Message);
            }
        }

        public Result<bool> anularReq(int reqID)
        {
            if (reqID <= 0)
                return Result<bool>.Fail("ID de requerimiento inválido.");

            try
            {
                bool result = datReqInsumos.Instancia.anularReq(reqID);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo anular el requerimiento.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al anular requerimiento: " + ex.Message);
            }
        }
    }
}
