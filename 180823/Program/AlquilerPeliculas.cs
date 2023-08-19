class AlquilerPeliculas {
    // Atributos
    private string nombre;
    private List<Local> listaLocal = new List<Local>();

    // Constructor
    public AlquilerPeliculas(string nombre, List<Local> listaLocal) {
        this.nombre = nombre;
        this.listaLocal = listaLocal;
    }
}
