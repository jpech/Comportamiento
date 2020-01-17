using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasDeResponsabilidades
{
    public class Director :AbstractHandler
    {
        public override object AutorizarComprar(object monto)
        {
            if((double)monto > 15000 && (double)monto <= 50000)
                return "Autorizada por el Director";
            else
                return base.AutorizarComprar(monto);
        }
    }
}
