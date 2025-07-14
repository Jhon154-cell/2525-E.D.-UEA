using System;
using System.Collections.Generic;

class BalanceoParentesis
{
    /// <summary>
    /// Verifica si una expresión tiene paréntesis, llaves y corchetes correctamente balanceados.
    /// </summary>
    static bool EstaBalanceado(string expresion)
    {
        Stack<char> pila = new Stack<char>(); // Creamos la pila para almacenar símbolos de apertura

        foreach (char c in expresion)
        {
            // Push: Agregamos símbolos de apertura a la pila
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c);
            }
            // Si encontramos un símbolo de cierre, verificamos que coincida con el último abierto (top de la pila)
            else if (c == ')' || c == ']' || c == '}')
            {
                if (pila.Count == 0) return false; // No hay símbolos de apertura disponibles

                char tope = pila.Pop(); // Pop: Extraemos el último símbolo abierto

                // Verificamos si el símbolo abierto no coincide con el cerrado
                if ((c == ')' && tope != '(') ||
                    (c == ']' && tope != '[') ||
                    (c == '}' && tope != '{'))
                {
                    return false;
                }
            }
        }

        return pila.Count == 0; // Si la pila está vacía, la expresión está balanceada
    }

    static void Main()
    {
        Console.Write("Ingresa una expresión matemática: ");
        string expresion = Console.ReadLine(); // Entrada por teclado

        // Mostramos el resultado según si está balanceada o no
        if (EstaBalanceado(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula no balanceada.");
    }
}
