class Equipo
{
    // Atributos
    private Categorias categoria;
    private Entrenador entrenador;
    private List<Jugador> listaJugador;

    // Getters
    public Categorias Categoria { get { return categoria; } }
    public Entrenador Entrenador { get { return entrenador; } }
    public List<Jugador> ListaJugador { get { return listaJugador; } }

    // Constructor
    public Equipo(Categorias categoria, Entrenador entrenador, List<Jugador> listaJugador)
    {
        this.categoria = categoria;
        this.entrenador = entrenador;
        this.listaJugador = listaJugador;
    }

    // Agregar y remover jugador
    public void agregarJugador(Jugador jugador)
    {
        listaJugador.Add(jugador);
    }
    public void quitarJugador(Jugador jugador)
    {
        listaJugador.Remove(jugador);
    }
}