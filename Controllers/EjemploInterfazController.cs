//using ExampleAPI.EjemploHerencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExampleAPI.EjemploInterfaz;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploInterfazController : ControllerBase
    {
        [HttpGet]
        public string EjemploInterfaz()
        {
            Gato gato = new Gato();
            return gato.Comer();
        }
    }
}
