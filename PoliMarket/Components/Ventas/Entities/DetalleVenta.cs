namespace PoliMarket.Components.Ventas.Entities
{
    public class DetalleVenta
    {
        public string IdVenta { get; set; } = null!;
        public int Cantidad { get; set; }
        public virtual string IdProducto { get; set; } = null!;
    }
}
