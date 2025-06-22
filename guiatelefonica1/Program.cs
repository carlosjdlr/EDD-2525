
struct Contacto
{
    public string nombre;
    public string telefono;
}

class AgendaTelefonica
{
    const int MAX_CONTACTOS = 100;
    static Contacto[] contactos = new Contacto[MAX_CONTACTOS];
    static int totalContactos = 0;

    static void Main()
    {
        //interfaz de usuario
        int opcion;
        do
        {
            Console.WriteLine("\n--- AGENDA TELEFÓNICA ---");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Buscar contacto");
            Console.WriteLine("3. Eliminar contacto");
            Console.WriteLine("4. Mostrar todos los contactos");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarContacto();
                    break;
                case 2:
                    BuscarContacto();
                    break;
                case 3:
                    EliminarContacto();
                    break;
                case 4:
                    MostrarContactos();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 5);
    }

}
