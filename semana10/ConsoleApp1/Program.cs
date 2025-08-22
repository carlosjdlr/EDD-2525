
class ProgramaVacunacion
{
    static void Main()
    {
        // 1. Crear 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // 2. Crear subconjunto de 75 vacunados con Pfizer
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // 3. Crear subconjunto de 75 vacunados con AstraZeneca
        HashSet<string> astrazeneca = new HashSet<string>();
        for (int i = 50; i < 125; i++) // solapamiento con Pfizer
        {
            astrazeneca.Add("Ciudadano " + i);
        }

        Console.WriteLine("Pfizer: " + pfizer.Count);
        Console.WriteLine("AstraZeneca: " + astrazeneca.Count);
    }
}