using Microsoft.EntityFrameworkCore;
using PoliMarket.Components.RecursosHumanos.Dto;
using PoliMarket.Components.RecursosHumanos.Mapper;
using PoliMarket.Components.RecursosHumanos.Repositories.Interfaces;
using PoliMarket.Context;

namespace PoliMarket.Components.RecursosHumanos.Repositories
{
    public class GestorRHRepository : IGestorRHRepository
    {
        private readonly AppDbContext _context;

        public GestorRHRepository(AppDbContext context)
        {
            _context = context;
        }

        public VendedorDto? ConsultarVendedorAutorizado(string idVendedor)
        {
            var vendedor = _context.GestorTH.Include(g => g.VendedoresAutorizados)
                .First()?.VendedoresAutorizados.FirstOrDefault(v => v.IdVendedor == idVendedor);

            return vendedor != null ? VendedorMapper.ToDto(vendedor) : null;
        }
    }
}
