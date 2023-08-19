class Pelicula
{
    // Atributos
    private string titulo;
    private int duracion;
    private Genero genero;

    // Getters
    public string Titulo { get { return titulo; } }
    public int Duracion { get { return duracion; } }
    public Genero Genero { get { return genero; } }

    // Constructor
    public Pelicula(string titulo, int duracion, Genero genero)
    {
        this.titulo = titulo;
        this.duracion = duracion;
        this.genero = genero;
    }
}
