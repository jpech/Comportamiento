using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasDeResponsabilidades
{
    public class Gerente : AbstractHandler
    {
        public override object AutorizarComprar(object monto)
        {
            if((double)monto > 5000 && (double)monto <= 10000)
                return $"Autorizada por el Gerente";
            else
                return base.AutorizarComprar(monto);
        }
    }
}
