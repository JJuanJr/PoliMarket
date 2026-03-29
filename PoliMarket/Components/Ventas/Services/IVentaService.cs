using PoliMarket.Components.Ventas.Dto;

namespace PoliMarket.Components.Ventas.Services
{
    public interface IVentaService
    {
        string RegistrarVenta(string idVendedor, string documentoCliente);
        bool RegistrarDetalleVenta(string idVenta, string idProducto, int cantidad, string nombreProducto);
        List<VentaDto> ListarVentas();
    }
}
