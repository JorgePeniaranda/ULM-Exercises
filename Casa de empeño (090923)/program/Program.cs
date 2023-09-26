Articulo articulo1 = new Articulo(
    "Anillo de oro",
    5000,
    true,
    Estados.REGULAR,
    Categorias.ANTIGUEDADES
);
Articulo articulo2 = new Articulo(
    "Collar de perlas",
    10000,
    true,
    Estados.BUENO,
    Categorias.ALHAJAS
);
Articulo articulo3 = new Articulo(
    "Reloj de plata",
    2000,
    true,
    Estados.MALO,
    Categorias.ARTICULOS_VALIOSOS
);

List<Articulo> articulosEnExposicion = new List<Articulo>();
articulosEnExposicion.Add(articulo1);
articulosEnExposicion.Add(articulo2);
articulosEnExposicion.Add(articulo3);

Direccion direccion = new Direccion("Av. Siempreviva", 742, "Springfield");

CasaEmpenio casaEmpenio = new CasaEmpenio(
    "El precio de la historia",
    direccion,
    articulosEnExposicion
);

casaEmpenio.AgregarArticulo(articulo1);
casaEmpenio.AgregarArticulo(articulo2);
casaEmpenio.AgregarArticulo(articulo3);

Articulo? articuloBuscado1 = casaEmpenio.BuscarArticulo("Anillo de oro");
Console.WriteLine(
    (articuloBuscado1 != null ? articuloBuscado1.Nombre : "No se encontró el artículo")
);

Articulo? articuloBuscado2 = casaEmpenio.BuscarArticulo("Mona Lisa");
Console.WriteLine(
    (articuloBuscado2 != null ? articuloBuscado2.Nombre : "No se encontró el artículo")
);
