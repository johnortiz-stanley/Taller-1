using Taller_1.Desarrollo;
class Program
{
    static void Main(string[] args)
    {
        // ==== JUGADORES EQUIPO 1 ====
        Jugador objJugador1 = new Jugador(
            "Moises Caicedo",
            25,
            4,
            "Defensa",
            "Emelec",   // ClubActual
            1.85,       // Altura
            78          // Peso
        );

        Jugador objJugador2 = new Jugador(
            "William Pacho",
            32,
            7,
            "Delantero",
            "Emelec",
            1.78,
            75
        );

        // ==== EQUIPO 1 ====
        Equipo objEquipo1 = new Equipo(
            "Emelec",
            "Guayaquil",
            "Bolillo Gomez",
            1929,              // Fundacion
            "Estadio Capwell", // Estadio
            15                 // Titulos
        );
        objEquipo1.AgregarJugador(objJugador1);
        objEquipo1.AgregarJugador(objJugador2);
        objEquipo1.ListarPlantilla();

        // ==== JUGADORES EQUIPO 2 ====
        Jugador objJugador3 = new Jugador(
            "Moisés Caicedo",
            23,
            5,
            "Medio Campo",
            "Barcelona",
            1.77,
            72
        );

        Jugador objJugador4 = new Jugador(
            "Neiser Reascos",
            28,
            24,
            "Lateral",
            "Barcelona",
            1.74,
            70
        );

        // ==== EQUIPO 2 ====
        Equipo objEquipo2 = new Equipo(
            "Barcelona",
            "Guayaquil",
            "Cairo Shumager",
            1925,                 // Fundacion
            "Estadio Monumental", // Estadio
            16                    // Titulos
        );
        objEquipo2.AgregarJugador(objJugador3);
        objEquipo2.AgregarJugador(objJugador4);
        objEquipo2.ListarPlantilla();

        // ==== PARTIDO ====
        Partido objPartido1 = new Partido(
            objEquipo1,
            objEquipo2,
            DateTime.Now.AddDays(1), // Fecha futura para validación
            "Estadio Modelo",        // Lugar
            "Soleado",               // Clima
            30000,                   // Asistencia
            "Programado"             // EstadoPartido
        );

        // Mostrar resumen del partido
        Console.WriteLine("Partido creado entre " + objEquipo1.Nombre + " y " + objEquipo2.Nombre);
    }


           