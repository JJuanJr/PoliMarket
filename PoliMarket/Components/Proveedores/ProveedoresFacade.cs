using PoliMarket.Components.Proveedores.Entities;
using PoliMarket.Components.Proveedores.Repositories;

namespace PoliMarket.Components.Proveedores
{
    public class ProveedoresFacade
    {
        private readonly ProveedorRepository _proveedorRepository;

        public ProveedoresFacade(ProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
        }

        public List<ProductoProveedor> ObtenerProductosDeProveedor(string idProveedor)
        {
            return _proveedorRepository.ListarProductos(idProveedor);
        }
    }
}
