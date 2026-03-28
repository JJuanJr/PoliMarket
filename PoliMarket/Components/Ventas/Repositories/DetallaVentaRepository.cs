using PoliMarket.Components.Ventas.Entities;
using PoliMarket.Context;

namespace PoliMarket.Components.Ventas.Repositories
{
    public class DetallaVentaRepository
    {
        private readonly AppDbContext _context;

        public DetallaVentaRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool RegistrarDetalleVenta(string idVenta, string idProducto, int cantidad)
        {
            _context.DetallesVentas.Add(new DetalleVenta
            {
                IdVenta = idVenta,
                IdProducto = idProducto,
                Cantidad = cantidad
            });
            _context.SaveChanges();
            return true;
        }
    }
}
