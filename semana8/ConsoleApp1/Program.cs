namespace ParqueDiversiones
{
    // Clase que representa a una persona
    public class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }

    // Clase que representa la atracción
    public class Atraccion
    {
        private Queue<Persona> fila;
        private List<Persona> asientosAsignados;
        private int capacidadMaxima;

        public Atraccion(int capacidad)
        {
            fila = new Queue<Persona>();
            asientosAsignados = new List<Persona>();
            capacidadMaxima = capacidad;
        }

        public void AgregarPersonaAFila(Persona persona)
        {
            fila.Enqueue(persona);
            Console.WriteLine($"{persona.Nombre} ha sido agregado a la fila.");
        }

        public void AsignarAsientos()
        {
            while (fila.Count > 0 && asientosAsignados.Count < capacidadMaxima)
            {
                Persona persona = fila.Dequeue();
                asientosAsignados.Add(persona);
                Console.WriteLine($"{persona.Nombre} ha subido a la atracción.");
            }

            if (asientosAsignados.Count == capacidadMaxima)
            {
                Console.WriteLine("Todos los asientos han sido ocupados.");
            }
        }
         public void MostrarReporte()
        {
            Console.WriteLine("\n--- Reporte de Asientos Asignados ---");
            for (int i = 0; i < asientosAsignados.Count; i++)
            {
                Console.WriteLine($"Asiento {i + 1}: {asientosAsignados[i].Nombre}");
            }

            Console.WriteLine($"\nAsientos disponibles: {capacidadMaxima - asientosAsignados.Count}");
        }
    }
     // Clase principal del sistema
    class Sistema
    {
        static void Main(string[] args)
        {
            Atraccion atraccion = new Atraccion(30);

            // Simulación: agregar personas a la fila
            for (int i = 1; i <= 35; i++)
            {
                atraccion.AgregarPersonaAFila(new Persona($"Persona {i}"));
            }

            // Asignar asientos y mostrar reporte
            atraccion.AsignarAsientos();
            atraccion.MostrarReporte();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
