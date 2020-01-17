using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObservador
{
    public class NotificarVersion : IObserver
    {
        public void Actualizar(IObservado observado)
        {
            Console.WriteLine("Se ha instalado la versión.");
        }
    }
}
