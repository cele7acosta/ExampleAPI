namespace ExampleAPI.EjemploPatronState
{
    public class EstadoCompletada : IEstado
    {
        private readonly Tarea _tarea;

        public EstadoCompletada(Tarea tarea)
        {
            _tarea = tarea;
        }

        public string Cambiar()
        {
            return "La tarea ya está completada. No se puede cambiar de estado.";
        }

        public string ObtenerEstado() => "Completada";
    }
}
