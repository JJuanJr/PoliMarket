using PoliMarket.Components.Bodega.Dto;

namespace PoliMarket.Components.Bodega
{
    public interface IBodegaService 
    {
        List<ProductoVentaDto> ListarProductosDisponibles();
        int ObtenerExistencias(string idProducto);
        int ActualizarStock(string idProducto, int cantidad);
    }
}
