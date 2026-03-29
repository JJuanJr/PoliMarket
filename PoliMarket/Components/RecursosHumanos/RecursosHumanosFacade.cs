using PoliMarket.Components.RecursosHumanos.Repositories.Interfaces;

namespace PoliMarket.Components.RecursosHumanos
{
    public class RecursosHumanosFacade : IRecursosHumanosService
    {
        private readonly IGestorRHRepository _gestorRHRepository;
        private readonly IVendedorRepository _vendedorRepository;

        public RecursosHumanosFacade(IGestorRHRepository gestorRHRepository, IVendedorRepository vendedorRepository)
        {
            _gestorRHRepository = gestorRHRepository;
            _vendedorRepository = vendedorRepository;
        }

        public bool EsVendedorAutorizado(string idVendedor)
        {
            return _gestorRHRepository.ConsultarVendedorAutorizado(idVendedor) is not null;
        }

        public bool AgregarVendedor(string idVendedor, string nombreVendedor)
        {
            return _vendedorRepository.AgregarVendedor(idVendedor, nombreVendedor);
        }
    }
}
