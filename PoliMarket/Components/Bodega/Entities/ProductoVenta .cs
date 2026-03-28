namespace PoliMarket.Components.Bodega.Entities
{
    public class ProductoVenta
    {
        public string IdProducto { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public double Precio { get; set; }
        public virtual List<Stock> Stoks { get; set; } = [];
    }
}
