class Software : Aplicacion
{
    // Atributos
    private CategoriaSoftware categoria;

    // Getter y Setter
    public CategoriaSoftware Categoria { get { return categoria; } }

    // Constructor
    public Software(string nombre, double precio, bool estaEnAccesoAnticipado, double valoracion, List<Resenia> listResenia, CategoriaSoftware categoria) : base(nombre, precio, estaEnAccesoAnticipado, valoracion, listResenia)
    {
        this.categoria = categoria;
    }
}