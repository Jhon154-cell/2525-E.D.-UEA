using System;
using System.Collections.Generic;

/// <summary>
/// Representa una torre (pila) en el problema de las Torres de Hanoi.
/// </summary>
class Torre
{
    public Stack<int> discos = new Stack<int>(); // Cada torre es una pila de discos
    public string Nombre;

    public Torre(string nombre)
    {
        Nombre = nombre;
    }

    /// <summary>
    /// Mueve el disco superior desde esta torre hacia otra torre destino.
    /// </summary>
    public void MoverDiscoA(Torre destino)
    {
        int disco = discos.Pop(); // Pop: Sacamos el disco de la torre actual
        destino.discos.Push(disco); // Push: Colocamos el disco en la torre destino
        Console.WriteLine($"Mover disco {disco} desde {Nombre} a {destino.Nombre}");
    }
}

class TorresDeHanoi
{
    /// <summary>
    /// Algoritmo recursivo que resuelve el problema de las Torres de Hanoi.
    /// </summary>
    static void Resolver(int n, Torre origen, Torre auxiliar, Torre destino)
    {
        if (n == 1)
        {
            // Caso base: mover un solo disco directamente
            origen.MoverDiscoA(destino);
        }
        else
        {
            // Paso 1: mover n-1 discos a la torre auxiliar
            Resolver(n - 1, origen, destino, auxiliar);

            // Paso 2: mover el disco más grande a la torre destino
            origen.MoverDiscoA(destino);

            // Paso 3: mover los n-1 discos de la torre auxiliar a la torre destino
            Resolver(n - 1, auxiliar, origen, destino);
        }
    }

    static void Main()
    {
        Console.Write("Ingrese la cantidad de discos: ");
        int numeroDiscos = Convert.ToInt32(Console.ReadLine()); // Entrada por teclado con conversión

        // Inicializamos las torres
        Torre A = new Torre("A");
        Torre B = new Torre("B");
        Torre C = new Torre("C");

        // Insertamos los discos en la torre A (de mayor a menor)
        for (int i = numeroDiscos; i >= 1; i--)
        {
            A.discos.Push(i); // Push: agregamos cada disco a la torre inicial
        }

        Console.WriteLine("\nResolución paso a paso de las Torres de Hanoi:\n");
        Resolver(numeroDiscos, A, B, C);
    }
}
