using ExampleAPI.EjemploInterfaz;
using ExampleAPI.EjemploPatronFactory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploFactoryController : ControllerBase
    {
        [HttpGet]
        public string EjemploFactory()
        {
            IAnimal animal = AnimalFactory.CrearAnimal("gato");
            //return animal.ObtenerDistanciaRecorrida();
            return animal.Caminar();
        }
    }
}
