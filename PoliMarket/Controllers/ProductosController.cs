using Microsoft.AspNetCore.Mvc;
using PoliMarket.Components.Bodega;

namespace PoliMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IBodegaService _bodegaService;

        public ProductosController(IBodegaService bodegaService)
        {
            _bodegaService = bodegaService;
        }

        [HttpGet("listar-productos-disponibles")]
        public IActionResult ListarProductosDisponibles()
        {
            return Ok(_bodegaService.ListarProductosDisponibles());
        }

    }
}
