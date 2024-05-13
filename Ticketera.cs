static class Ticketera
{
    private static Dictionary<int, Cliente> DicCliente = new Dictionary<int, Cliente>();
    private static int UltimoIDEntrada = 0;

    public static int DevolverUltimoID()
    {
        return UltimoIDEntrada++;
    }
    public static int AgregarCliente(Cliente cliente)
    {
        int IDCliente = DevolverUltimoID();
        return IDCliente;
    }
    public static Cliente BuscarCliente(int IDCliente)
    {
        
    }
}