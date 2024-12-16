using ExampleAPI.EjemploClaseAbstracta;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploClaseAbstractaController : ControllerBase
    {
        [HttpGet]
        public string EjemploClaseAbstracta()
        {
            Perro perro= new Perro();
            return perro.ObtenerDistanciaRecorrida();
        }
    }
}
