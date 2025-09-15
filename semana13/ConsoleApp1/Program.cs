
class Program
{
    static void Main()
    {
        // Catálogo de revistas predefinido
        List<string> catalogo = new List<string>
        {
            "Vistazo",
            "Mundo Diners",
            "El Universo",
            "Revista Líderes",
            "Gestión",
            "Revista Hogar",
            "El Comercio",
            "Revista Mundo Juvenil",
            "Deportes Total",
            "Revista Rocinante",
            "Viajes y Aventura",
            "Salud Integral"
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Catálogo de Revistas - Menú");
            Console.WriteLine("1. Mostrar catálogo");
            Console.WriteLine("2. Buscar un título");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                MostrarCatalogo(catalogo);
                Pausa();
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese el título a buscar: ");
                string titulo = Console.ReadLine() ?? string.Empty;
                // Uso de búsqueda recursiva (búsqueda lineal recursiva)
                bool encontrado = BuscarRecursivo(catalogo, titulo.Trim(), 0);
                Console.WriteLine(encontrado ? "Encontrado" : "No encontrado");
                Pausa();
            }
            else if (opcion == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                Pausa();
            }
        }
    }

    // Muestra el catálogo por pantalla
    static void MostrarCatalogo(List<string> catalogo)
    {
        Console.WriteLine("\n--- Catálogo de Revistas ---");
        for (int i = 0; i < catalogo.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {catalogo[i]}");
        }
    }

    // Búsqueda recursiva: recorre el catálogo desde 'index' hasta el final
    static bool BuscarRecursivo(List<string> catalogo, string objetivo, int index)
    {
        if (index >= catalogo.Count)
            return false;

        if (string.Equals(catalogo[index], objetivo, StringComparison.OrdinalIgnoreCase))
            return true;

        return BuscarRecursivo(catalogo, objetivo, index + 1);
    }

    // Pausa simple para que el usuario lea los resultados
    static void Pausa()
    {
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }
}