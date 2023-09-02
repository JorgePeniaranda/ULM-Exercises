class Plataforma
{
    // Atributos
    private string nombre;
    private List<Aplicacion> listAplicacion;
    private List<Usuario> listUsuario;

    // Getter y Setter
    public string Nombre { get { return nombre; } }
    public List<Aplicacion> ListAplicacion { get { return listAplicacion; } }
    public List<Usuario> ListUsuario { get { return listUsuario; } }

    // Constructor
    public Plataforma(string nombre, List<Aplicacion> listAplicacion, List<Usuario> listUsuario)
    {
        this.nombre = nombre;
        this.listAplicacion = listAplicacion;
        this.listUsuario = listUsuario;
    }
}