using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObservador
{
    public class NotificarEnvioCorreo : IObserver
    {
        public void Actualizar(IObservado observado)
        {
            Console.WriteLine("Correo de Notificación Enviada.");
        }
    }
}
