using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy
{
    public class GuardarImagenJPGE : IGuardardor
    {
        public void GuardarImagen()
        {
            Console.WriteLine("Introduzca nombre de la imagen");
            string Nombre;
            Nombre = Console.ReadLine();
            Console.WriteLine(string.Format("{0}{1}{2}", "Se ha guardado la imagen ", Nombre, ".JPGE"));
        }
    }
}
