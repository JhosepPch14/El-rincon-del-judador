using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logCompraReq : IlogCompraReq
    {
        private static readonly logCompraReq _instancia = new logCompraReq();
        public static logCompraReq Instancia { get { return _instancia; } }

        public List<entCompraReq> ListarCompraReq()
        {
            return datCompraReq.Instancia.ListarCompraReq();
        }

        public Result<int> registrarCompraReq(entCompraReq cr)
        {
            if (string.IsNullOrWhiteSpace(cr.Encargado))
                return Result<int>.Fail("El nombre del encargado es obligatorio.");

            if (string.IsNullOrWhiteSpace(cr.MetodoPago))
                return Result<int>.Fail("El método de pago es obligatorio.");

            if (cr.MontoTotal <= 0)
                return Result<int>.Fail("El monto total debe ser mayor a cero.");

            if (cr.IDProveedor <= 0)
                return Result<int>.Fail("Debe seleccionar un proveedor.");

            try
            {
                int newId = datCompraReq.Instancia.registrarCompraReq(cr);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar compra: " + ex.Message);
            }
        }

        public Result<bool> anularCompraReq(int idCompra)
        {
            if (idCompra <= 0)
                return Result<bool>.Fail("ID de compra inválido.");

            try
            {
                bool result = datCompraReq.Instancia.anularCompraReq(idCompra);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo anular la compra.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al anular compra: " + ex.Message);
            }
        }
    }
}
