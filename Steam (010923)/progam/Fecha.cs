class Fecha
{
    // Atributos
    private int dia;
    private int mes;
    private int anio;

    // Getter y Setter
    public int Dia { get { return dia; } }
    public int Mes { get { return mes; } }
    public int Anio { get { return anio; } }

    // Constructor
    public Fecha(int dia, int mes, int anio)
    {
        this.dia = dia;
        this.mes = mes;
        this.anio = anio;
    }
}