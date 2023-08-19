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
        "Blockbuster",
        new Direccion(
            "Jujuy",
            255,
            "CABA"
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
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(Blockbuster.Nombre);
Console.ForegroundColor = ConsoleColor.White;

foreach (var local in Blockbuster.ListaLocal)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("   - Local: " + local);
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine($"      - Ubicación: {local.Direccion.Calle} {local.Direccion.Altura} ({local.Direccion.Ciudad})");

    Console.WriteLine("      - Lista de Películas: ");
    foreach (var pelicula in local.ListaPelicula)
    {
        Console.WriteLine($"           > {pelicula.Titulo} - {pelicula.Duracion}min - {pelicula.Genero}");
    }

    Console.WriteLine("      - Lista de Clientes: ");
    foreach (var cliente in local.ListaCliente)
    {
        Console.WriteLine($"           > ID:{cliente.ID} - {cliente.Nombre} {cliente.Apellido} - {cliente.Direccion.Calle} {cliente.Direccion.Altura} ({cliente.Direccion.Ciudad}) ");
    }

    Console.WriteLine("      - Lista de Prestamos: ");
    foreach (var prestamo in local.ListaPrestamo)
    {
        Console.WriteLine($"           > {prestamo.Pelicula.Titulo}");
        Console.WriteLine($"               » ID Persona: {prestamo.Cliente.ID}");
        Console.WriteLine($"               » Prestatario: {prestamo.Cliente.Nombre} {prestamo.Cliente.Apellido}");
        Console.WriteLine($"               » Fecha: {prestamo.FechaPrestamo.Dia}/{prestamo.FechaPrestamo.Mes}/{prestamo.FechaPrestamo.Anio}");
        Console.WriteLine($"               » Cantidad de Días: {prestamo.CantidadDias}");
    }
}