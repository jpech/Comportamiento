using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasDeResponsabilidades
{
    public class Subdirector : AbstractHandler
    {
        public override object AutorizarComprar(object monto)
        {
            if((double)monto > 10000 && (double)monto <= 15000)
                return $"Autorizada por el Subdirector";
            else
                return base.AutorizarComprar(monto);
        }
    }
}
