using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasDeResponsabilidades
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordinador = new Coordinador();
            var gerente = new Gerente();
            var subdirector = new Subdirector();
            var director = new Director();
            var def = new Default();

            coordinador.SetNext(gerente).SetNext(subdirector).SetNext(director).SetNext(def);
            Cliente.ClientCode(coordinador, 90000);
            Console.ReadLine();
        }
    }
}
