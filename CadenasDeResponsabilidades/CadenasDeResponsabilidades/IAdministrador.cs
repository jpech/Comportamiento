namespace CadenasDeResponsabilidades
{
    public interface IAdministrador
    {
        object AutorizarComprar(object monto);

        IAdministrador SetNext(IAdministrador handler);
    }
}
