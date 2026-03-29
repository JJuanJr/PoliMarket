using PoliMarket.Components.Proveedores.Dto;
using PoliMarket.Components.Proveedores.Repositories.Interfaces;

namespace PoliMarket.Components.Proveedores
{
    public class ProveedoresService : IProveedorService
    {
        private readonly IProveedorRepository _proveedorRepository;

        public ProveedoresService(IProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
        }

        public List<ProductoProveedorDto> ObtenerProductosDeProveedor(string idProveedor)
        {
            return _proveedorRepository.ListarProductos(idProveedor);
        }
    }
}
