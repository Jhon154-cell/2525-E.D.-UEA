using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        List<char> abecedario = new List<char>();
        for (char letra = 'A'; letra <= 'Z'; letra++)
        {
            abecedario.Add(letra);
        }

        for (int i = abecedario.Count - 1; i >= 0; i--)
        {
            if ((i + 1) % 3 == 0)
                abecedario.RemoveAt(i);
        }

        Console.WriteLine("Abecedario sin letras en posiciones múltiplos de 3:");
        foreach (var letra in abecedario)
        {
            Console.Write(letra + " ");
        }
    }
}
