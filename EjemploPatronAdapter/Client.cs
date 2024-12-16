namespace ExampleAPI.EjemploPatronAdapter
{
    public class Client
    {
        public string GetCurrencyInPesos(IPesosTarget pesosTarget)
        {
            string pesos;
            pesos= pesosTarget.GetCurrencyInPesos().ToString();
            return "Conversion a pesos: "+ pesos;
        }
    }
}
