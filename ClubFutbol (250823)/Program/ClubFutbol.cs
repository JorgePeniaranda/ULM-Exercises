class ClubFutbol
{
    // Atributos
    private string nombre;
    private string anioFundacion;
    private Direccion direccion;
    private List<Equipo> listaEquipo;
    private List<EmpleadoAdministrativo> listaEmpleado;

    // Getters
    public string Nombre { get { return nombre; } }
    public string AnioFundacion { get { return anioFundacion; } }
    public Direccion Direccion { get { return direccion; } }
    public List<Equipo> ListaEquipo { get { return listaEquipo; } }
    public List<EmpleadoAdministrativo> ListaEmpleado { get { return listaEmpleado; } }

    // Constructor
    public ClubFutbol(string nombre, string anioFundacion, Direccion direccion, List<Equipo> listaEquipo, List<EmpleadoAdministrativo> listaEmpleado)
    {
        this.nombre = nombre;
        this.anioFundacion = anioFundacion;
        this.direccion = direccion;
        this.listaEquipo = listaEquipo;
        this.listaEmpleado = listaEmpleado;
    }

    // Agregar y remover equipos
    public void agregarEquipo(Equipo equipo)
    {
        listaEquipo.Add(equipo);
    }
    public void quitarEquipo(Equipo equipo)
    {
        listaEquipo.Remove(equipo);
    }

    // Agregar y remover empleados
    public void agregarEmpleado(EmpleadoAdministrativo empleado)
    {
        ListaEmpleado.Add(empleado);
    }
    public void quitarEmpleado(EmpleadoAdministrativo empleado)
    {
        ListaEmpleado.Remove(empleado);
    }
}