namespace ExampleAPI.EjemploPatronState
{
    public class EstadoEnProgreso : IEstado
    {
        private readonly Tarea _tarea;

        public EstadoEnProgreso(Tarea tarea)
        {
            _tarea = tarea;
        }

        public string Cambiar()
        {
            _tarea.SetEstado(_tarea.GetEstadoCompletada());
            return "Cambiando de En progreso a Completada";
        }

        public string ObtenerEstado() => "En progreso";
    }
}
