namespace ExampleAPI.EjemploPatronStrategy
{
    public class EnvioInternacional : IEnvio
    {
        public decimal CalcularCosto(decimal peso)
        {
            return peso * 50; //$50 por kg
        }

        public string ObtenerTiempoEntrega()
        {
            return "7-14 días hábiles";
        }
    }
}
