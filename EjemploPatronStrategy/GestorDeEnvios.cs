namespace ExampleAPI.EjemploPatronStrategy
{
    /*(contexto) clase que utiliza el patrónStrategy para delegar el procesamientodel pago.*/
    public class GestorDeEnvios
    {
        private IEnvio _estrategiaEnvio;
        public void SetEstrategia(IEnvio estrategia)
        {
            _estrategiaEnvio = estrategia;
        }

        public decimal CalcularCosto(decimal peso)
        {
            if (_estrategiaEnvio == null)
                throw new Exception("No se ha definido una estrategia de envío.");

            return _estrategiaEnvio.CalcularCosto(peso);
        }

        public string ObtenerTiempoEntrega()
        {
            if (_estrategiaEnvio == null)
                throw new Exception("No se ha definido una estrategia de envío.");

            return _estrategiaEnvio.ObtenerTiempoEntrega();
        }
    }
}
