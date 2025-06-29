
class Program
{
    static void Main()
    {
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine();

        string palabraInvertida = "";
        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            palabraInvertida += palabra[i];
        }

        if (palabra.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("La palabra es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra no es un palíndromo.");
        }
    }
}
