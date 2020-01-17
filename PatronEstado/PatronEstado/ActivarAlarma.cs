using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronEstado
{
    public class ActivarAlarma : IState
    {
        protected Context _context;

        public void DesactivarAlarma()
        {
            var desactivar = new ActivarAlarma();
            desactivar.SetContext(_context);
            _context.ChageState(desactivar);
            Console.WriteLine("Alarma inactiva");
        }

        public void SetContext(Context context)
        {
            this._context = context;
        }

        void IState.ActivarAlarma()
        {
            Console.WriteLine("Alarma Activa");
        }
    }
}
