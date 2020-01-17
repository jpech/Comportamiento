using System;
using System.Collections.Generic;

namespace PatronObservador
{
    public class Observado : IObservado
    {
        public List<IObserver> Observadores { get; set; }

        public Observado()
        {
            Observadores = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            Observadores.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            foreach (var item in Observadores)
            {
                item.Actualizar(this);
            }
        }

        public void SubirCodigo()
        {
            Console.WriteLine("Subir codigo");
            Notify();
        }
    }
}
