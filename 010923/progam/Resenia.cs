class Resenia
{
    // Atributos
    private Usuario autor;
    private string titulo;
    private string texto;
    private Fecha fecha;
    private bool esPositiva;

    // Getter y Setter
    public Usuario Autor { get { return autor; } }
    public string Titulo { get { return titulo; } }
    public string Texto { get { return texto; } }
    public Fecha Fecha { get { return fecha; } }
    public bool EsPositiva { get { return esPositiva; } }

    // Constructor
    public Resenia(Usuario autor, string titulo, string texto, Fecha fecha, bool esPositiva)
    {
        this.autor = autor;
        this.titulo = titulo;
        this.texto = texto;
        this.fecha = fecha;
        this.esPositiva = esPositiva;
    }
}