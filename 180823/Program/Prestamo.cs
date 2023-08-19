class Prestamo {
    // Atributos
    private int cantidadDias ;
    private Pelicula pelicula;
    private Fecha fechaPrestamo;
    private Cliente cliente;

    // Constructor
    public Prestamo(int cantidadDias, Pelicula pelicula, Fecha fechaPrestamo, Cliente cliente) {
        this.cantidadDias = cantidadDias;
        this.pelicula = pelicula;
        this.fechaPrestamo = fechaPrestamo;
        this.cliente = cliente;
    }
}
