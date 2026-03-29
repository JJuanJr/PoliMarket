using PoliMarket.Components.Bodega;
using PoliMarket.Components.Ventas.Dto;
using PoliMarket.Components.Ventas.Request;
using PoliMarket.Components.Ventas.Services;

namespace PoliMarket.Components.Ventas
{
    public class VentaFacade : IVentaFacade
    {
        private readonly IVentaService _ventaService;
        private readonly IBodegaService _bodegaService;

        public VentaFacade(IVentaService ventaService, IBodegaService bodegaService)
        {
            _ventaService = ventaService;
            _bodegaService = bodegaService;
        }

        public bool CrearVenta(CrearVentaRequest crearVenta)
        {
            foreach (var producto in crearVenta.Productos)
            {
                var cantidad = _bodegaService.ObtenerExistencias(producto.IdProducto);
                if (cantidad < producto.Cantidad)
                {
                    return false;
                }
            }

            foreach (var producto in crearVenta.Productos)
            {
                _bodegaService.ActualizarStock(producto.IdProducto, -producto.Cantidad);
            }

            var idVenta = _ventaService.RegistrarVenta(crearVenta.IdVendedor, crearVenta.DocumentoCliente);

            foreach (var producto in crearVenta.Productos)
            {
                _ventaService.RegistrarDetalleVenta(idVenta, producto.IdProducto, producto.Cantidad, producto.NombreProducto);
            }

            return true;
        }

        public List<VentaDto> ListarVentas()
        {
            return _ventaService.ListarVentas();
        }
    }
}
