using System;
using System.Collections.Generic;

class Asignatura
{
    public string Nombre { get; set; }
    public double Nota { get; set; }

    public void MostrarNota()
    {
        Console.WriteLine($"En {Nombre} has sacado {Nota}");
    }
}

class Programa
{
    static void Main()
    {
        List<Asignatura> asignaturas = new List<Asignatura>
        {
            new Asignatura { Nombre = "Matemáticas" },
            new Asignatura { Nombre = "Física" },
            new Asignatura { Nombre = "Química" },
            new Asignatura { Nombre = "Historia" },
            new Asignatura { Nombre = "Lengua" }
        };

        foreach (var asignatura in asignaturas)
        {
            Console.Write($"Ingrese la nota en {asignatura.Nombre}: ");
            asignatura.Nota = Convert.ToDouble(Console.ReadLine());
        }

        foreach (var asignatura in asignaturas)
        {
            asignatura.MostrarNota();
        }
    }
}
