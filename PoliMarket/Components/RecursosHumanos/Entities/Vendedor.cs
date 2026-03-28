namespace PoliMarket.Components.RecursosHumanos.Entities
{
    public class Vendedor
    {
        public string IdVendedor { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public virtual string GestorId { get; set; } = null!;
    }
}
