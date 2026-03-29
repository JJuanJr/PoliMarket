using Microsoft.EntityFrameworkCore;
using PoliMarket.Components.Ventas.Dto;
using PoliMarket.Components.Ventas.Entities;
using PoliMarket.Components.Ventas.Mapper;
using PoliMarket.Components.Ventas.Repositories.Interfaces;
using PoliMarket.Context;

namespace PoliMarket.Components.Ventas.Repositories
{
    public class VentaRepository : IVentaRepository
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

        public List<VentaDto> ListarVentas()
        {
            var ventas = _context.Ventas.Include(d => d.DetallesVentas).ToList();
            
            var result = ventas.Select(VentaMapper.ToDto).ToList();

            return result;
        }
    }
}
