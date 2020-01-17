using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronEstado
{
    public class Context
    {
        private IState _state = null;

        public Context(IState initialState)
        {
            _state = initialState;
        }

        public void ChageState(IState state)
        {
            if(state == _state)
                Console.WriteLine($"Context: La alarma ya se encuentra {state.GetType().Name}.");

            Console.WriteLine($"Context: Se cambió al estado {state.GetType().Name}.");
            this._state = state;
        }

        public void SolicitarActivar()
        {
            this._state.ActivarAlarma();
        }
    }
}
