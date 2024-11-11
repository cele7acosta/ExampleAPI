namespace ExampleAPI.EjemploHerencia
{
    public class Animal
    {
        public string Raza { get; set; }
        public string Color { get; set; }

        public Animal(string raza) 
        { 
            
            this.Raza = raza;
        }

        public Animal() { }

        public Animal(string raza, string color)
        {
            this.Raza = raza;
            this.Color = color;
        }

        public virtual string Caminar() {
            return "El animal esta caminando";
        }

        public virtual string Comer()
        {
            return "El animal esta comiendo";
        }
        public string devolverRaza()
        {
            return this.Raza;
        }

    }
}
