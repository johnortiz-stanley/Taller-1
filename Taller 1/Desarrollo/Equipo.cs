using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_1.Desarrollo
{
    public class Equipo
    {
        private string nombre;
        private string ciudad;
        private List<Jugador> jugadores;
        private string entrenador;

        // Nuevos atributos
        private int fundacion;
        private string estadio;
        private int titulos;

        // Propiedades con validaciones
        public int Fundacion
        {
            get => fundacion;
            set
            {
                if (value < 1800 || value > DateTime.Now.Year)
                    Console.WriteLine("El año de fundación no es válido.");
                else
                    fundacion = value;
            }
        }

        public string Estadio
        {
            get => estadio;
            set
            {
                if (value == "")
                    Console.WriteLine("El nombre del estadio no puede estar vacío.");
                else
                    estadio = value;
            }
        }

        public int Titulos
        {
            get => titulos;
            set
            {
                if (value < 0)
                    Console.WriteLine("El número de títulos no puede ser negativo.");
                else
                    titulos = value;
            }
        }

        // Constructor con parámetros y uso de this.
        public Equipo(string nombre, string ciudad, string entrenador, int fundacion, string estadio, int titulos)
        {
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.entrenador = entrenador;
            this.Fundacion = fundacion;
            this.Estadio = estadio;
            this.Titulos = titulos;
            this.jugadores = new List<Jugador>();
        }
    }




