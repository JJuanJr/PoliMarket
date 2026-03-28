using Microsoft.EntityFrameworkCore;
using PoliMarket.Components.RecursosHumanos.Entities;
using PoliMarket.Context;

namespace PoliMarket.Components.RecursosHumanos.Repositories
{
    public class GestorRHRepository
    {
        private readonly AppDbContext _context;

        public GestorRHRepository(AppDbContext context)
        {
            _context = context;
        }

        public Vendedor? ConsultarVendedorAutorizado(string idVendedor)
        {
            return _context.GestorTH.Include(g => g.VendedoresAutorizados)
                .First()?.VendedoresAutorizados.FirstOrDefault(v => v.IdVendedor == idVendedor);
        }
    }
}
