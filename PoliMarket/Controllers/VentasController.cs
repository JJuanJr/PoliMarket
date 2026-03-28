using Microsoft.AspNetCore.Mvc;
using PoliMarket.Components.Bodega;
using PoliMarket.Components.Ventas;
using PoliMarket.Components.Ventas.Request;

namespace PoliMarket.Controllers
{
    [Route("api/ventas")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly BodegaFacade _bodegaFacade;
        private readonly VentasFacade _ventasFacade;

        public VentasController(BodegaFacade bodegaFacade, VentasFacade ventasFacade)
        {
            _bodegaFacade = bodegaFacade;
            _ventasFacade = ventasFacade;
        }

        [HttpGet("listar-productos-disponibles")]
        public IActionResult ListarProductosDisponibles()
        {
            return Ok(_bodegaFacade.ListarProductosDisponibles());
        }

        [HttpPost("crear-venta")]
        public IActionResult CrearVenta(CrearVentaRequest crearVenta)
        {
            bool resultado = _ventasFacade.CrearVenta(crearVenta);
            return resultado ? Ok("Venta creada exitosamente") : BadRequest("Error al crear la venta");
        }

        [HttpGet("listar-ventas")]
        public IActionResult ListarVentas()
        {
            return Ok(_ventasFacade.ListarVentas());
        }
    }
}
