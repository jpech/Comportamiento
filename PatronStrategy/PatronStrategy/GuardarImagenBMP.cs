using System;

namespace PatronStrategy
{
    public class GuardarImagenBMP : IGuardardor
    {
        public void GuardarImagen()
        {
            Console.WriteLine("Introduzca nombre de la imagen");
            string Nombre;
            Nombre = Console.ReadLine();
            Console.WriteLine(string.Format("{0}{1}{2}", "Se ha guardado la imagen ", Nombre, ".BMP"));
        }
    }
}
