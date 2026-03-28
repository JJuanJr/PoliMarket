namespace PoliMarket.Components.Bodega.Entities
{
    public class Stock
    {
        public int Cantidad { get; set; }
        public string IdInventario { get; set; } = null!;
        public string IdProducto { get; set; } = null!;
    }
}
