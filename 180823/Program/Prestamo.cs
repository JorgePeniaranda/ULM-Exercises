class Prestamo
{
    // Atributos
    private int cantidadDias;
    private Pelicula pelicula;
    private Fecha fechaPrestamo;
    private Cliente cliente;

    // Getters
    public int CantidadDias { get { return cantidadDias; } }
    public Pelicula Pelicula { get { return pelicula; } }
    public Fecha FechaPrestamo { get { return fechaPrestamo; } }
    public Cliente Cliente { get { return cliente; } }

    // Constructor
    public Prestamo(int cantidadDias, Pelicula pelicula, Fecha fechaPrestamo, Cliente cliente)
    {
        this.cantidadDias = cantidadDias;
        this.pelicula = pelicula;
        this.fechaPrestamo = fechaPrestamo;
        this.cliente = cliente;
    }
}
