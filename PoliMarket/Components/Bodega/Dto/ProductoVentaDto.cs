namespace PoliMarket.Components.Bodega.Dto
{
    public class ProductoVentaDto
    {
        public string IdProducto { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public double Precio { get; set; }
        public virtual List<StockDto> Stoks { get; set; } = [];
    }
}
