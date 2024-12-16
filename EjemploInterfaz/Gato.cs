namespace ExampleAPI.EjemploInterfaz
{
    public class Gato : IAnimal
    {
        public string Caminar()
        {
            return "El gato esta caminando (desde la interfaz)";
        }
        public string Comer()
        {
            return "El gato esta comiendo (desde la interfaz)";
        }

    }
}
