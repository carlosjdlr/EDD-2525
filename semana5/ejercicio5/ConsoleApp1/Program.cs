using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        int contadorA = 0, contadorE = 0, contadorI = 0, contadorO = 0, contadorU = 0;

        foreach (char letra in palabra)
        {
            switch (letra)
            {
                case 'a':
                    contadorA++;
                    break;
                case 'e':
                    contadorE++;
                    break;
                case 'i':
                    contadorI++;
                    break;
                case 'o':
                    contadorO++;
                    break;
                case 'u':
                    contadorU++;
                    break;
            }
        }

        Console.WriteLine("\nCantidad de vocales:");
        Console.WriteLine($"A: {contadorA}");
        Console.WriteLine($"E: {contadorE}");
        Console.WriteLine($"I: {contadorI}");
        Console.WriteLine($"O: {contadorO}");
        Console.WriteLine($"U: {contadorU}");
    }
}
