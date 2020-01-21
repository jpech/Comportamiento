using System;

namespace PatronComandos
{
    public class ComandoCrearGerrero : IPersonaje
    {
        private Receiver _receiver;

        public ComandoCrearGerrero(Receiver receiver)
        {
            this._receiver = receiver;
        }

        public Guerrero CrearGuerrero(Guerrero guerrero)
        {
            Console.WriteLine($"Se creó el guerrero con poder de {guerrero.Poder}");
            return this._receiver.CrearGerrero(guerrero);
        }
    }
}
