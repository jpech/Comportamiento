using System;

namespace PatronComandos
{
    public class Invoker
    {
        private IPersonaje _personaje;
        private IAccionesGuerrero _acciones;
        private Guerrero _guerrero;

        public void AsignarComando(IPersonaje personaje, Guerrero guerrero)
        {
            this._personaje = personaje;
            this._guerrero = guerrero;
        }

        public void AsignarComandoAcciones(IAccionesGuerrero acciones, Guerrero guerrero)
        {
            this._acciones = acciones;
            this._guerrero = guerrero;
        }

        public Guerrero CrearGerrero(Guerrero guerrero, string op)
        {
            if (_personaje is IPersonaje)
            {
                switch (op)
                {
                    case "10":
                        guerrero.Poder = Convert.ToInt32(op);
                        break;
                    case "20":
                        guerrero.Poder = Convert.ToInt32(op);
                        break;
                    case "30":
                        guerrero.Poder = Convert.ToInt32(op);
                        break;
                    default:
                        Console.WriteLine("No existe la opción seleccionada.");
                        Environment.Exit(-1);
                        break;
                }

                return this._personaje.CrearGuerrero(guerrero);
            }
            return new Guerrero();
        }

        public void AccionCaminar()
        {
            if (_acciones is IAccionesGuerrero)
                this._acciones.Caminar();
        }

        public void AccionSaltar()
        {
            if (_acciones is IAccionesGuerrero)
                this._acciones.Saltar();
        }

        public void AccionGolpear()
        {
            if (_acciones is IAccionesGuerrero)
                this._acciones.Golpear();
        }

        public void AccionDispararPistola()
        {
            if (_acciones is IAccionesGuerrero)
                this._acciones.DispararPistola();
        }

        public void ConseguirLanzaGranadas()
        {
            if (_acciones is IAccionesGuerrero)
                this._acciones.ConseguirLanzaGranadas();
        }

        public void ConseguirRiflePlasma()
        {
            if (_acciones is IAccionesGuerrero)
                this._acciones.ConseguirRiflePlasma();
        }
    }
}
