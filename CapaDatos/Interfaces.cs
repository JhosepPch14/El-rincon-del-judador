using System.Collections.Generic;
using CapaEntidad;

namespace CapaDatos
{
    public interface IdatCliente
    {
        List<entCliente> ListarCliente();
        int agregarCliente(entCliente Cli);
        bool modificarCliente(entCliente Cli);
        bool inhabilitarCliente(int clienteID);
    }

    public interface IdatBebida
    {
        List<entBebida> ListarBebida();
        int agregarBebida(entBebida b);
        bool modificarBebida(entBebida b);
        bool inhabilitarBebida(int bebidaID);
    }

    public interface IdatPlatillo
    {
        List<entPlatillo> ListarPlatillo();
        int InsertarPlatillo(entPlatillo pl);
        bool EditarPlatillo(entPlatillo pl);
        bool DeshabilitarPlatillo(int platilloID);
    }

    public interface IdatOrdenPedido
    {
        List<entOrdenPedido> ListarOrden();
        int agregarOrden(entOrdenPedido op);
        bool modificarOrden(entOrdenPedido op);
        bool inhabilitarOrden(int pedidoID);
        bool actualizarTotal(int pedidoID, decimal total);
    }

    public interface IdatDetallePedido
    {
        List<entDetallePedido> ListarDetalles(int pedidoID);
        bool registrarDetalle(List<entDetallePedido> ldp, int pedidoID);
    }

    public interface IdatComprobantePago
    {
        List<entComprobantePago> ListarComprobantes();
        int registrarComprobante(entComprobantePago cop);
        bool deshabilitarComprobante(int comprobanteID);
    }

    public interface IdatCompraReq
    {
        List<entCompraReq> ListarCompraReq();
        int registrarCompraReq(entCompraReq cr);
        bool anularCompraReq(int idCompra);
    }

    public interface IdatInsumos
    {
        List<entInsumos> ListarInsumos();
        int InsertarInsumo(entInsumos ins);
        bool ModificarInsumo(entInsumos ins);
        bool InhabilitarInsumo(int insumoID);
    }

    public interface IdatReqInsumos
    {
        List<entReqInsumos> ListarReq();
        int registrarReq(entReqInsumos req);
        bool anularReq(int reqID);
    }

    public interface IdatDetalleReq
    {
        List<entDetalleReq> ListarDetalles(int requerimientoID);
        bool registrarDetalleReq(List<entDetalleReq> ldr, int requerimientoID);
    }

    public interface IdatEnAlmacen
    {
        List<entEnAlmacen> ListarEnAlmacen();
        int agregarEnAlmacen(entEnAlmacen ea);
        bool modificarEnAlmacen(entEnAlmacen ea);
        bool inhabilitarEnAlmacen(int idAlmacen);
    }

    public interface IdatProveedor
    {
        List<entProveedor> ListarProveedor();
        int InsertarProveedor(entProveedor pr);
        bool EditarProveedor(entProveedor pr);
        bool DeshabilitarProveedor(int proveedorID);
    }

    public interface IdatMesero
    {
        List<entMesero> ListarMesero();
        int agregarMesero(entMesero m);
        bool modificarMesero(entMesero m);
        bool inhabilitarMesero(int meseroID);
    }

    public interface IdatTipoBebida
    {
        List<entTipoBebida> ListarTBebida();
        int InsertarTBebida(entTipoBebida tb);
        bool ModificarTBebida(entTipoBebida tb);
        bool InhabilitarTBebida(int idTipo);
    }

    public interface IdatTPlatillo
    {
        List<entTPlatillo> ListarTPlatillo();
        int agregarTPlatillo(entTPlatillo tp);
        bool modificarTPlatillo(entTPlatillo tp);
        bool inhabilitarTPlatillo(int idTipo);
    }
}
