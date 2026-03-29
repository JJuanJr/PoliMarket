namespace PoliMarket.Components.Bodega.Dto
{
    public class InventarioDto
    {
        public string IdInventario { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public virtual List<StockDto> Productos { get; set; } = [];
    }
}
