namespace PoliMarket.Components.Bodega.Dto
{
    public class StockDto
    {
        public int Cantidad { get; set; }
        public string IdInventario { get; set; } = null!;
        public string IdProducto { get; set; } = null!;
    }
}
