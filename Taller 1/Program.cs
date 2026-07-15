using Taller_1.Desarrollo;

Jugador objJugador1 = new Jugador("Moises Caicedo", 19, 4, "Defensa");

Jugador objJugador2 = new Jugador("Willian Pacho", 32, 11, "Delantero");

Equipo objEquipo1 = new Equipo("Barcelona", "Guayaquil");

objEquipo1.AgregarJugador(objJugador1);
objEquipo1.AgregarJugador(objJugador2);



objEquipo1.ListarPlantilla();

Jugador objJugador3 = new Jugador("Gabriel Cortes", 28, 7, "Medio Campo");


Jugador objJugador4 = new Jugador("Damian Diaz", 20, 8, "Lateral");


Equipo objEquipo2 = new Equipo("Liga de quito", "Quito");

objEquipo2.AgregarJugador(objJugador3);
objEquipo2.AgregarJugador(objJugador4);



objEquipo2.ListarPlantilla();

Partido objPartido1 = new Partido(objEquipo1, objEquipo2, DateTime.Now, "Guayaquil");
objPartido1.MostrarResumen();

