using Microsoft.EntityFrameworkCore;
using PoliMarket.Components.Bodega;
using PoliMarket.Components.Bodega.Entities;
using PoliMarket.Components.Inventario.Repositories;
using PoliMarket.Components.Proveedores;
using PoliMarket.Components.Proveedores.Repositories;
using PoliMarket.Components.RecursosHumanos;
using PoliMarket.Components.RecursosHumanos.Entities;
using PoliMarket.Components.RecursosHumanos.Repositories;
using PoliMarket.Components.Ventas;
using PoliMarket.Components.Ventas.Repositories;
using PoliMarket.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("DbPoliMarket"));

builder.Services.AddScoped<GestorRHRepository>();
builder.Services.AddScoped<VendedorRepository>();
builder.Services.AddScoped<RecursosHumanosFacade>();

builder.Services.AddScoped<BodegaFacade>();
builder.Services.AddScoped<InventarioRepository>();

builder.Services.AddScoped<ProveedorRepository>();
builder.Services.AddScoped<ProveedoresFacade>();

builder.Services.AddScoped<VentasFacade>();
builder.Services.AddScoped<VentaRepository>();
builder.Services.AddScoped<DetallaVentaRepository>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    db.GestorTH.Add(new GestorRH { GestorId = "Gestor RH" });

    db.Vendedores.Add(new Vendedor { IdVendedor = "V1", Nombre = "Pepito Perez", GestorId = "Gestor RH" });

    db.Productos.Add(new ProductoVenta { IdProducto = "P1", Nombre = "Llavero casa", Precio = 11_000 });
    db.Productos.Add(new ProductoVenta { IdProducto = "P2", Nombre = "Sombrilla", Precio = 80_000 });
    db.Productos.Add(new ProductoVenta { IdProducto = "P3", Nombre = "Cobija tipo cojín", Precio = 50_000 });
    db.Productos.Add(new ProductoVenta { IdProducto = "P4", Nombre = "Alcancía", Precio = 15_000 });

    db.Inventarios.Add(new Inventario { IdInventario = "I1", Nombre = "Inventario Principal" });

    db.Stocks.Add(new Stock { IdInventario = "I1", IdProducto = "P1", Cantidad = 1000 });
    db.Stocks.Add(new Stock { IdInventario = "I1", IdProducto = "P2", Cantidad = 200 });
    db.Stocks.Add(new Stock { IdInventario = "I1", IdProducto = "P3", Cantidad = 500 });
    db.Stocks.Add(new Stock { IdInventario = "I1", IdProducto = "P4", Cantidad = 15 });

    db.SaveChanges();
}


// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
