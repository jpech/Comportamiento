using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasDeResponsabilidades
{
    public class Default : AbstractHandler
    {
        public override object AutorizarComprar(object monto)
        {
            if((double)monto > 50000)
                return $"La solicitud será denegada";
            else
                return base.AutorizarComprar(monto);
        }
    }
}
