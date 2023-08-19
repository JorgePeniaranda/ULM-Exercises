// Lista peliculas
List<Pelicula> listaPelicula = new List<Pelicula>();
listaPelicula.Add(
    new Pelicula(
        "Guardianes de la Galaxia: Vol. 1",
        122,
        Genero.ACCION
    )
);
listaPelicula.Add(
    new Pelicula(
        "Guardianes de la Galaxia: Vol. 2",
        137,
        Genero.ACCION
    )
);
listaPelicula.Add(
    new Pelicula(
        "Guardianes de la Galaxia: Vol. 3",
        149,
        Genero.ACCION
    )
);

// Lista clientes
List<Cliente> listaCliente = new List<Cliente>();
listaCliente.Add(
    new Cliente(
        "Eitan",
        "Mohorade",
        new Direccion(
            "COSO",
            123,
            "CABA"
        ),
        1
    )
);

// Lista prestamos
List<Prestamo> listaPrestamo = new List<Prestamo>();
listaPrestamo.Add(
    new Prestamo(
        14,
        listaPelicula[2],
        new Fecha(18, 8, 2023),
        listaCliente[0]
    )
);

// Lista locales
List<Local> listaLocales = new List<Local>();
listaLocales.Add(
    new Local(
        "Local 1", 
        new Direccion(
            "Jujuy",
            255,
            "Si"
        ),
        listaPelicula,
        listaPrestamo,
        listaCliente
    )
);

// Blockbuster
AlquilerPeliculas Blockbuster = new AlquilerPeliculas(
    "Blockbuster",
    listaLocales
);

// Mostrar
Console.WriteLine(Blockbuster);