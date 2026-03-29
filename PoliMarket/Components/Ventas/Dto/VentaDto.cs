using PoliMarket.Components.Ventas.Entities;

namespace PoliMarket.Components.Ventas.Dto
{
    public class VentaDto
    {
        public string IdVenta { get; set; } = null!;
        public string DocumentoCliente { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public virtual string IdVendedor { get; set; } = null!;
        public virtual List<DetalleVentaDto> DetallesVentas { get; set; } = [];
    }
}
