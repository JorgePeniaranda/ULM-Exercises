class Direccion
{
    // Atributos
    private string calle;
    private int altura;
    private string ciudad;

    // Getters
    public string Calle { get { return calle; } }
    public int Altura { get { return altura; } }
    public string Ciudad { get { return ciudad; } }


    // Constructor
    public Direccion(string calle, int altura, string ciudad)
    {
        this.calle = calle;
        this.altura = altura;
        this.ciudad = ciudad;
    }
}
