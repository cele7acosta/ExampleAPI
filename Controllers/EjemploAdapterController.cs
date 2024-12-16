using ExampleAPI.EjemploPatronAdapter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploAdapterController : ControllerBase
    {
        [HttpGet]
        public string GetCurrencyInPesos([FromQuery] double dolars)
        {
            //crear instancia de la clase adaptada
            DolarAdaptee dolarAdaptee = new DolarAdaptee(dolars);

            //crear instancia del adaptador
            IPesosTarget adapter = new DolarToPesosAdapter(dolarAdaptee);

            //crear instancia del cliente y retornar la moneda en pesos
            Client client = new Client();

            return client.GetCurrencyInPesos(adapter);
            
        }
    }
}
