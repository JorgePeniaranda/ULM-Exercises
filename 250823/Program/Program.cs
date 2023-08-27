// Lista jugador
List<Jugador> listaJugador = new List<Jugador>();
listaJugador.Add(new Jugador("Gaizka", "Garrido", 1));
listaJugador.Add(new Jugador("Ander", "Andreu", 7));
listaJugador.Add(new Jugador("Valentin", "Robles", 10));
listaJugador.Add(new Jugador("Souad", "Fariña", 9));
listaJugador.Add(new Jugador("Braulio", "Moro", 77));
listaJugador.Add(new Jugador("Fabiola", "Aparicio", 2));
listaJugador.Add(new Jugador("Bryan", "Velazquez", 3));
listaJugador.Add(new Jugador("Mario", "Lorente", 5));
listaJugador.Add(new Jugador("Rosendo", "Portela", 4));
listaJugador.Add(new Jugador("Bernardino", "Barrios", 8));

// Lista entranador
List<Entrenador> listaEntrenador = new List<Entrenador>();
listaEntrenador.Add(new Entrenador("Joaquim", "Andreu", Tacticas.EQUILIBRADA));
listaEntrenador.Add(new Entrenador("Mustapha", "Novo", Tacticas.OFENSIVA));
listaEntrenador.Add(new Entrenador("Ainhoa", "Saenz", Tacticas.DEFENSIVA));


// Lista Equipo
List<Equipo> listaEquipo = new List<Equipo>();
listaEquipo.Add(
    new Equipo(
        Categorias.PRIMERA,
        listaEntrenador[0],
        listaJugador
    )
);
listaEquipo.Add(
    new Equipo(
        Categorias.SEGUNDA,
        listaEntrenador[1],
        listaJugador
    )
);
listaEquipo.Add(
    new Equipo(
        Categorias.TERCERA,
        listaEntrenador[2],
        listaJugador
    )
);


// Lista Empleados Administrativos
List<EmpleadoAdministrativo> listaEmpleado = new List<EmpleadoAdministrativo>();
listaEmpleado.Add(
    new EmpleadoAdministrativo(
        "Eneko",
        "Bartolome",
        "Asistente Administrativo"
    )
);
listaEmpleado.Add(
    new EmpleadoAdministrativo(
        "Borja",
        "Matos",
        "Coordinador de Recursos Humanos"
    )
);
listaEmpleado.Add(
    new EmpleadoAdministrativo(
        "Marcelo",
        "Pereira",
        "Secretario Ejecutivo"
    )
);


// Club Futbol
ClubFutbol ClubFutbol = new ClubFutbol(
    "Chacarita",
    "1906",
    new Direccion("Teodoro García", 3550, "CABA"),
    listaEquipo,
    listaEmpleado
);

// Presentación
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(ClubFutbol.Nombre);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("    Dirección:");
Console.ResetColor();
Console.WriteLine($"        » Calle: {ClubFutbol.Direccion.Calle}");
Console.WriteLine($"        » Altura: {ClubFutbol.Direccion.Altura}");
Console.WriteLine($"        » Ciudad: {ClubFutbol.Direccion.Ciudad}");


Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("    Empleados Administrativos:");
Console.ResetColor();
foreach (var empleado in ClubFutbol.ListaEmpleado)
{
    Console.WriteLine($"        » {empleado.Presentar()}");
}

foreach (var equipo in ClubFutbol.ListaEquipo)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"    Equipo {ClubFutbol.ListaEquipo.IndexOf(equipo) + 1}:");
    Console.ResetColor();

    Console.WriteLine($"        > Categoría: {equipo.Categoria}");

    Console.WriteLine($"        > Entrenador: ");
    Console.WriteLine($"            » {equipo.Entrenador.Presentar()}");

    Console.WriteLine("        > Jugadores: ");
    foreach (var jugador in equipo.ListaJugador)
    {
        Console.WriteLine($"            » {jugador.Presentar()}");
    }
}


/* 

Un club de futbol necesita un sistema para la gestión de sus actividades. Sabemos que el club tienen un nombre, una dirección(compuesta por: calle, altura y ciudad), un año de fundación y un equipo para cada categoría. Las categorías existentes son: Primera, Segunda y Tercera, y cada equipo(además de tener la categoría) tienen una lista de jugadores. Cada jugador tiene: un nombre, un apellido y un dorsal. El equipo también tiene entrenador, del que sabemos: nombre, apellido y táctica(Defensiva, Ofensiva o Equilibrada) y el club para sus operaciones tiene empleados administrativos, de los que sabemos: el nombre, el apellido y su función. ¿Cuántos equipos tiene el club?

Diseñar el diagrama UML con todas las clases y relaciones necesarias, implementarlo en código(C#) y en una clase aparte de las de nuestro modelo, instancia 10 jugadores, con todos sus datos completos, tres entrenadores, tres equipos, tres empleados administrativos y un club.

Los jugadores, los entrenadores y los empleados se saben presentar. En los tres casos dicen su nombre y apellido, pero el jugador también menciona su dorsal, el entrenador su táctica, y el empleado administrativo su función.

Desarrollar los métodos del equipo para agregar o quitar jugadores de su propia lista del equipo. El método será "agregarJugador()" y "quitarJugador()" y recibirán un jugador.

Desarrollar los métodos del club para agregar o quitar equipos. Los métodos serán "agregarEquipo()" y "quitarEquipo()" y recibirán un equipo

Desarrollar los métodos del club para agregar o quitar empleado. Los métodos serán "agregarEmpleado()" y "quitarEmpleado()" y recibirán un equipo.

Modelar todos los getter, setter y constructores necesarios

*/