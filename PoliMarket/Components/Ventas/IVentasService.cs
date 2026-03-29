using PoliMarket.Components.Ventas.Dto;
using PoliMarket.Components.Ventas.Request;

namespace PoliMarket.Components.Ventas
{
    public interface IVentasService
    {
        bool CrearVenta(CrearVentaRequest crearVenta);
        List<VentaDto> ListarVentas();
    }
}
