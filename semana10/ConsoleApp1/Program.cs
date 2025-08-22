
class ProgramaVacunacion
{
    static void Main()
    {
        // 1. Crear 500 ciudadanos ficticios
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        Console.WriteLine("Total de ciudadanos creados: " + ciudadanos.Count);
    }
}
