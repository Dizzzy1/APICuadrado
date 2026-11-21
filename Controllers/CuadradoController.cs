using Microsoft.AspNetCore.Mvc;

namespace APICuadradoo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CuadradoController : ControllerBase
    {
        [HttpGet("{numero}")]
        public IActionResult CalcularCuadrado(double numero)
        {
            double resultado = numero * numero;

            return Ok(new
            {
                numero = numero,
                cuadrado = resultado
            });
        }
    }
}
