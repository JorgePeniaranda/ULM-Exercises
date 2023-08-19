class Local {
    // Atributos
    private string nombre;
    private Direccion direccion;
    private List<Pelicula> listaPelicula = new List<Pelicula>();
    private List<Prestamo> listaPrestamo = new List<Prestamo>();
    private List<Cliente> listaCliente = new List<Cliente>();

    // Constructor
    public Local(string nombre, Direccion direccion, List<Pelicula> listaPelicula, List<Prestamo> listaPrestamo, List<Cliente> listaCliente) {
        this.nombre = nombre;
        this.direccion = direccion;
        this.listaPelicula = listaPelicula;
        this.listaPrestamo = listaPrestamo;
        this.listaCliente = listaCliente;
    }

}
