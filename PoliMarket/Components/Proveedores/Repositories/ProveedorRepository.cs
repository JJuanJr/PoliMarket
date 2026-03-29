using Microsoft.EntityFrameworkCore;
using PoliMarket.Components.Proveedores.Dto;
using PoliMarket.Components.Proveedores.Mapper;
using PoliMarket.Components.Proveedores.Repositories.Interfaces;
using PoliMarket.Context;

namespace PoliMarket.Components.Proveedores.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly AppDbContext _context;

        public ProveedorRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<ProductoProveedorDto> ListarProductos(string idProveedor)
        {
            var productosProveedor = _context.Proveedores.Include(p => p.Productos)
                .First(p => p.IdProveedor == idProveedor)
                .Productos.ToList();

            return productosProveedor.Select(ProveedorMapper.ToDto).ToList();
        }
    }
}
