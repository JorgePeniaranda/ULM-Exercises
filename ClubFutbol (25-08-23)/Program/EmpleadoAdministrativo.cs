class EmpleadoAdministrativo : Persona
{
    // Atributos
    private string funcion;

    // Getters
    public string Funcion { get { return funcion; } }

    // Constructor
    public EmpleadoAdministrativo(string nombre, string apellido, string funcion) : base(nombre, apellido)
    {
        this.funcion = funcion;
    }

    // Metodos
    public override string Presentar()
    {
        return $"¡Hola, soy {base.Nombre} {base.Apellido} y mi función es {this.Funcion}!";
    }
}