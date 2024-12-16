namespace ExampleAPI.EjemploPatronStrategy
{
    public class EnvioEstandar : IEnvio
    {
        public decimal CalcularCosto(decimal peso)
        {
            return peso * 10; // $10 por kg
        }

        public string ObtenerTiempoEntrega()
        {
            return "5-7 días hábiles";
        }
    }
}
