using ExampleAPI.EjemploInterfaz;

namespace ExampleAPI.EjemploPatronFactory
{
    public static class AnimalFactory
    {
        public static IAnimal CrearAnimal(string tipo)
        {
            switch(tipo.ToLower())
            {
                case "perro":
                    return new Perro();

                case "gato":
                    return new Gato();

                default:
                    throw new ArgumentException("Tipo de animal no soportado");
            }
        }
    }
}
