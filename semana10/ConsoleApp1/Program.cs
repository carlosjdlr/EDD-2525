
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
        Console.WriteLine("No vacunados: " + noVacunados.Count);
        Console.WriteLine("Ambas dosis: " + ambasDosis.Count);
        Console.WriteLine("Solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Solo AstraZeneca: " + soloAstraZeneca.Count);
    }
}