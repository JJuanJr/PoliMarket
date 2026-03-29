namespace PoliMarket.Components.Ventas.Dto
{
    public class DetalleVentaDto
    {
        public string IdVenta { get; set; } = null!;
        public int Cantidad { get; set; }
        public virtual string IdProducto { get; set; } = null!;
        public virtual string NombreProducto { get; set; } = null!;
    }
}
