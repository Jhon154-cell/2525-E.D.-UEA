using System;
using System.Collections.Generic;

class Asignatura
{
    public string Nombre { get; set; }
    public double Nota { get; set; }
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

        asignaturas.RemoveAll(a => a.Nota >= 7);

        Console.WriteLine("\nDebes repetir las siguientes asignaturas:");
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine(asignatura.Nombre);
        }
    }
}
