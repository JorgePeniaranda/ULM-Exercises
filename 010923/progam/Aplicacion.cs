abstract class Aplicacion
{
    // Atributos
    private string nombre;
    private double precio;
    private bool estaEnAccesoAnticipado;
    private double valoracion;
    private List<Resenia> listResenia;

    // Getter y Setter
    public string Nombre { get { return nombre; } }
    public double Precio { get { return precio; } }
    public bool EstaEnAccesoAnticipado { get { return estaEnAccesoAnticipado; } }
    public double Valoracion { get { return valoracion; } }
    public List<Resenia> ListResenia { get { return listResenia; } }

    // Constructor
    public Aplicacion(string nombre, double precio, bool estaEnAccesoAnticipado, double valoracion, List<Resenia> listResenia)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.estaEnAccesoAnticipado = estaEnAccesoAnticipado;
        this.valoracion = valoracion;
        this.listResenia = listResenia;
    }
}