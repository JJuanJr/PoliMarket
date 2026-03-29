using PoliMarket.Components.Proveedores.Dto;
using PoliMarket.Components.Proveedores.Entities;

namespace PoliMarket.Components.Proveedores.Mapper
{
    public static class ProveedorMapper
    {
        public static ProductoProveedorDto ToDto(ProductoProveedor productoProveedor)
        {
            return new ProductoProveedorDto
            {
                IdProducto = productoProveedor.IdProducto,
                Nombre = productoProveedor.Nombre,
                Precio = productoProveedor.Precio,
                IdProveedor = productoProveedor.IdProveedor
            };
        }
    }
}
