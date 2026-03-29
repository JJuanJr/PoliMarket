using PoliMarket.Components.Bodega.Dto;

namespace PoliMarket.Components.Bodega.Repositories.Interfaces
{
    public interface IInventarioRepository
    {
        List<ProductoVentaDto> ListarProductos();
        int ObtenerExistencias(string idProducto);
        int ActualizarStock(string idProducto, int cantidad);
    }
}
