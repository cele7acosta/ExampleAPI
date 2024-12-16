namespace ExampleAPI.EjemploPatronState
{
    public class EstadoPendiente : IEstado
    {
        private readonly Tarea _tarea;

        public EstadoPendiente(Tarea tarea)
        {
            _tarea = tarea;
        }
        
        public string Cambiar()
        {
            _tarea.SetEstado(_tarea.GetEstadoEnProgreso());
            return "Cambiando de Pendiente a En Progreso.";
        }

        public string ObtenerEstado() => "Pendiente";
    }
}
