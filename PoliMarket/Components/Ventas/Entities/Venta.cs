namespace PoliMarket.Components.Ventas.Entities
{
    public class Venta
    {
        public string IdVenta { get; set; } = null!;
        public string DocumentoCliente { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public virtual string IdVendedor { get; set; } = null!;
        public virtual List<DetalleVenta> DetallesVentas { get; set; } = [];
    }
}
