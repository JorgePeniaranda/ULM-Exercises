class Entrenador : Persona
{
    // Atributos
    private Tacticas tactica;

    // Getters
    public Tacticas Tactica { get { return tactica; } }

    // Constructor
    public Entrenador(string nombre, string apellido, Tacticas tactica) : base(nombre, apellido)
    {
        this.tactica = tactica;
    }

    // Metodos
    public override string Presentar()
    {
        return $"¡Hola, soy {base.Nombre} {base.Apellido} y mi tactica es {this.Tactica}!";
    }
}