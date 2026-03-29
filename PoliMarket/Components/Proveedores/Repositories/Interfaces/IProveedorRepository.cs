using PoliMarket.Components.Proveedores.Dto;

namespace PoliMarket.Components.Proveedores.Repositories.Interfaces
{
    public interface IProveedorRepository
    {
        List<ProductoProveedorDto> ListarProductos(string idProveedor);
    }
}
