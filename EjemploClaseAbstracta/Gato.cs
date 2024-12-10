namespace ExampleAPI.EjemploClaseAbstracta
{
    public class Gato: Animal
    {
        public Gato() { }

        public override string HacerSonido()
        {
            return "El gato maulló";
        }
    }
}
