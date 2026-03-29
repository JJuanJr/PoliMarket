namespace PoliMarket.Components.Proveedores.Dto
{
    public class ProductoProveedorDto
    {
        public string IdProducto { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public double Precio { get; set; }
        public virtual string IdProveedor { get; set; } = null!;
    }
}
