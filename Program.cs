const int NUEVA_INSCRIPCION = 1, OBTENER_ESTADISTICAS = 2, BUSCAR_CLIENTE = 3, CAMBIAR_ENTRADA = 4, SALIR = 5, OP1 = 45000, OP2 = 60000, OP3 =30000, FP = 100000, DIA_UNO = 1, DIA_DOS = 2, DIA_TRES = 3, DIA_CUATRO = 4;
int opcion, dni, tipoEntrada=0, cantidad, idCliente = 10000, recaudacionTotal = 0;
string nombre, apellido;
DateTime fechaInscripcion = new DateTime();
Dictionary<int, Cliente> diccionarioCliente= new Dictionary<int, Cliente>();

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
        break;

        case OBTENER_ESTADISTICAS:
        foreach (Cliente cliente in diccionarioCliente.Values){
            int clientesDia1=0, clientesDia2=0, clientesDia3=0, clientesFP=0;
            if(tipoEntrada==1){
                clientesDia1++;
            }
             if(tipoEntrada==2){
                clientesDia2++;
            }
             if(tipoEntrada==3){
                clientesDia3++;
            }
             if(tipoEntrada==4){
                clientesFP++;
            }
            int clientesTotales= clientesDia1 + clientesDia2 + clientesDia3 + clientesFP;
{
        }
        Console.WriteLine("hay una cantidad de " + clientesTotales + " inscriptos");
        Console.WriteLine($"hay {clientesDia1} iscriptos el dia 1, {clientesDia2} inscriptos el dia 2, {clientesDia3} inscriptos el dia 3 y {clientesFP} iscriptos los 4 dias");
}
        break;

        case BUSCAR_CLIENTE: 
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
