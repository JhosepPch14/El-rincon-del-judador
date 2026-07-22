using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logDetallePedido : IlogDetallePedido
    {
        private static readonly logDetallePedido _instancia = new logDetallePedido();
        public static logDetallePedido Instancia { get { return _instancia; } }

        public List<entDetallePedido> ListarDetalles(int pedidoID)
        {
            return datDetallePedido.Instancia.ListarDetalles(pedidoID);
        }

        public bool registrarDetallePedido(List<entDetallePedido> ldp, int pedidoID)
        {
            if (ldp == null || ldp.Count == 0)
                return false;

            return datDetallePedido.Instancia.registrarDetalle(ldp, pedidoID);
        }

        public decimal CalcularTotalPorPedido(int pedidoID)
        {
            List<entDetallePedido> detalles = datDetallePedido.Instancia.ListarDetalles(pedidoID);
            return detalles.Sum(d => d.Subtotal);
        }
    }
}
