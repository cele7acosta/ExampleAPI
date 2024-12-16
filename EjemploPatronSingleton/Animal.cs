namespace ExampleAPI.EjemploPatronSingleton
{
    public class Animal
    {
        private static Animal _instance = new Animal();
        private Animal()
        {
        }
        public static Animal GetInstance
        {
            get
            {
                return _instance;
            }
        }
        public string ObtenerDistanciaRecorrida()
        {
            return "El animal recorrio 20km (Desde el Patrón Singleton)";
        }
    }
}
