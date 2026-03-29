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
        private readonly IVentasService _ventasFacade;
        

        public VentasController(IVentasService ventasFacade)
        {
            _ventasFacade = ventasFacade;
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
