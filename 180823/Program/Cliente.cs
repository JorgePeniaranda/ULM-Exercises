class Cliente
{
    // Atributos
    private string nombre;
    private string apellido;
    private Direccion direccion;
    private int id;

    // Getters
    public string Nombre { get { return nombre; } }
    public string Apellido { get { return apellido; } }
    public Direccion Direccion { get { return direccion; } }
    public int ID { get { return id; } }

    // Constructor
    public Cliente(string nombre, string apellido, Direccion direccion, int id)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.direccion = direccion;
        this.id = id;
    }

}
