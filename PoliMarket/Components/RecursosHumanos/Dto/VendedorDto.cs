namespace PoliMarket.Components.RecursosHumanos.Dto
{
    public class VendedorDto
    {
        public string IdVendedor { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public virtual string GestorId { get; set; } = null!;
    }
}
