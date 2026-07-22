using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logOrdenPedido : IlogOrdenPedido
    {
        private static readonly logOrdenPedido _instancia = new logOrdenPedido();
        public static logOrdenPedido Instancia { get { return _instancia; } }

        public List<entOrdenPedido> ListarOrdenes()
        {
            return datOrdenPedido.Instancia.ListarOrden();
        }

        public Result<int> agregarOrden(entOrdenPedido op)
        {
            if (op.NroMesa <= 0)
                return Result<int>.Fail("El número de mesa debe ser mayor a cero.");

            if (op.MeseroID <= 0)
                return Result<int>.Fail("Debe seleccionar un mesero.");

            try
            {
                int newId = datOrdenPedido.Instancia.agregarOrden(op);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar orden: " + ex.Message);
            }
        }

        public Result<bool> modificarOrden(entOrdenPedido op)
        {
            if (op.PedidoID <= 0)
                return Result<bool>.Fail("ID de pedido inválido.");

            try
            {
                bool result = datOrdenPedido.Instancia.modificarOrden(op);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo modificar la orden.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al modificar orden: " + ex.Message);
            }
        }

        public Result<bool> inhabilitarOrden(int pedidoID)
        {
            if (pedidoID <= 0)
                return Result<bool>.Fail("ID de pedido inválido.");

            try
            {
                bool result = datOrdenPedido.Instancia.inhabilitarOrden(pedidoID);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo inhabilitar la orden.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al inhabilitar orden: " + ex.Message);
            }
        }

        public bool actualizarTotal(int pedidoID, decimal total)
        {
            return datOrdenPedido.Instancia.actualizarTotal(pedidoID, total);
        }
    }
}
