abstract class Persona
{
    // Atributos
    private string nombre;
    private string apellido;

    // Getters
    public string Nombre { get { return nombre; } }
    public string Apellido { get { return apellido; } }

    // Constructor
    public Persona(string nombre, string apellido)
    {
        this.nombre = nombre;
        this.apellido = apellido;
    }

    // Metodos
    public abstract string Presentar();
}