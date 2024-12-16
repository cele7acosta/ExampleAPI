using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExampleAPI.EjemploInterfaz;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploInterfazController : ControllerBase
    {
        [HttpGet("EjemploInterfaz")]
        public string EjemploInterfaz()
        {
            Gato gato = new Gato();
            return gato.Comer();
        }

        [HttpGet("EjemploInterfazImplementacion")]
        public string EjemploInterfazImplementacion()
        {
            IAnimal perro = new Perro();
            return perro.ObtenerDistanciaRecorrida(); //método común
        }
    }
}
