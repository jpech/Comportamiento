using System;

namespace PatronObservador
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Observado();
            var y = new NotificarEnvioCorreo();
            var z = new NotificarVersion();

            s.Attach(y);
            s.Attach(z);

            s.SubirCodigo();

            Console.ReadLine();
        }
    }
}
