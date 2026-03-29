using PoliMarket.Components.Ventas.Dto;
using PoliMarket.Components.Ventas.Entities;

namespace PoliMarket.Components.Ventas.Mapper
{
    public static class VentaMapper
    {
        public static VentaDto ToDto(Venta venta)
        {
            return new VentaDto
            {
                IdVenta = venta.IdVenta,
                Fecha = venta.Fecha,
                DocumentoCliente = venta.DocumentoCliente,
                IdVendedor = venta.IdVendedor,
                DetallesVentas = venta.DetallesVentas.Select(d => new DetalleVentaDto
                {
                    IdProducto = d.IdProducto,
                    Cantidad = d.Cantidad,
                    IdVenta = d.IdVenta
                }).ToList()
            };
        }
    }
}
