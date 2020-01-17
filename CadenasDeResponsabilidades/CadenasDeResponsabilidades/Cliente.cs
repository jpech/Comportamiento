using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasDeResponsabilidades
{
    public class Cliente
    {
        public static void ClientCode(AbstractHandler handler, double monto)
        {
            var result = handler.AutorizarComprar(monto);
            if (result != null)
            {
                Console.WriteLine($"   {result}");
            }
            else
            {
                Console.WriteLine($"   {monto} was left untouched.");
            }
        }
    }
}
