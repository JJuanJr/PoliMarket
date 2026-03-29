using Microsoft.AspNetCore.Mvc;
using PoliMarket.Components.RecursosHumanos;

namespace PoliMarket.Controllers
{
    [Route("api/recursos-humanos")]
    [ApiController]
    public class RecursosHumanosController : ControllerBase
    {
        private readonly IRecursosHumanosService _rhService;

        public RecursosHumanosController(IRecursosHumanosService rhFacade)
        {
            _rhService = rhFacade;
        }

        [HttpGet("validar-vendedor/{idVendedor}")]
        public ActionResult<bool> ValidarVendedor(string idVendedor)
        {
            bool esAutorizado = _rhService.EsVendedorAutorizado(idVendedor);
            return esAutorizado ? Ok(true) : NotFound(false);
        }

        [HttpPost("agregar-vendedor")]
        public IActionResult AgregarVendedor(string idVendedor, string nombreVendedor)
        {
            bool respuesta = _rhService.AgregarVendedor(idVendedor, nombreVendedor);
            return respuesta ? Ok(true) : BadRequest(false);
        }
    }
}
