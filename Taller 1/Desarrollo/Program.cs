using Taller_1.Desarrollo;
class Program
{
    static void Main(string[] args)
    {
        // ==== JUGADORES EQUIPO 1 ====
        Jugador objJugador1 = new Jugador(
            "Piero Hincapié",
            25,
            4,
            "Defensa",
            "Emelec",   // ClubActual
            1.85,       // Altura
            78          // Peso
        );

        Jugador objJugador2 = new Jugador(
            "Enner Valencia",
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

//using Taller_1.Desarrollo;

//int opcion = 0;
//do
//{
//    Console.Clear();
//    Console.WriteLine("****************Bienvenido al Torneo de Futbol - ISTLC 2026****************");
//    Console.WriteLine("Menú de Opciones:");
//    Console.WriteLine("1.- Crear Jugadores");
//    Console.WriteLine("2.- Listar Jugadores");
//    Console.WriteLine("3.- Crear Equipos");
//    Console.WriteLine("4.- Crear Partidos");
//    Console.WriteLine("5.- Salir");
//    Console.WriteLine("");
//    Console.Write("Ingrese una opción: ");
//    opcion = Convert.ToInt32(Console.ReadLine());


//    switch (opcion)
//    {
//        case 1:
//            crearJugador();
//            break;
//        case 2:
//            listarJugadores();
//            break;
//        case 3:
//            crearEquipo();
//            break;
//        case 4:
//            crearPartido();
//            break;
//        case 5:
//            Console.WriteLine("Saliendo del programa...");
//            break;
//        default:
//            Console.WriteLine("Opción inválida. Por favor, intente nuevamente.");
//            break;
//    }

//} while (opcion != 5);

//void crearPartido()
//{
//    Console.Clear();
//}

//void crearEquipo()
//{
//    Console.Clear();
//}

//void crearJugador()
//{
//    Console.Clear();
//    Console.WriteLine("Moises Caicedo");
//    Console.WriteLine("William Pacho: ");
//    string nombre = Console.ReadLine();
//    Console.WriteLine("22: ");
//    int edad = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("24: ");
//    int numero = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("7: ");
//    string posicion = Console.ReadLine();
//    Console.WriteLine("Guayaquil: ");
//    string lugarNacimiento = Console.ReadLine();
//    Console.WriteLine("0918765341: ");
//    string cedula = Console.ReadLine();
//    Console.WriteLine("400: ");
//    decimal sueldo = Convert.ToDecimal(Console.ReadLine());

//    Jugador objJugador = new Jugador(nombre, edad, numero, posicion, lugarNacimiento, cedula, sueldo);
//    Console.WriteLine("Jugador creado exitosamente.");
//    Console.ReadLine();
//}





//Jugador objJugador1 = new Jugador("Piero Hincapié", 22, 4, "Defensa","Esmeraldas","0910655467",40000);

//Jugador objJugador2 = new Jugador("Enner Valencia",32,5, "Delantero","Guayaquil","0999999999",54000);

//Equipo objEquipo1= new Equipo("Emelec","Guayaquil","Azul");

//objEquipo1.AgregarJugador(objJugador1);
//objEquipo1.AgregarJugador(objJugador2);


//objEquipo1.ListarPlantilla();

//Jugador objJugador3 = new Jugador("Moiséc Caicedo", 23, 5, "Medio Campo", "Esmeraldas", "0910655467", 40000);


//Jugador objJugador4 = new Jugador("Neiser Reascos", 45, 24, "Lateral", "Esmeraldas", "0910655467", 40000);

//Equipo objEquipo2 = new Equipo("Barcelona","Guayaquil","Amarillo");

//objEquipo2.AgregarJugador(objJugador3);
//objEquipo2.AgregarJugador(objJugador4);



//objEquipo2.ListarPlantilla();

//Partido objPartido1= new Partido(objEquipo1, objEquipo2, DateTime.Now, "Guayaquil");
//objPartido1.MostrarResumen();

