using PoliMarket.Components.Proveedores.Dto;
using PoliMarket.Components.Proveedores.Entities;

namespace PoliMarket.Components.Proveedores
{
    public interface IProveedorService
    {
        List<ProductoProveedorDto> ObtenerProductosDeProveedor(string idProveedor);
    }
}
