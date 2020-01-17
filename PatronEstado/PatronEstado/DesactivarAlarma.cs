using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronEstado
{
    public class DesactivarAlarma : IState
    {
        protected Context _context;

        public void ActivarAlarma()
        {
            _context.ChageState(new ActivarAlarma());
            Console.WriteLine("Alarma Activa");
        }

        public void SetContext(Context context)
        {
            this._context = context;
        }

        void IState.DesactivarAlarma()
        {
            _context.ChageState(this);
            Console.WriteLine("Alarma inactiva");
        }
    }
}
