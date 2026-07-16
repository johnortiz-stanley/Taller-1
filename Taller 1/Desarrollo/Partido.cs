public class Partido
{
    // ATRIBUTOS ORIGINALES
    private Equipo local;
    private Equipo visitante;
    private DateTime fecha;
    private string lugar;

    // NUEVOS ATRIBUTOS
    private string clima;
    private int asistencia;
    private string estadoPartido;

    // Propiedades con validaciones
    public Equipo Local
    {
        get => local;
        set
        {
            if (value == null)
                Console.WriteLine("El equipo local no puede ser nulo.");
            else
                local = value;
        }
    }

    public Equipo Visitante
    {
        get => visitante;
        set
        {
            if (value == null)
                Console.WriteLine("El equipo visitante no puede ser nulo.");
            else
                visitante = value;
        }
    }

    public DateTime Fecha
    {
        get => fecha;
        set
        {
            if (value < DateTime.Now)
                Console.WriteLine("La fecha del partido no puede ser pasada.");
            else
                fecha = value;
        }
    }

    public string Lugar
    {
        get => lugar;
        set
        {
            if (value == "")
                Console.WriteLine("El lugar no puede estar vacío.");
            else
                lugar = value;
        }
    }

    public string Clima
    {
        get => clima;
        set
        {
            if (value == "")
                Console.WriteLine("El clima no puede estar vacío.");
            else
                clima = value;
        }
    }

    public int Asistencia
    {
        get => asistencia;
        set
        {
            if (value < 0)
                Console.WriteLine("La asistencia no puede ser negativa.");
            else
                asistencia = value;
        }
    }

    public string EstadoPartido
    {
        get => estadoPartido;
        set
        {
            if (value == "")
                Console.WriteLine("El estado del partido no puede estar vacío.");
            else
                estadoPartido = value;
        }
    }

    // Constructor con parámetros y uso de this.
    public Partido(Equipo local, Equipo visitante, DateTime fecha, string lugar, string clima, int asistencia, string estadoPartido)
    {
        this.Local = local;
        this.Visitante = visitante;
        this.Fecha = fecha;
        this.Lugar = lugar;
        this.Clima = clima;
        this.Asistencia = asistencia;
        this.EstadoPartido = estadoPartido;
    }
}
