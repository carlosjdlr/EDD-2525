
class Program
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        {"tiempo","time"},
        {"persona","person"},
        {"año","year"},
        {"camino","way"},
        {"día","day"},
        {"cosa","thing"},
        {"hombre","man"},
        {"mundo","world"},
        {"vida","life"},
        {"mano","hand"},
        {"ojo","eye"}
    };

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n===== MENÚ =====");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("3. Ver palabras del diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            // Lectura segura del número
            var entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
                opcion = -1; // fuerza “Opción inválida”

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 3:
                    VerDiccionario();
                    break;
                case 0:
                    Console.WriteLine("¡Adiós!");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("Ingrese la frase: ");
        string frase = Console.ReadLine() ?? "";
        string[] tokens = frase.Split(' '); // simple: por espacios

        for (int i = 0; i < tokens.Length; i++)
        {
            // Quitamos puntuación de extremos para buscar la palabra “limpia”
            string original = tokens[i];
            string palabraLimpia = original.Trim(',', '.', ';', '!', '?', ':', '¿', '¡');

            if (palabraLimpia.Length == 0) continue;

            // Buscamos en minúsculas y con el diccionario case-insensitive
            string clave = palabraLimpia.ToLower();
            if (diccionario.TryGetValue(clave, out var traduccion))
            {
                // Si la palabra original (sin la puntuación izquierda) empieza con mayúscula, capitalizamos la traducción
                string sinIzquierda = original.TrimStart(',', '.', ';', '!', '?', ':', '¿', '¡');
                bool iniciaMayus = char.IsLetter(sinIzquierda[0]) && char.IsUpper(sinIzquierda[0]);

                string reemplazo = iniciaMayus ? CapitalizarPrimera(traduccion) : traduccion;

                // Reemplazamos SOLO la parte limpia (con y sin mayúscula inicial)
                // 1) intenta con minúsculas
                string nuevo = ReemplazarCentro(original, palabraLimpia, reemplazo);
                // 2) si no cambió, intenta con la variante capitalizada (ej.: "Día")
                if (nuevo == original)
                    nuevo = ReemplazarCentro(original, CapitalizarPrimera(palabraLimpia), reemplazo);

                tokens[i] = nuevo;
            }
        }

        Console.WriteLine("Traducción: " + string.Join(" ", tokens));
    }

    // Reemplaza una subcadena exacta (si aparece) manteniendo los extremos (puntuación, etc.)
    static string ReemplazarCentro(string original, string centro, string reemplazo)
    {
        int idx = original.IndexOf(centro, StringComparison.Ordinal);
        if (idx < 0) return original;
        return original.Substring(0, idx) + reemplazo + original.Substring(idx + centro.Length);
    }

    static void AgregarPalabra()
    {
        Console.Write("Palabra en español: ");
        string esp = (Console.ReadLine() ?? "").Trim();
        Console.Write("Palabra en inglés: ");
        string eng = (Console.ReadLine() ?? "").Trim();

        if (string.IsNullOrWhiteSpace(esp) || string.IsNullOrWhiteSpace(eng))
        {
            Console.WriteLine("No se agregó: entradas vacías.");
            return;
        }

        if (!diccionario.ContainsKey(esp))
        {
            diccionario.Add(esp, eng);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }

    static void VerDiccionario()
    {
        Console.WriteLine("\n=== Palabras en el diccionario (ES -> EN) ===");
        foreach (var par in diccionario)
            Console.WriteLine($"{par.Key} -> {par.Value}");
    }

    static string CapitalizarPrimera(string s)
    {
        if (string.IsNullOrEmpty(s)) return s;
        if (s.Length == 1) return s.ToUpper();
        return char.ToUpper(s[0]) + s.Substring(1).ToLower();
    }
}
