using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronEstado
{
    public interface IState
    {
        void ActivarAlarma();
        void DesactivarAlarma();
    }
}
