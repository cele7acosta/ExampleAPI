namespace ExampleAPI.EjemploInterfaz
{
    public class EjemploBase
    {
        public string Caminar(IAnimal animal)
        {
            return animal.Caminar();
        }
    }
}
