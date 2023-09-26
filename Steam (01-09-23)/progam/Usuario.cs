class Usuario
{
    // Atributos
    private string nombre;
    private int edad;
    private double saldoCuenta;
    private List<Aplicacion> listAplicacion;

    // Getter y Setter
    public string Nombre { get { return nombre; } }
    public int Edad { get { return edad; } }
    public double SaldoCuenta { get { return saldoCuenta; } }
    public List<Aplicacion> ListAplicacion { get { return listAplicacion; } }

    // Constructor
    public Usuario(string nombre, int edad, double saldoCuenta, List<Aplicacion> listAplicacion)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.saldoCuenta = saldoCuenta;
        this.listAplicacion = listAplicacion;
    }
}