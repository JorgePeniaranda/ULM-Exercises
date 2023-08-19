class AlquilerPeliculas
{
    // Atributos
    private string nombre;
    private List<Local> listaLocal = new List<Local>();

    // Getters
    public string Nombre { get { return nombre; } }
    public List<Local> ListaLocal { get { return listaLocal; } }

    // Constructor
    public AlquilerPeliculas(string nombre, List<Local> listaLocal)
    {
        this.nombre = nombre;
        this.listaLocal = listaLocal;
    }
}
