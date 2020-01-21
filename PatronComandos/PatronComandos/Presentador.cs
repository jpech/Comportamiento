using System;

namespace PatronComandos
{
    public static class Presentador
    {
        public static void PintarMenuPrincipal()
        {
            Console.WriteLine("Seleccion el tipo de Guerrero que quiere crear");
            Console.WriteLine("10. Guerrero de clase baja");
            Console.WriteLine("20. Guerrero de clase media");
            Console.WriteLine("30. Guerrero de clase alta");
        }

        public static void PintarMenuAcciones()
        {
            Console.WriteLine();
            Console.WriteLine("=========== Acciones ==========");
            Console.WriteLine("Presione 1 para Caminar");
            Console.WriteLine("Presione 2 para Saltar");
            Console.WriteLine("Presione 3 para Golpear");
            Console.WriteLine("Presione 4 para Disparar Pistola");
            Console.WriteLine("Presione 5 para Conseguir Lanza Granadas");
            Console.WriteLine("Presione 6 para Conseguir Rifle Plasma");
            Console.WriteLine();
        }
    }
}
