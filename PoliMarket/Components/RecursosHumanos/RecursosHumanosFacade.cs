using PoliMarket.Components.RecursosHumanos.Repositories;

namespace PoliMarket.Components.RecursosHumanos
{
    public class RecursosHumanosFacade
    {
        private readonly GestorRHRepository _gestorRHRepository;
        private readonly VendedorRepository _vendedorRepository;

        public RecursosHumanosFacade(GestorRHRepository gestorRHRepository, VendedorRepository vendedorRepository)
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
