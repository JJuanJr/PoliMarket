using Microsoft.EntityFrameworkCore;
using PoliMarket.Components.Bodega.Entities;
using PoliMarket.Components.Proveedores.Entities;
using PoliMarket.Components.RecursosHumanos.Entities;
using PoliMarket.Components.Ventas.Entities;

namespace PoliMarket.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<GestorRH> GestorTH { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<RegistroCompra> RegistrosCompras { get; set; }
        public DbSet<ProductoProveedor> ProductosProveedores { get; set; }
        public DbSet<DetalleVenta> DetallesVentas { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<ProductoVenta> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definir llaves primarias
            modelBuilder.Entity<GestorRH>().HasKey(g => g.GestorId);
            modelBuilder.Entity<Vendedor>().HasKey(v => v.IdVendedor);

            modelBuilder.Entity<Proveedor>().HasKey(p => p.IdProveedor);
            modelBuilder.Entity<RegistroCompra>().HasKey(r => r.IdCompra);
            modelBuilder.Entity<ProductoProveedor>().HasKey(r => r.IdProducto);

            modelBuilder.Entity<DetalleVenta>().HasKey(d => new { d.IdVenta, d.IdProducto });
            modelBuilder.Entity<Venta>().HasKey(v => v.IdVenta);

            modelBuilder.Entity<Inventario>().HasKey(i => i.IdInventario);
            modelBuilder.Entity<ProductoVenta>().HasKey(v => v.IdProducto);
            modelBuilder.Entity<Stock>().HasKey(s => new { s.IdInventario, s.IdProducto });


            // Definir relación explícitamente
            modelBuilder.Entity<Inventario>()
                .HasMany(i => i.Productos)
                .WithOne()
                .HasForeignKey(s => s.IdInventario);

            modelBuilder.Entity<ProductoVenta>()
                .HasMany(p => p.Stoks)
                .WithOne()
                .HasForeignKey(s => s.IdProducto);

            modelBuilder.Entity<Venta>()
                .HasMany(v => v.DetallesVentas)
                .WithOne()
                .HasForeignKey(d => d.IdVenta);
            
            modelBuilder.Entity<Proveedor>()
                .HasMany(p => p.Productos)
                .WithOne()
                .HasForeignKey(p => p.IdProveedor);

            modelBuilder.Entity<Proveedor>()
                .HasMany(p => p.RegistrosCompras)
                .WithOne()
                .HasForeignKey(r => r.IdProveedor);


            modelBuilder.Entity<GestorRH>()
                .HasMany(g => g.VendedoresAutorizados)
                .WithOne()
                .HasForeignKey(v => v.GestorId);
        }
    }
}
