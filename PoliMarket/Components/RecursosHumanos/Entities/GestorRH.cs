namespace PoliMarket.Components.RecursosHumanos.Entities
{
    public class GestorRH
    {
        public string GestorId { get; set; } = null!;
        public virtual List<Vendedor> VendedoresAutorizados { get; set; } = [];
    }
}
