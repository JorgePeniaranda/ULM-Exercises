class Pelicula {
    // Atributos
    private string nombre;
    private Direccion direccion;
    private list<Pelicula> listaPelicula = new list<>();
    private list<Prestamo> listaPrestamo = new list<>();
    private list<Cliente> listaCliente = new list<>();

    // Constructor
    public AlquilerPeliculas(nombre, direccion, listaPrestamo, listaCliente) {
        this.nombre = nombre;
        this.direccion = direccion;
        this.listaPelicula = listaPelicula;
        this.listaPrestamo = listaPrestamo;
        this.listaCliente = listaCliente;
    }
}
