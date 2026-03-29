using PoliMarket.Components.Bodega.Dto;
using PoliMarket.Components.Bodega.Repositories.Interfaces;

namespace PoliMarket.Components.Bodega
{
    public class BodegaFacade : IBodegaService
    {
        private readonly IInventarioRepository _inventarioRepository;

        public BodegaFacade(IInventarioRepository inventarioRepository)
        {
            _inventarioRepository = inventarioRepository;
        }

        public List<ProductoVentaDto> ListarProductosDisponibles()
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
