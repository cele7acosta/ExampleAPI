namespace ExampleAPI.EjemploHerencia
{
    public class Gato : Animal
    {
        public string ColorOjos {  get; set; }
 
        public string Maulla()
        {
            return "El gato esta maullando";
        }

        public override string Caminar()
        {
            return "El gato esta caminando";
        }
        public override string Comer()
        {
            return "El gato esta comiendo";
        }
    }
}
