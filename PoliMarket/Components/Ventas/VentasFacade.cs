using PoliMarket.Components.Bodega;
using PoliMarket.Components.Ventas.Entities;
using PoliMarket.Components.Ventas.Repositories;
using PoliMarket.Components.Ventas.Request;

namespace PoliMarket.Components.Ventas
{
    public class VentasFacade
    {
        private readonly VentaRepository _ventaRepository;
        private readonly DetallaVentaRepository _detallaVentaRepository;
        private readonly BodegaFacade _bodegaFacade;

        public VentasFacade(VentaRepository ventaRepository, DetallaVentaRepository detallaVentaRepository, BodegaFacade bodegaFacade)
        {
            _ventaRepository = ventaRepository;
            _detallaVentaRepository = detallaVentaRepository;
            _bodegaFacade = bodegaFacade;
        }

        public bool CrearVenta(CrearVentaRequest crearVenta)
        {
            foreach (var producto in crearVenta.Productos)
            {
                var cantidad = _bodegaFacade.ObtenerExistencias(producto.IdProducto);
                if (cantidad < producto.Cantidad)
                {
                    return false;
                }
            }

            foreach (var producto in crearVenta.Productos)
            {
                _bodegaFacade.ActualizarStock(producto.IdProducto, -producto.Cantidad);
            }

            var idVenta = _ventaRepository.RegistrarVenta(crearVenta.IdVendedor, crearVenta.DocumentoCliente);

            foreach (var producto in crearVenta.Productos)
            {
                _detallaVentaRepository.RegistrarDetalleVenta(idVenta, producto.IdProducto, producto.Cantidad, producto.NombreProducto);
            }

            return true;
        }

        public List<Venta> ListarVentas()
        {
            return _ventaRepository.ListarVentas();
        }
    }
}
