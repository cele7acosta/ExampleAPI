namespace ExampleAPI.EjemploInterfaz
{
    public interface IAnimal
    {
        public string Caminar();
        public string Comer();

        public string ObtenerDistanciaRecorrida()
        {
            return "El animal recorrió 20km";
        }
    }
}
