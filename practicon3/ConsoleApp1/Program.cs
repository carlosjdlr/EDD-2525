// Programa: Registro de libros en una biblioteca C#
// Autor: Macias Celi Carlos Joseph
// Asignatura: Estructura de Datos - Unidad III (Conjuntos y Mapas)

using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaApp
{
    public class Book
    {
        public string Codigo { get; set; } // Código de registro
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }

        public Book(string codigo, string titulo, string autor, int anio)
        {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
        }

        public override string ToString()
        {
            return $"Código: {Codigo} | Título: {Titulo} | Autor: {Autor} | Año: {Anio}";
        }
    }

    public class Library
    {
        private readonly Dictionary<string, Book> _libros = new Dictionary<string, Book>();

        public bool RegistrarLibro(Book libro)
        {
            if (string.IsNullOrWhiteSpace(libro.Codigo))
                throw new ArgumentException("El código de registro no puede estar vacío.");

            if (_libros.ContainsKey(libro.Codigo))
                return false; // Ya existe

            _libros[libro.Codigo] = libro;
            return true;
        }

        public bool EliminarLibro(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo)) return false;
            return _libros.Remove(codigo);
        }

        public Book BuscarLibro(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo)) return null;
            _libros.TryGetValue(codigo, out var libro);
            return libro;
        }

        public List<Book> ListarLibrosOrdenadosPorTitulo()
        {
            return _libros.Values.OrderBy(b => b.Titulo).ToList();
        }

        public int TotalLibros => _libros.Count;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var biblioteca = new Library();

            // Datos de ejemplo
            biblioteca.RegistrarLibro(new Book("001", "Cien años de soledad", "Gabriel García Márquez", 1967));
            biblioteca.RegistrarLibro(new Book("002", "El amor en los tiempos del cólera", "Gabriel García Márquez", 1985));

            while (true)
            {
                MostrarMenu();
                Console.Write("Seleccione una opción: ");
                var opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarFlujo(biblioteca);
                        break;
                    case "2":
                        BuscarFlujo(biblioteca);
                        break;
                    case "3":
                        EliminarFlujo(biblioteca);
                        break;
                    case "4":
                        ListarFlujo(biblioteca);
                        break;
                    case "0":
                        Console.WriteLine("Saliendo... ¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine("\nPulse una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("=== Biblioteca - Gestión de Libros (C#) ===");
            Console.WriteLine("1) Registrar libro");
            Console.WriteLine("2) Buscar libro por código");
            Console.WriteLine("3) Eliminar libro por código");
            Console.WriteLine("4) Listar todos los libros");
            Console.WriteLine("0) Salir");
            Console.WriteLine("===========================================");
        }

        static void RegistrarFlujo(Library biblioteca)
        {
            Console.Write("Código de registro: ");
            var codigo = Console.ReadLine()?.Trim();
            Console.Write("Título: ");
            var titulo = Console.ReadLine()?.Trim();
            Console.Write("Autor: ");
            var autor = Console.ReadLine()?.Trim();
            Console.Write("Año: ");
            var anioStr = Console.ReadLine()?.Trim();

            if (!int.TryParse(anioStr, out int anio) || anio <= 0)
            {
                Console.WriteLine("Año inválido.");
                return;
            }

            var libro = new Book(codigo, titulo, autor, anio);
            var ok = biblioteca.RegistrarLibro(libro);
            Console.WriteLine(ok ? "Libro registrado correctamente." : "Ya existe un libro con ese código.");
        }

        static void BuscarFlujo(Library biblioteca)
        {
            Console.Write("Ingrese código a buscar: ");
            var codigo = Console.ReadLine()?.Trim();
            var libro = biblioteca.BuscarLibro(codigo);
            Console.WriteLine(libro != null ? libro.ToString() : "Libro no encontrado.");
        }

        static void EliminarFlujo(Library biblioteca)
        {
            Console.Write("Ingrese código a eliminar: ");
            var codigo = Console.ReadLine()?.Trim();
            var ok = biblioteca.EliminarLibro(codigo);
            Console.WriteLine(ok ? "Libro eliminado correctamente." : "No existe un libro con ese código.");
        }

        static void ListarFlujo(Library biblioteca)
        {
            var lista = biblioteca.ListarLibrosOrdenadosPorTitulo();
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay libros registrados.");
                return;
            }

            Console.WriteLine("\nLibros registrados (ordenados por título):");
            foreach (var b in lista)
            {
                Console.WriteLine(b.ToString());
            }
            Console.WriteLine($"\nTotal: {lista.Count} libro(s).");
        }
    }
}
