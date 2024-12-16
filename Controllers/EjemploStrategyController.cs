using ExampleAPI.EjemploPatronState;
using ExampleAPI.EjemploPatronStrategy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploStrategyController : ControllerBase
    {
        [HttpGet("calcular")]
        public IActionResult CalcularEnvio([FromQuery] string tipo, [FromQuery] decimal peso)
        {
            GestorDeEnvios gestor = new GestorDeEnvios();

            // Seleccionar estrategia según el tipo de envío
            switch (tipo.ToLower())
            {
                case "estandar":
                    gestor.SetEstrategia(new EnvioEstandar());
                    break;
                case "expres":
                    gestor.SetEstrategia(new EnvioExpres());
                    break;
                case "internacional":
                    gestor.SetEstrategia(new EnvioInternacional());
                    break;
                default:
                    return BadRequest("Tipo de envío no soportado.");
            }

            // Calcular y devolver resultado
            var costo = gestor.CalcularCosto(peso);
            var tiempo = gestor.ObtenerTiempoEntrega();

            return Ok(new
            {
                Tipo = tipo,
                Peso = peso,
                Costo = costo,
                TiempoEntrega = tiempo
            });
        }
    }
}
