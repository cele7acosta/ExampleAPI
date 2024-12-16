using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExampleAPI.EjemploInterfaz;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploDosInterfazController : ControllerBase
    {
        [HttpGet("EjemploInterfazDos")]
        public string EjemploInterfazDos()
        {
            EjemploBase _base = new EjemploBase();
           // Gato gato = new Gato();
            Perro perro = new Perro();
            
            return _base.Caminar(perro);
        }


    }
}
