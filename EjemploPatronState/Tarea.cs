namespace ExampleAPI.EjemploPatronState
{
    public class Tarea
    {
        private IEstado _estadoPendiente;
        private IEstado _estadoEnProgreso;
        private IEstado _estadoCompletada;
        private IEstado _estadoActual;

        public Tarea()
        {
            //inicializo los estados
            _estadoPendiente = new EstadoPendiente(this);
            _estadoEnProgreso = new EstadoEnProgreso(this);
            _estadoCompletada = new EstadoCompletada(this);

            // Estado inicial
            _estadoActual = _estadoPendiente;
        }

        public void SetEstado(IEstado estado)
        {
            _estadoActual = estado;
        }

        public IEstado GetEstadoPendiente() => _estadoPendiente;
        public IEstado GetEstadoEnProgreso() => _estadoEnProgreso;
        public IEstado GetEstadoCompletada() => _estadoCompletada;

        public string Cambiar() => _estadoActual.Cambiar();
        public string MostrarEstado()
        {
            string estado = _estadoActual.ObtenerEstado();
            return "La tarea esta en estado: " + estado;
        }
    }
}
