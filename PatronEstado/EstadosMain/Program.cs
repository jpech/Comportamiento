using PatronEstado;
using System;

namespace EstadosMain
{
    class Program
    {
        static void Main(string[] args)
        {
            ActivarAlarma state = new ActivarAlarma();

            Context ctx = new Context(state);
            state.SetContext(ctx);
            ctx.SolicitarActivar();

            Console.ReadLine();
        }
    }
}
