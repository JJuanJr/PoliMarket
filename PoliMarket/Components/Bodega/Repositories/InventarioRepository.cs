using Microsoft.EntityFrameworkCore;
using PoliMarket.Components.Bodega.Dto;
using PoliMarket.Components.Bodega.Mapper;
using PoliMarket.Components.Bodega.Repositories.Interfaces;
using PoliMarket.Context;

namespace PoliMarket.Components.Inventario.Repositories
{
    public class InventarioRepository : IInventarioRepository
    {
        private readonly AppDbContext _context;

        public InventarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<ProductoVentaDto> ListarProductos()
        {
            var productos = _context.Productos.Include(p => p.Stoks).Where(p => p.Stoks.Any(s => s.Cantidad > 0)).ToList();
            var productosDto = productos.Select(p => BodegaMapper.ToDto(p)).ToList();
            return productosDto;
        }

        public int ObtenerExistencias(string idProducto)
        {
            return _context.Stocks.Where(s => s.IdProducto == idProducto).Sum(s => s.Cantidad);
        }

        public int ActualizarStock(string idProducto, int cantidad)
        {
            var stocks = _context.Stocks.Where(s => s.IdProducto == idProducto).ToList();
            foreach (var stock in stocks)
            {
                stock.Cantidad += cantidad;
            }
            _context.SaveChanges();
            return ObtenerExistencias(idProducto);
        }
    }
}
