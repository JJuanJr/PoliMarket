using PoliMarket.Components.Bodega.Dto;
using PoliMarket.Components.Bodega.Entities;

namespace PoliMarket.Components.Bodega.Mapper
{
    public static class BodegaMapper
    {
        public static ProductoVentaDto ToDto(ProductoVenta producto)
        {
            return new ProductoVentaDto
            {
                IdProducto = producto.IdProducto,
                Nombre = producto.Nombre,
                Precio = producto.Precio,
                Stoks = producto.Stoks.Select(s => new StockDto
                {
                    IdInventario = s.IdInventario,
                    IdProducto = s.IdProducto,
                    Cantidad = s.Cantidad
                }).ToList()
            };
        }
    }
}
