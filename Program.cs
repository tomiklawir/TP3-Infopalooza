const int NUEVA_INSCRIPCION = 1, OBTENER_ESTADISTICAS = 2, BUSCAR_CLIENTE = 3, CAMBIAR_ENTRADA = 4, SALIR = 5;
int opcion, dni, tipoEntrada, cantidad, idCliente = 10000;
string nombre, apellido;
DateTime fechaInscripcion = new DateTime();

do{
    opcion = IngresarNumero("Ingrese un numero: NUEVA INSCRIPCION = 1, OBTENER ESTADISTICAS = 2, BUSCAR CLIENTE = 3, CAMBIAR ENTRADA = 4, SALIR = 5");
}while(opcion < 1 && opcion > 5);

while(opcion != 5)
{   switch(opcion)
    {
        case NUEVA_INSCRIPCION:
        dni = IngresarNumero("Ingrese su dni");
        apellido = IngresarString("Ingrese su apellido");
        nombre = IngresarString("Ingrese su nombre");
        fechaInscripcion = IngresarFecha("Ingrese la fecha de inscripcion");

        cantidad = IngresarNumero("Ingrse la cantidad de entradas");
        break;

        case OBTENER_ESTADISTICAS: 
        break;

        case BUSCAR_CLIENTE: 
        break;

        case CAMBIAR_ENTRADA: 
        break;
    }
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