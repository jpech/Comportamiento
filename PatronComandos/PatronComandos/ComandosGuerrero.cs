using System;

namespace PatronComandos
{
    public class ComandosGuerrero : IAccionesGuerrero
    {
        private Guerrero guerrero;

        public ComandosGuerrero(Guerrero _guerrero)
        {
            this.guerrero = _guerrero;
        }

        public void Caminar()
        {
            Console.WriteLine($"{guerrero.Nombre} CAMINANDO con velocidad de {guerrero.Poder}");
        }

        public void ConseguirLanzaGranadas()
        {
            Console.WriteLine($"{guerrero.Nombre} ha conseguido lanza granadas con poder de {guerrero.Poder}");
            guerrero.lConseguirLanzaGranadas = true;
        }

        public void ConseguirRiflePlasma()
        {
            Console.WriteLine($"{guerrero.Nombre} ha conseguido rifle de plasma con poder de {guerrero.Poder}");
            guerrero.lConseguirRiflePlasma = true;
        }

        public void DispararPistola()
        {
            Console.WriteLine($"{guerrero.Nombre} DISPARA PISTOLA con velocidad de {guerrero.Poder}");
        }

        public void Golpear()
        {
            Console.WriteLine($"{guerrero.Nombre} GOLPEANDO con velocidad de {guerrero.Poder}");
        }

        public void Saltar()
        {
            Console.WriteLine($"{guerrero.Nombre} SALTANDO con velocidad de {guerrero.Poder}");
        }
    }
}
