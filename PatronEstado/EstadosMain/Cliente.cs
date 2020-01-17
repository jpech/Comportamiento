using PatronEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadosMain
{
    public class Cliente
    {
        IState state = new ActivarAlarma();
        
    }
}
