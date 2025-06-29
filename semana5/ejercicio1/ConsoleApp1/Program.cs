
class Program
{
    static void Main()
    {
        List<Asignatura> asignaturas = new List<Asignatura>
        {
            new Asignatura("Matemáticas"),
            new Asignatura("Física"),
            new Asignatura("Química"),
            new Asignatura("Historia"),
            new Asignatura("Lengua")
        };
        // Actualización en Program.cs
            Console.WriteLine("\n¿Deseas agregar otra asignatura? (s/n)");
            string respuesta = Console.ReadLine().ToLower();

            while (respuesta == "s")
            {
                Console.Write("Ingresa el nombre de la asignatura: ");
                string nuevaAsignatura = Console.ReadLine();
                asignaturas.Add(new Asignatura(nuevaAsignatura));

                Console.WriteLine("¿Deseas agregar otra asignatura? (s/n)");
                respuesta = Console.ReadLine().ToLower();
            }

        Console.WriteLine("Asignaturas del curso:");
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine($"- {asignatura}");
        }
    }
}
