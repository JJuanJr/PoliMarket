using Microsoft.AspNetCore.Mvc;
using PoliMarket.Components.Ventas;
using PoliMarket.Components.Ventas.Request;

namespace PoliMarket.Controllers
{
    [Route("api/ventas")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly IVentaFacade _ventaFacade;


        public VentasController(IVentaFacade ventasFacade)
        {
            _ventaFacade = ventasFacade;
        }


        [HttpPost("crear-venta")]
        public IActionResult CrearVenta(CrearVentaRequest crearVenta)
        {
            bool resultado = _ventaFacade.CrearVenta(crearVenta);
            return resultado ? Ok("Venta creada exitosamente") : BadRequest("Error al crear la venta");
        }

        [HttpGet("listar-ventas")]
        public IActionResult ListarVentas()
        {
            return Ok(_ventaFacade.ListarVentas());
        }
    }
}
