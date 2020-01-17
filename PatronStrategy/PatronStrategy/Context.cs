namespace PatronStrategy
{
    public class Context
    {
        private IGuardardor _guardardor { get; set; }

        public void AsignarEstrategia(IGuardardor estrategia)
        {
            _guardardor = estrategia;
        }

        public void SilumarGuardado()
        {
            _guardardor.GuardarImagen();
        }
    }
}
