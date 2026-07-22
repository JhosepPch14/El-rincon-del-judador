using System.Collections.Generic;
using CapaEntidad;

namespace CapaLogica
{
    public interface IlogCliente
    {
        List<entCliente> ListarCliente();
        Result<int> agregarCliente(entCliente Cli);
        Result<bool> modificarCliente(entCliente Cli);
        Result<bool> inhabilitarCliente(int clienteID);
    }

    public interface IlogBebida
    {
        List<entBebida> ListarBebida();
        Result<int> agregarBebida(entBebida b);
        Result<bool> modificarBebida(entBebida b);
        Result<bool> inhabilitarBebida(int bebidaID);
    }

    public interface IlogPlatillo
    {
        List<entPlatillo> ListarPlatillo();
        Result<int> InsertarPlatillo(entPlatillo pl);
        Result<bool> EditarPlatillo(entPlatillo pl);
        Result<bool> DeshabilitarPlatillo(int platilloID);
    }

    public interface IlogOrdenPedido
    {
        List<entOrdenPedido> ListarOrdenes();
        Result<int> agregarOrden(entOrdenPedido op);
        Result<bool> modificarOrden(entOrdenPedido op);
        Result<bool> inhabilitarOrden(int pedidoID);
        bool actualizarTotal(int pedidoID, decimal total);
    }

    public interface IlogDetallePedido
    {
        List<entDetallePedido> ListarDetalles(int pedidoID);
        bool registrarDetallePedido(List<entDetallePedido> ldp, int pedidoID);
        decimal CalcularTotalPorPedido(int pedidoID);
    }

    public interface IlogComprobantePago
    {
        List<entComprobantePago> ListarComprobantes();
        Result<int> registrarComprobante(entComprobantePago cop);
        Result<bool> deshabilitarComprobante(int comprobanteID);
    }

    public interface IlogCompraReq
    {
        List<entCompraReq> ListarCompraReq();
        Result<int> registrarCompraReq(entCompraReq cr);
        Result<bool> anularCompraReq(int idCompra);
    }

    public interface IlogInsumos
    {
        List<entInsumos> ListarInsumos();
        Result<int> InsertarInsumo(entInsumos ins);
        Result<bool> ModificarInsumo(entInsumos ins);
        Result<bool> InhabilitarInsumo(int insumoID);
    }

    public interface IlogReqInsumos
    {
        List<entReqInsumos> ListarReqInsumos();
        Result<int> registrarReq(entReqInsumos req);
        Result<bool> anularReq(int reqID);
    }

    public interface IlogDetalleReq
    {
        List<entDetalleReq> ListarDetallesReq(int requerimientoID);
        bool registrarDetalleReq(List<entDetalleReq> ldr, int requerimientoID);
    }

    public interface IlogEnAlmacen
    {
        List<entEnAlmacen> ListarEnAlmacen();
        Result<int> agregarEnAlmacen(entEnAlmacen ea);
        Result<bool> modificarEnAlmacen(entEnAlmacen ea);
        Result<bool> inhabilitarEnAlmacen(int idAlmacen);
    }

    public interface IlogProveedor
    {
        List<entProveedor> ListarProveedor();
        Result<int> InsertarProveedor(entProveedor pr);
        Result<bool> EditarProveedor(entProveedor pr);
        Result<bool> DeshabilitarProveedor(int proveedorID);
    }

    public interface IlogMesero
    {
        List<entMesero> ListarMesero();
        Result<int> agregarMesero(entMesero m);
        Result<bool> modificarMesero(entMesero m);
        Result<bool> inhabilitarMesero(int meseroID);
    }

    public interface IlogTipoBebida
    {
        List<entTipoBebida> ListarTBebida();
        Result<int> InsertarTBebida(entTipoBebida tb);
        Result<bool> ModificarTBebida(entTipoBebida tb);
        Result<bool> InhabilitarTBebida(int idTipo);
    }

    public interface IlogTPlatillo
    {
        List<entTPlatillo> ListarTPlatillo();
        Result<int> agregarTPlatillo(entTPlatillo tp);
        Result<bool> modificarTPlatillo(entTPlatillo tp);
        Result<bool> inhabilitarTPlatillo(int idTipo);
    }
}
