class Persona {
    public int Dni { get; private set; }
    public string Apellido { get; private set; } 
    public string Nombre{get; private set;}
    public DateTime FechaInscripcion { get;  set; }
    public int TipoEntrada { get; set; }
    public int Cantidad{get; set;}

 public Persona(int dni,  string apellido,string nombre, DateTime fechaInscripcion, int tipoEntrada, int cantidad) {
       
        Dni = dni; 
        Apellido = apellido ;
        Nombre = nombre;
        FechaInscripcion = fechaInscripcion;
        TipoEntrada = TipoEntrada;
        Cantidad = Cantidad;
    }
}