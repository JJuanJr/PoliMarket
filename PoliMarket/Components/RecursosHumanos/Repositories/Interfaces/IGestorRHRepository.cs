using PoliMarket.Components.RecursosHumanos.Dto;

namespace PoliMarket.Components.RecursosHumanos.Repositories.Interfaces
{
    public interface IGestorRHRepository
    {
        VendedorDto? ConsultarVendedorAutorizado(string idVendedor);
    }
}
