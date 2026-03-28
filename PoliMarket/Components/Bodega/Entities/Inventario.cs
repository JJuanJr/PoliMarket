namespace PoliMarket.Components.Bodega.Entities
{
    public class Inventario
    {
        public string IdInventario { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public virtual List<Stock> Productos { get; set; } = [];
    }
}
