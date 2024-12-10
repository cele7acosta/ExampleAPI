namespace ExampleAPI.EjemploClaseAbstracta
{
    public class Perro: Animal
    {
        public Perro() { }

        public override string HacerSonido()
        {
            return "El perro ladró";
        }
    }
}
