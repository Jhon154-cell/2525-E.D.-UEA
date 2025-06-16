using System;

namespace RegistroEstudiante
{
    // Definición de la clase Estudiante
    class Estudiante
    {
        // Atributos del estudiante
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; } // Array para almacenar 3 teléfonos

        // Constructor para inicializar los datos del estudiante
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = telefonos;
        }

        // Método para mostrar la información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    // Clase principal que ejecuta el programa
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un array con los teléfonos
            string[] telefonos = new string[3] { "0991234567", "0987654321", "0971122334" };

            // Crear un objeto Estudiante
            Estudiante estudiante = new Estudiante(1, "Carlos", "Pérez", "Av. Siempre Viva 123", telefonos);

            // Mostrar la información del estudiante
            estudiante.MostrarInformacion();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
