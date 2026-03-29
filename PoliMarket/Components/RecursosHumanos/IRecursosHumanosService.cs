namespace PoliMarket.Components.RecursosHumanos
{
    public interface IRecursosHumanosService
    {
        bool EsVendedorAutorizado(string idVendedor);
        bool AgregarVendedor(string idVendedor, string nombreVendedor);
    }
}
