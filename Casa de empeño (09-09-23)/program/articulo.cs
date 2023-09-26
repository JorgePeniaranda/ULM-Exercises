class Articulo
{
    private string nombre;
    private double precio;
    private bool seVende;
    private Estados estado;
    private Categorias categoria;

    // Getter y Setter
    public string Nombre
    {
        get { return nombre; }
    }
    public double Precio
    {
        get { return precio; }
    }
    public bool SeVende
    {
        get { return seVende; }
    }
    public Estados Estado
    {
        get { return estado; }
    }
    public Categorias Categoria
    {
        get { return categoria; }
    }

    // Constructor
    public Articulo(
        string nombre,
        double precio,
        bool seVende,
        Estados estado,
        Categorias categoria
    )
    {
        this.nombre = nombre;
        this.precio = precio;
        this.seVende = seVende;
        this.estado = estado;
        this.categoria = categoria;
    }
}
