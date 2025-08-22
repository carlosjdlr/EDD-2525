
class ProgramaVacunacion
{
    static void Main()
    {
        // Ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
            ciudadanos.Add("Ciudadano " + i);

        // Pfizer
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
            pfizer.Add("Ciudadano " + i);

        // AstraZeneca
        HashSet<string> astrazeneca = new HashSet<string>();
        for (int i = 50; i < 125; i++)
            astrazeneca.Add("Ciudadano " + i);

        // Operaciones
        HashSet<string> vacunados = new HashSet<string>(pfizer.Union(astrazeneca));
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos.Except(vacunados));
        HashSet<string> ambasDosis = new HashSet<string>(pfizer.Intersect(astrazeneca));
        HashSet<string> soloPfizer = new HashSet<string>(pfizer.Except(astrazeneca));
        HashSet<string> soloAstraZeneca = new HashSet<string>(astrazeneca.Except(pfizer));

        // Resultados
        Console.WriteLine("📌 Ciudadanos NO vacunados: " + noVacunados.Count);
        Console.WriteLine("📌 Ciudadanos con ambas dosis: " + ambasDosis.Count);
        Console.WriteLine("📌 Ciudadanos solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("📌 Ciudadanos solo AstraZeneca: " + soloAstraZeneca.Count);

        Console.WriteLine("\nEjemplo de NO vacunados:");
        foreach (var c in noVacunados.Take(10)) Console.WriteLine(c);

        Console.WriteLine("\nEjemplo de vacunados con ambas dosis:");
        foreach (var c in ambasDosis.Take(10)) Console.WriteLine(c);
    }
}