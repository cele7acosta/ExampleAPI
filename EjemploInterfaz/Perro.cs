namespace ExampleAPI.EjemploInterfaz
{
    public class Perro : IAnimal
    {
        public string Caminar()
        {
            return "El perro esta caminando (desde la interfaz)";
        }
        public string Comer()
        {
            return "El perro esta comiendo (desde la interfaz)";
        }
    }
}
