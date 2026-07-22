using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logComprobantePago : IlogComprobantePago
    {
        private static readonly logComprobantePago _instancia = new logComprobantePago();
        public static logComprobantePago Instancia { get { return _instancia; } }

        public List<entComprobantePago> ListarComprobantes()
        {
            return datComprobantePago.Instancia.ListarComprobantes();
        }

        public Result<int> registrarComprobante(entComprobantePago cop)
        {
            if (cop.ClienteID <= 0)
                return Result<int>.Fail("Debe seleccionar un cliente.");

            if (cop.PedidoID <= 0)
                return Result<int>.Fail("Debe seleccionar un pedido.");

            if (string.IsNullOrWhiteSpace(cop.TipoComprobante))
                return Result<int>.Fail("El tipo de comprobante es obligatorio.");

            if (cop.MontoTotal <= 0)
                return Result<int>.Fail("El monto total debe ser mayor a cero.");

            try
            {
                int newId = datComprobantePago.Instancia.registrarComprobante(cop);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar comprobante: " + ex.Message);
            }
        }

        public Result<bool> deshabilitarComprobante(int comprobanteID)
        {
            if (comprobanteID <= 0)
                return Result<bool>.Fail("ID de comprobante inválido.");

            try
            {
                bool result = datComprobantePago.Instancia.deshabilitarComprobante(comprobanteID);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo anular el comprobante.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al anular comprobante: " + ex.Message);
            }
        }
    }
}
