using PoliMarket.Components.Bodega.Entities;
using PoliMarket.Components.Inventario.Repositories;

namespace PoliMarket.Components.Bodega
{
    public class BodegaFacade
    {
        private readonly InventarioRepository _inventarioRepository;

        public BodegaFacade(InventarioRepository inventarioRepository)
        {
            _inventarioRepository = inventarioRepository;
        }

        public List<ProductoVenta> ListarProductosDisponibles()
        {
            return _inventarioRepository.ListarProductos();
        }

        public int ObtenerExistencias(string idProducto)
        {
            return _inventarioRepository.ObtenerExistencias(idProducto);
        }

        public int ActualizarStock(string idProducto, int cantidad)
        {
            return _inventarioRepository.ActualizarStock(idProducto, cantidad);
        }
    }
}
