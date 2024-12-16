namespace ExampleAPI.EjemploPatronAdapter
{
    // Clase adaptada (Dolar)
    public class DolarAdaptee
    {
        private readonly double _cantidadInDolars;

        public DolarAdaptee(double cantidadInDolars)
        {
            _cantidadInDolars = cantidadInDolars;
        }

        public double GetCurrencyInDolar()
        {
            return _cantidadInDolars;
        }
    }
}
