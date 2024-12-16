using ExampleAPI.EjemploPatronState;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploStateController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTaskStateFlow()
        {
            //crear una nueva tarea
            Tarea tarea = new Tarea();

            //lista para almacenar los estados
            List<string> estados = new List<string>();

            //muestra el estado inicial
            estados.Add($"Estado inicial: {tarea.MostrarEstado()}");

            //cambia al siguiente estado y guarda el nuevo estado
            estados.Add($"{tarea.Cambiar()}");
            estados.Add($"Nuevo estado: {tarea.MostrarEstado()}");

            estados.Add($"{tarea.Cambiar()}");
            estados.Add($"Nuevo estado: {tarea.MostrarEstado()}");

            estados.Add($"{tarea.Cambiar()}");
            estados.Add($"Nuevo estado: {tarea.MostrarEstado()}");

            //Devuelve los estados como una respuesta JSON

            return Ok(estados);
        }
    }
}
