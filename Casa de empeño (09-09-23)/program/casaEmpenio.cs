class CasaEmpenio
{
    private string nombre;
    private Direccion direccion;
    private List<Articulo> articulosEnExposicion;

    public string Nombre
    {
        get { return nombre; }
    }
    public Direccion Direccion
    {
        get { return direccion; }
    }
    public List<Articulo> Articulos
    {
        get { return articulosEnExposicion; }
    }

    public CasaEmpenio(string nombre, Direccion direccion, List<Articulo> articulosEnExposicion)
    {
        this.nombre = nombre;
        this.direccion = direccion;
        this.articulosEnExposicion = articulosEnExposicion;
    }

    public void AgregarArticulo(Articulo articulo)
    {
        articulosEnExposicion.Add(articulo);
    }

    public Articulo? BuscarArticulo(string nombre)
    {
        foreach (Articulo articulo in this.articulosEnExposicion)
        {
            if (articulo.Nombre == nombre)
            {
                return articulo;
            }
        }
        return null;
    }
}
