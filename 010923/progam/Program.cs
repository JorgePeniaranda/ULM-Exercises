// Declaro listas
List<Aplicacion> listAplicacion = new List<Aplicacion>();
List<Usuario> listUsuario = new List<Usuario>();
List<Resenia> listResenia = new List<Resenia>();

// Agrego elementos a listAplicacion
listAplicacion.Add(new Juego("GTA Vice city", 3000, false, 5, listResenia, 18, CategoriaJuego.ACCION));
listAplicacion.Add(new Juego("GTA SA", 3000, false, 4.8, listResenia, 18, CategoriaJuego.ACCION));
listAplicacion.Add(new Software("Classroom", 3000, false, 3.4, listResenia, CategoriaSoftware.ADMINISTRATIVO));
listAplicacion.Add(new Juego("GTA V", 3000, false, 3.9, listResenia, 18, CategoriaJuego.ACCION));
listAplicacion.Add(new Juego("GTA VI", 3000, true, 3, listResenia, 18, CategoriaJuego.ACCION));

// Agrego elementos a listUsuario
listUsuario.Add(
    new Usuario(
        "Usuario1",
        19,
        12993,
        listAplicacion
    )
);
listUsuario.Add(
    new Usuario(
        "Usuario2",
        14,
        2314,
        listAplicacion
    )
);
listUsuario.Add(
    new Usuario(
        "Usuario3",
        11,
        7665,
        listAplicacion
    )
);
listUsuario.Add(
    new Usuario(
        "Usuario4",
        7,
        12321,
        listAplicacion
    )
);
listUsuario.Add(
    new Usuario(
        "Francisco José Trujillo Sztai",
        78,
        2109482147,
        listAplicacion
    )
);

// Agrego elementos a listResenia
listResenia.Add(
    new Resenia(
        listUsuario[0],
        "Excelente",
        "Considero este juego es una obra de arte",
        new Fecha(1, 1, 2001),
        true
    )
);
listResenia.Add(
    new Resenia(
        listUsuario[1],
        "Maravilloso",
        "Considero este juego es una obra de arte",
        new Fecha(2, 2, 2002),
        true
    )
);
listResenia.Add(
    new Resenia(
        listUsuario[2],
        "Suficiente",
        "Considero este juego un poco por encima del promedio",
        new Fecha(3, 3, 2003),
        true
    )
);
listResenia.Add(
    new Resenia(
        listUsuario[3],
        "Decente",
        "Considero este juego es decente",
        new Fecha(4, 4, 2004),
        true
    )
);
listResenia.Add(
    new Resenia(
        listUsuario[4],
        "Catastrofico",
        "Considero este juego malisimo",
        new Fecha(1, 9, 2023),
        false
    )
);

// new Plataforma
Plataforma plataforma = new Plataforma("Steam", listAplicacion, listUsuario);

// Mostrar

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(plataforma.Nombre);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("   Lista Usuarios:");
Console.ResetColor();
foreach (var usuario in plataforma.ListUsuario)
{
    Console.WriteLine($"     > {usuario.Nombre}:");
    Console.WriteLine($"        » {usuario.Edad} años");
    Console.WriteLine($"        » ${usuario.SaldoCuenta.ToString("0,0.00")}");
    Console.WriteLine("        » Aplicaciones en bibloteca:\n");
    foreach (var apliacion in usuario.ListAplicacion)
    {
        Console.WriteLine($"          - {apliacion.Nombre}");
    }
    Console.WriteLine("");
}


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("   Lista Aplicaciones:");
Console.ResetColor();
foreach (var aplicacion in plataforma.ListAplicacion)
{
    Console.WriteLine($"     > {aplicacion.Nombre}:");
    Console.WriteLine($"          » ${aplicacion.Precio.ToString("0,0.00")}");
    Console.WriteLine($"          » {(aplicacion.EstaEnAccesoAnticipado ? "Está" : "No está")} en acceso anticipado");
    Console.WriteLine($"          » {aplicacion.Valoracion}/5");
    Console.WriteLine("          » Reseñas");
    foreach (var resenia in aplicacion.ListResenia)
    {
        Console.WriteLine($"            - Por {resenia.Autor.Nombre} ({(resenia.EsPositiva ? "Positiva" : "Negativa")}):");
        Console.WriteLine($"                Titulo: {resenia.Titulo}");
        Console.WriteLine($"                Texto: {resenia.Texto}");
        Console.WriteLine($"                Fecha: {resenia.Fecha.Dia}/{resenia.Fecha.Mes}/{resenia.Fecha.Anio}\n");
    }
}