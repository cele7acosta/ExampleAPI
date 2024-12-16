using ExampleAPI.Model;
using ExampleAPI.Resource;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI.Controllers
{
    //Define esta clase como un controlador de API
    [ApiController]
    [Route("api/GetQuote")] //define la ruta base para acceder a los endpoints, en este caso "QuoteController"
    public class QuoteController : ControllerBase
    {
        //Endpoint GET para obtener la cotizacion del dolar blue
        [HttpGet(Name = "GetQuote")]

        public string GetQuote()
        {
            DolarAPI api = new DolarAPI(); //instancia de la clase DolarAPI

            return api.GetQuote().Result; //llama al metodo GetQuote() de DolarAPI y obtiene la cotizacion del dolar blue
        }

        //Endpoint POST para obtener la cotizacion de un tipo especifico de dolar
        [HttpPost(Name = "GetSpecificQuote")]
        public async Task<string> GetSpecificQuote([FromBody] Currency Currency) //con FromBody especifico que voy a recibir el parámetro desde el cuerpo del mensaje
        {
            //'FromBody' indica que el parametro 'currency' se recibe en el cuerpo de la solicitud en formato JSON
            DolarAPI api = new DolarAPI(); //instancia de la clase DolarAPI
            return await api.GetSpecificQuote(Currency); //llama al metodo GetSpecificQuote() y pasa 'currency'  para obtener la cotizacion del tipo especificado
        }
    }
}
