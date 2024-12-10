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
        [Route("api/EjemploInterfaz")]
        public string EjemploInterfaz()
        {
            Gato gato = new Gato();
            return gato.Comer();
        }

        [HttpGet]
        [Route("api/EjemploInterfazImplementacion")]

        public string EjemploInterfazImplementacion()
        {
            IAnimal perro = new Perro();
            return perro.ObtenerDistanciaRecorrida(); //método común
        }
    }
}
