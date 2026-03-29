using PoliMarket.Components.Ventas.Dto;
using PoliMarket.Components.Ventas.Repositories.Interfaces;

namespace PoliMarket.Components.Ventas.Services
{
    public class VentaService : IVentaService
    {
        private readonly IVentaRepository _ventaRepository;
        private readonly IDetalleVentaRepository _detallaVentaRepository;

        public VentaService(IVentaRepository ventaRepository, IDetalleVentaRepository detalleVentaRepository)
        {
            _ventaRepository = ventaRepository;
            _detallaVentaRepository = detalleVentaRepository;
        }

        public List<VentaDto> ListarVentas()
        {
            return _ventaRepository.ListarVentas();
        }

        public bool RegistrarDetalleVenta(string idVenta, string idProducto, int cantidad, string nombreProducto)
        {
            return _detallaVentaRepository.RegistrarDetalleVenta(idVenta, idProducto, cantidad, nombreProducto);
        }

        public string RegistrarVenta(string idVendedor, string documentoCliente)
        {
            return _ventaRepository.RegistrarVenta(idVendedor, documentoCliente);
        }
    }
}
