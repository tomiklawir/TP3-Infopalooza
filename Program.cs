const int NUEVA_INSCRIPCION = 1, OBTENER_ESTADISTICAS = 2, BUSCAR_CLIENTE = 3, CAMBIAR_ENTRADA = 4, SALIR = 5;
int opcion;

do{
    opcion = IngresarNumero("Ingrese un numero: NUEVA INSCRIPCION = 1, OBTENER ESTADISTICAS = 2, BUSCAR CLIENTE = 3, CAMBIAR ENTRADA = 4, SALIR = 5");
}while(opcion < 1 && opcion > 5);

while(opcion != 5)
{   switch(opcion)
    {
        case NUEVA_INSCRIPCION: 
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
Console.WriteLine(mensaje);
int num= int.Parse(Console.ReadLine());
return num;
}