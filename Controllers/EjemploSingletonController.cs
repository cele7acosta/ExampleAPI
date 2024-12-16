using ExampleAPI.EjemploPatronSingleton;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploSingletonController : ControllerBase
    {
        [HttpGet]
        public string EjemploSingleton()
        {
            Animal animal = Animal.GetInstance;
            return animal.ObtenerDistanciaRecorrida();
        }
    }
}
