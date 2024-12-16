namespace ExampleAPI.EjemploPatronAdapter
{
    //Adaptador
    public class DolarToPesosAdapter : IPesosTarget
    {
        private readonly DolarAdaptee _dolarAdaptee;

        private const double DolarToPesosConversionFactor = 1054;

        public DolarToPesosAdapter(DolarAdaptee dolarAdaptee)
        {
            _dolarAdaptee = dolarAdaptee;
        }

        public double GetCurrencyInPesos()
        {
            //convertir dolar a pesos
            double currencyInDolars = _dolarAdaptee.GetCurrencyInDolar();
            return currencyInDolars * DolarToPesosConversionFactor;
        }
    }
}
