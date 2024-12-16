namespace ExampleAPI.EjemploPatronStrategy
{
    public interface IEnvio
    {
        decimal CalcularCosto(decimal peso);
        string ObtenerTiempoEntrega();
    }
}
