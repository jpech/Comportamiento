using System;

namespace PatronComandos
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerrero guerrero = new Guerrero();
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            invoker.AsignarComando(new ComandoCrearGerrero(receiver), guerrero);

            Presentador.PintarMenuPrincipal();
            string poder = Console.ReadLine();
            guerrero = invoker.CrearGerrero(new Guerrero(), poder);
            Console.WriteLine();

            string nombre;
            do
            {
                Console.WriteLine("Ingrese un nombre para el personaje");
                nombre = Console.ReadLine();
            } while(string.IsNullOrEmpty(nombre) || string.IsNullOrWhiteSpace(nombre));
            Console.Clear();
            guerrero.Nombre = nombre;
            Presentador.PintarMenuAcciones();
            string op = string.Empty;
            op = Console.ReadLine();
            Console.WriteLine();
            invoker.AsignarComandoAcciones(new ComandosGuerrero(guerrero), guerrero);

            switch (op)
            {
                case "1":
                    invoker.AccionCaminar();
                    break;
                case "2":
                    invoker.AccionSaltar();
                    break;
                case "3":
                    invoker.AccionGolpear();
                    break;
                case "4":
                    invoker.AccionDispararPistola();
                    break;
                case "5":
                    invoker.ConseguirLanzaGranadas();
                    break;
                case "6":
                    invoker.ConseguirRiflePlasma();
                    break;
                default:
                    Environment.Exit(-1);
                    break;

            }

            Console.ReadLine();
        }
    }
}
