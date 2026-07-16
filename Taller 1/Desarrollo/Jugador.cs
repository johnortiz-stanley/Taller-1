public class Jugador
{
    // ATRIBUTOS ORIGINALES
    private string nombre;
    private int edad;
    private int numero;
    private string posicion;

    // NUEVOS ATRIBUTOS
    private string clubActual;
    private double altura;
    private double peso;

    // Propiedades con validaciones
    public string Nombre
    {
        get => nombre;
        set
        {
            if (value == "")
                Console.WriteLine("El nombre no puede estar vacío.");
            else
                nombre = value;
        }
    }

    public int Edad
    {
        get => edad;
        set
        {
            if (value < 15 || value > 50)
                Console.WriteLine("La edad no es válida para un jugador.");
            else
                edad = value;
        }
    }

    public int Numero
    {
        get => numero;
        set
        {
            if (value < 1 || value > 99)
                Console.WriteLine("El número de camiseta debe estar entre 1 y 99.");
            else
                numero = value;
        }
    }

    public string Posicion
    {
        get => posicion;
        set
        {
            if (value == "")
                Console.WriteLine("La posición no puede estar vacía.");
            else
                posicion = value;
        }
    }

    public string ClubActual
    {
        get => clubActual;
        set
        {
            if (value == "")
                Console.WriteLine("El club actual no puede estar vacío.");
            else
                clubActual = value;
        }
    }

    public double Altura
    {
        get => altura;
        set
        {
            if (value < 1.40 || value > 2.20)
                Console.WriteLine("La altura no es válida.");
            else
                altura = value;
        }
    }

    public double Peso
    {
        get => peso;
        set
        {
            if (value < 40 || value > 120)
                Console.WriteLine("El peso no es válido.");
            else
                peso = value;
        }
    }

    // Constructor con parámetros y uso de this.
    public Jugador(string nombre, int edad, int numero, string posicion, string clubActual, double altura, double peso)
    {
        this.Nombre = nombre;
        this.Edad = edad;
        this.Numero = numero;
        this.Posicion = posicion;
        this.ClubActual = clubActual;
        this.Altura = altura;
        this.Peso = peso;
    }
}
}
