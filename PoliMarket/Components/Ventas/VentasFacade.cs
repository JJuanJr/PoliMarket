using PoliMarket.Components.Bodega;
using PoliMarket.Components.Ventas.Dto;
using PoliMarket.Components.Ventas.Repositories.Interfaces;
using PoliMarket.Components.Ventas.Request;

namespace PoliMarket.Components.Ventas
{
    public class VentasFacade : IVentasService
    {
        private readonly IVentaRepository _ventaRepository;
        private readonly IDetalleVentaRepository _detallaVentaRepository;
        private readonly IBodegaService _bodegaService;

        public VentasFacade(IVentaRepository ventaRepository, IDetalleVentaRepository detallaVentaRepository, IBodegaService bodegaService)
        {
            _ventaRepository = ventaRepository;
            _detallaVentaRepository = detallaVentaRepository;
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

            var idVenta = _ventaRepository.RegistrarVenta(crearVenta.IdVendedor, crearVenta.DocumentoCliente);

            foreach (var producto in crearVenta.Productos)
            {
                _detallaVentaRepository.RegistrarDetalleVenta(idVenta, producto.IdProducto, producto.Cantidad);
            }

            return true;
        }

        public List<VentaDto> ListarVentas()
        {
            return _ventaRepository.ListarVentas();
        }
    }
}
