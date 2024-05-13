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
        DicCliente.Add(IDCliente, cliente);
        return IDCliente;
    }
    public static Cliente BuscarCliente(int IDCliente)
    {
        if(DicCliente.ContainsKey(IDCliente))
        {
            return DicCliente[IDCliente];
        }
        else
        {
            return null;
        }
    }
    public static bool CambiarEntrada(int IDCliente, int tipoEntradaNuevo, int cantidadNueva)
    {
        bool pudo = false;
        Cliente buscado = BuscarCliente(IDCliente);
        int importeViejo = DicCliente[IDCliente].Cantidad * DicCliente[IDCliente].TipoEntrada;
        int importeNuevo = tipoEntradaNuevo * cantidadNueva;
        if(importeNuevo > importeViejo)
        {
            pudo = true;
            DicCliente[IDCliente].TipoEntrada = tipoEntradaNuevo;
            DicCliente[IDCliente].Cantidad = cantidadNueva;
        }
        return pudo;
    }
    public static List<string> EstadisticasTicketera()
    {
        List<string> estadisticas = new List<string>();

        if (DicCliente.Count == 0)
        {
            estadisticas.Add("Todavia nadie se anoto");
        }
        else
        {
            estadisticas.Add($"Cantidad de Clientes inscriptos: {DicCliente.Count}");

            Dictionary<int, int> cantidadPorTipo = new Dictionary<int, int>();
            Dictionary<int, decimal> recaudacionPorTipo = new Dictionary<int, decimal>();

            foreach (Cliente cliente in DicCliente.Values)
            {
                if (!cantidadPorTipo.ContainsKey(cliente.TipoEntrada))
                    cantidadPorTipo[cliente.TipoEntrada] = 0;
                cantidadPorTipo[cliente.TipoEntrada]++;

                decimal importe = ObtenerImporte(cliente.TipoEntrada);
                if (!recaudacionPorTipo.ContainsKey(cliente.TipoEntrada))
                    recaudacionPorTipo[cliente.TipoEntrada] = 0;
                recaudacionPorTipo[cliente.TipoEntrada] += importe;
            }

            foreach (KeyValuePair<int, int> kvp in cantidadPorTipo)
            {
                decimal recaudacionTipo = recaudacionPorTipo[kvp.Key];
                decimal porcentaje = (decimal)kvp.Value / DicCliente.Count * 100;
                estadisticas.Add($"Cantidad de Clientes que compraron la entrada {kvp.Key}: {kvp.Value}, Porcentaje: {porcentaje:F2}%");
                estadisticas.Add($"Recaudación de la entrada {kvp.Key}: ${recaudacionTipo}");
            }

            decimal recaudacionTotal = 0;
            foreach (decimal valor in recaudacionPorTipo.Values)
            {
                recaudacionTotal += valor;
            }
            estadisticas.Add($"Recaudación total: ${recaudacionTotal}");
        }

        return estadisticas;
    }
    private static int ObtenerImporte(int tipoEntrada)
    {
        switch (tipoEntrada)
        {
            case 1:
                return 45000;
            case 2:
                return 60000;
            case 3:
                return 30000;
            case 4:
                return 100000;
            default:
                return 0;
        }
    }
}