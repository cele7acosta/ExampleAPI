namespace ExampleAPI.EjemploPatronStrategy
{
    public class EnvioExpres : IEnvio
    {
        public decimal CalcularCosto(decimal peso)
        {
            return peso * 20; //$20 por kg
        }

        public string ObtenerTiempoEntrega()
        {
            return "1-2 días hábiles";
        }
    }
}
