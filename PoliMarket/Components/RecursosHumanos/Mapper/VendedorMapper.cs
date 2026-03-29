using PoliMarket.Components.RecursosHumanos.Dto;
using PoliMarket.Components.RecursosHumanos.Entities;

namespace PoliMarket.Components.RecursosHumanos.Mapper
{
    public static class VendedorMapper
    {
        public static VendedorDto ToDto(Vendedor vendedor)
        {
            return new VendedorDto
            {
                IdVendedor = vendedor.IdVendedor,
                Nombre = vendedor.Nombre,
                GestorId = vendedor.GestorId
            };
        }
    }
}
