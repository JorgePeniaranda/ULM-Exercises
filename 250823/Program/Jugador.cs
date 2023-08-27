class Jugador : Persona
{
    // Atributos
    private int dorsal;

    // Getters
    public int Dorsal { get { return dorsal; } }

    // Constructor
    public Jugador(string nombre, string apellido, int dorsal) : base(nombre, apellido)
    {
        this.dorsal = dorsal;
    }

    // Metodos
    public override string Presentar()
    {
        return $"¡Hola, soy {base.Nombre} {base.Apellido} y soy el dorsal {this.dorsal}!";
    }
}