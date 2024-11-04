namespace ExampleAPI.Model
{

    //definicion de la clase Currency, que actua como modelo para representar una moneda
    public class Currency
    {
        //propiedad "Code" de tipo string, que almacena el codigo de la moneda 
        //esta propiedad sera utilizada para especificar el tipo de dolar ("blue", "bolsa" o "cripto")
        // que se enviara en el cuerpo de una solicitud POST
        public string Code { get; set; }
    }
}
