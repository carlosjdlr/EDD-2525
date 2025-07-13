
class VerificacionBalance
{
    /// Verifica si una expresión tiene paréntesis, llaves y corchetes balanceados
    public static bool estabalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();
        Dictionary<char, char> pares = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in expresion)
        {
            if (pares.ContainsValue(c))
            {
                pila.Push(c);
            }
            else if (pares.ContainsKey(c))
            {
                if (pila.Count == 0 || pila.Pop() != pares[c])
                    return false;
            }
        }

        return pila.Count == 0;
    }

    static void Main()
    {
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
        Console.WriteLine(estabalanceada(expresion)
            ? "Fórmula balanceada."
            : "Fórmula no balanceada.");
    }
}
