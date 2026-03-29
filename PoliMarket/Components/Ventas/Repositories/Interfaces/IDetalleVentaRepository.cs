namespace PoliMarket.Components.Ventas.Repositories.Interfaces
{
    public interface IDetalleVentaRepository
    {
        bool RegistrarDetalleVenta(string idVenta, string idProducto, int cantidad);

    }
}
