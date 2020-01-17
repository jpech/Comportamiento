using System;

namespace PatronObservador
{
    public class NotificarEjecucionPU : IObserver
    {
        public void Actualizar(IObservado observado)
        {
            Console.WriteLine("Ejecución de Pruebas Unitarias.");
        }
    }
}
