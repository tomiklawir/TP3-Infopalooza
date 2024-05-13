const int NUEVA_INSCRIPCION = 1, OBTENER_ESTADISTICAS = 2, BUSCAR_CLIENTE = 3, CAMBIAR_ENTRADA = 4, SALIR = 5, DIA_UNO = 1, DIA_DOS = 2, DIA_TRES = 3, DIA_CUATRO = 4;
int opcion, dni, tipoEntrada=0, cantidad, idCliente = 1, recaudacionTotal = 0;
string nombre, apellido;
DateTime fechaInscripcion = new DateTime();
Cliente cliente;
Dictionary<int, Cliente> dineroCliente = new Dictionary<int, Cliente>();
int[] precios = {45000, 60000, 30000, 100000};


do{
    opcion = IngresarNumero("Ingrese un numero: NUEVA INSCRIPCION = 1, OBTENER ESTADISTICAS = 2, BUSCAR CLIENTE = 3, CAMBIAR ENTRADA = 4, SALIR = 5");
}while(opcion < 1 && opcion > 5);

while(opcion != SALIR)
{   switch(opcion)
    {
        case NUEVA_INSCRIPCION:
            dni = IngresarNumero("Ingrese su dni");
            apellido = IngresarString("Ingrese su apellido");
            nombre = IngresarString("Ingrese su nombre");
            fechaInscripcion = IngresarFecha("Ingrese la fecha de inscripcion");
            do{
            tipoEntrada = IngresarNumero("Ingrese el tipo de entrada");
            }while(tipoEntrada < DIA_UNO || tipoEntrada > DIA_CUATRO);
            cantidad = IngresarNumero("Ingrse la cantidad de entradas");
            int gasto = cantidad * precios[tipoEntrada - 1];
            dineroCliente.Add(gasto, cliente = new Cliente(dni, apellido, nombre, fechaInscripcion, tipoEntrada, cantidad));
        break;

        case OBTENER_ESTADISTICAS:

        break;

        case BUSCAR_CLIENTE: 
            int IDBuscado = IngresarNumero("Ingrese el ID a buscar");
            Cliente buscado = Ticketera.BuscarCliente(IDBuscado);
            Console.WriteLine("Dni: " + buscado.Dni);
            Console.WriteLine("Apellido: " + buscado.Apellido);
            Console.WriteLine("Nombre: " + buscado.Nombre);
            Console.WriteLine("Fecha inscripcion: " + buscado.FechaInscripcion);
            Console.WriteLine("Tipo entrada: " + buscado.TipoEntrada);
            Console.WriteLine("Cantidad: " + buscado.Cantidad);
            
        break;

        case CAMBIAR_ENTRADA: 
        break;
    }
    do{
    opcion = IngresarNumero("Ingrese un numero: NUEVA INSCRIPCION = 1, OBTENER ESTADISTICAS = 2, BUSCAR CLIENTE = 3, CAMBIAR ENTRADA = 4, SALIR = 5");
    }while(opcion < NUEVA_INSCRIPCION && opcion > SALIR);
}


static int IngresarNumero(string mensaje)
{
    int num;
    do{
        Console.WriteLine(mensaje);
        num= int.Parse(Console.ReadLine());
    }while(num < 0);
    return num;
}

static string IngresarString(string mensaje){
    string cadena;
    do{
        Console.WriteLine(mensaje);
        cadena = Console.ReadLine();
    }while(cadena == string.Empty);
    return cadena;
}

static DateTime IngresarFecha(string mensaje){
    DateTime fecha = new DateTime();
    do{
        Console.WriteLine(mensaje);
        fecha = DateTime.Parse(Console.ReadLine());
    }while(fecha == null);
    return fecha;
}
