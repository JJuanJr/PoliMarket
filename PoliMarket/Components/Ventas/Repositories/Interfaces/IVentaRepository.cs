using PoliMarket.Components.Ventas.Dto;

namespace PoliMarket.Components.Ventas.Repositories.Interfaces
{
    public interface IVentaRepository
    {
        string RegistrarVenta(string idVendedor, string documentoCliente);
        List<VentaDto> ListarVentas();
    }
}
