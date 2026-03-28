using Microsoft.EntityFrameworkCore;
using PoliMarket.Components.Ventas.Entities;
using PoliMarket.Context;

namespace PoliMarket.Components.Ventas.Repositories
{
    public class VentaRepository
    {
        private readonly AppDbContext _context;

        public VentaRepository(AppDbContext context)
        {
            _context = context;
        }

        public string RegistrarVenta(string idVendedor, string documentoCliente)
        {
            string idVenta = Guid.NewGuid().ToString();
            _context.Ventas.Add(new Venta
            {
                IdVenta = idVenta,
                IdVendedor = idVendedor,
                DocumentoCliente = documentoCliente,
                Fecha = DateTime.Now,
            });
            _context.SaveChanges();
            return idVenta;
        }

        public List<Venta> ListarVentas()
        {
            return _context.Ventas.Include(d => d.DetallesVentas).ToList();
        }
    }
}
