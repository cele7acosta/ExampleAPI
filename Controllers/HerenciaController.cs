using ExampleAPI.EjemploHerencia;
//using ExampleAPI.EjemploInterfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HerenciaController : ControllerBase
    {
        [HttpGet]
        public string GetAnimal()
        {
            //Animal animal = new Animal();
            //return animal.Color = "Blanco";
            Gato gato = new Gato();
            gato.Raza = "siames";
            gato.ColorOjos = "marrones";
            return gato.Caminar();
        }
      
    }
}
