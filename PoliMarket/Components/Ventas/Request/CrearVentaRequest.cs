namespace PoliMarket.Components.Ventas.Request
{
    public class CrearVentaRequest
    {
        public string IdVendedor { get; set; } = null!;
        public string DocumentoCliente { get; set; } = null!;
        public List<ProductoRequest> Productos { get; set; } = [];
    }

    public class ProductoRequest
    {
        public string IdProducto { get; set; } = null!;
        public int Cantidad { get; set; }
    }
}
