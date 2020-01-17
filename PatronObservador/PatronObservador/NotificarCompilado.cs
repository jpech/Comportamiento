using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObservador
{
    public class NotificarCompilado : IObserver
    {
        public void Actualizar(IObservado observado)
        {
            Console.WriteLine("El código ya compiló");
        }
    }
}
