using PoliMarket.Components.RecursosHumanos.Entities;
using PoliMarket.Context;

namespace PoliMarket.Components.RecursosHumanos.Repositories
{
    public class VendedorRepository
    {
        private readonly AppDbContext _context;

        public VendedorRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool AgregarVendedor(string idVendedor, string nombreVendedor)
        {
            _context.Vendedores.Add(new Vendedor
            {
                GestorId = _context.GestorTH.First().GestorId,
                IdVendedor = idVendedor,
                Nombre = nombreVendedor
            });
            _context.SaveChanges();
            return true;
        }
    }
}
