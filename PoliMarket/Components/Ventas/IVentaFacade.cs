using PoliMarket.Components.Ventas.Dto;
using PoliMarket.Components.Ventas.Request;

namespace PoliMarket.Components.Ventas
{
    public interface IVentaFacade
    {
        bool CrearVenta(CrearVentaRequest crearVenta);
        List<VentaDto> ListarVentas();
    }
}
