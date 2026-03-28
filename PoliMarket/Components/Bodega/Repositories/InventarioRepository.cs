using Microsoft.EntityFrameworkCore;
using PoliMarket.Components.Bodega.Entities;
using PoliMarket.Context;

namespace PoliMarket.Components.Inventario.Repositories
{
    public class InventarioRepository
    {
        private readonly AppDbContext _context;

        public InventarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<ProductoVenta> ListarProductos()
        {
            return _context.Productos.Include(p => p.Stoks).Where(p => p.Stoks.Any(s => s.Cantidad > 0)).ToList();
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
