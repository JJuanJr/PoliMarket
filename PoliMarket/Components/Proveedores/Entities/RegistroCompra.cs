namespace PoliMarket.Components.Proveedores.Entities
{
    public class RegistroCompra
    {  
        public string IdCompra { get; set; } = null!;
        public int CantidadComprada { get; set; }
        public virtual string IdProveedor { get; set; } = null!;
        public virtual string IdInventario { get; set; } = null!;
    }
}
