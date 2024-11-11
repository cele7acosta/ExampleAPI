namespace ExampleAPI.EjemploHerencia
{
    public class Perro : Animal
    {

        public string Ladra()
        {
            return "El perro esta ladrando";
        }

        public override string Caminar()
        {
            return "El perro esta caminando";
        }
        public override string Comer()
        {
            return "El perro esta comiendo";
        }
    }
}
