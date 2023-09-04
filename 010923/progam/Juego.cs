class Juego : Aplicacion
{
    // Atributos
    private int edadMinima;
    private CategoriaJuego categoria;

    // Getter y Setter
    public int EdadMinima { get { return edadMinima; } }

    // Constructor
    public Juego(string nombre, double precio, bool estaEnAccesoAnticipado, double valoracion, List<Resenia> ListResenia, int edadMinima, CategoriaJuego categoria) : base(nombre, precio, estaEnAccesoAnticipado, valoracion, ListResenia)
    {
        this.edadMinima = edadMinima;
        this.categoria = categoria;
    }

    // Get Categoria
    public override string getCategoria()
    {
        return categoria.ToString();
    }
}