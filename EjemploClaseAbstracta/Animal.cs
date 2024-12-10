namespace ExampleAPI.EjemploClaseAbstracta
{
    public abstract class Animal
    {
        //public string colorPelo { get; set; }

        public Animal() 
        {
        
        }

        public abstract string HacerSonido();

        public string ObtenerDistanciaRecorrida()
        {
            return "El animal recorrio 20km";
        }
    }
}
