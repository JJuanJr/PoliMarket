using Microsoft.EntityFrameworkCore;
using PoliMarket.Components.Proveedores.Entities;
using PoliMarket.Context;

namespace PoliMarket.Components.Proveedores.Repositories
{
    public class ProveedorRepository
    {
        private readonly AppDbContext _context;

        public ProveedorRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<ProductoProveedor> ListarProductos(string idProveedor)
        {
            return _context.Proveedores.Include(p => p.Productos)
                .First(p => p.IdProveedor == idProveedor)
                .Productos.ToList();
        }
    }
}
