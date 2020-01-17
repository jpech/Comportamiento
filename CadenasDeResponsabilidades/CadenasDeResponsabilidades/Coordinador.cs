using System;

namespace CadenasDeResponsabilidades
{
    public class Coordinador : AbstractHandler
    {
        public override object AutorizarComprar(object monto)
        {
            if ((double)monto <= 5000)
                  return $"Autorizada por el Coordinador";
            else
                return base.AutorizarComprar(monto);
        }
    }
}
