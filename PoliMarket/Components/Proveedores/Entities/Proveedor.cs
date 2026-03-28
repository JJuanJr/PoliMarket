using PoliMarket.Components.Bodega.Entities;

namespace PoliMarket.Components.Proveedores.Entities
{
    public class Proveedor
    {
        public string IdProveedor { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string Nit { get; set; } = null!;
        public virtual List<ProductoProveedor> Productos { get; set; } = [];
        public virtual List<RegistroCompra> RegistrosCompras { get; set; } = [];
    }
}
