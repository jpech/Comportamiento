using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Context();

            Console.WriteLine("Seleccione el tipo de la imagen a guardar...");
            Console.WriteLine("1 para BMP");
            Console.WriteLine("2 para PNG");
            Console.WriteLine("3 para JPGE");
            string op = Console.ReadLine();
            switch (op)
            {
                case "1": 
                    var str = new GuardarImagenBMP();
                    ctx.AsignarEstrategia(str);
                    break;
                case "2":
                    var str2 = new GuardarImagenPNG();
                    ctx.AsignarEstrategia(str2);
                    break;
                case "3":
                    var str3 = new GuardarImagenJPGE();
                    ctx.AsignarEstrategia(str3);
                    break;
                default:
                    
                    break;
            }
            ctx.SilumarGuardado();
            Console.ReadLine();
        }
    }
}
