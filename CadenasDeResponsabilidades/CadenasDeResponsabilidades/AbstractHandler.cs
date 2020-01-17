namespace CadenasDeResponsabilidades
{
    public class AbstractHandler : IAdministrador
    {
        private IAdministrador _nextHandler;

        public virtual object AutorizarComprar(object monto)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.AutorizarComprar(monto);
            }
            else
            {
                return _nextHandler =  null;
            }
        }

        public IAdministrador SetNext(IAdministrador handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }
}
