
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

    static void AgregarContacto()
    {
        if (totalContactos >= MAX_CONTACTOS)
        {
            Console.WriteLine("La agenda está llena.");
            return;
        }

        Console.Write("Ingrese el nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el teléfono: ");
        string telefono = Console.ReadLine();

        contactos[totalContactos].nombre = nombre;
        contactos[totalContactos].telefono = telefono;
        totalContactos++;

        Console.WriteLine("Contacto agregado correctamente.");
    }

// Método para buscar un contacto por nombre 
    static void BuscarContacto()
    {
        Console.Write("Ingrese el nombre a buscar: ");
        string nombre = Console.ReadLine();
        bool encontrado = false;

        for (int i = 0; i < totalContactos; i++)
        {
            if (contactos[i].nombre.ToLower().Contains(nombre.ToLower()))
            {
                Console.WriteLine($"Nombre: {contactos[i].nombre}, Teléfono: {contactos[i].telefono}");
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }
// Método para eliminar contactos
    static void EliminarContacto()
    {
        Console.Write("Ingrese el nombre del contacto a eliminar: ");
        string nombre = Console.ReadLine();
        int indice = -1;

        for (int i = 0; i < totalContactos; i++)
        {
            if (contactos[i].nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                indice = i;
                break;
            }
        }

        if (indice != -1)
        {
            for (int i = indice; i < totalContactos - 1; i++)
            {
                contactos[i] = contactos[i + 1];
            }
            totalContactos--;
            Console.WriteLine("Contacto eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }
// Método para mostrar todos los contactos 
 static void MostrarContactos()
    {
        if (totalContactos == 0)
        {
            Console.WriteLine("La agenda está vacía.");
            return;
        }

        Console.WriteLine("\n--- LISTA DE CONTACTOS ---");
        for (int i = 0; i < totalContactos; i++)
        {
            Console.WriteLine($"{i + 1}. Nombre: {contactos[i].nombre}, Teléfono: {contactos[i].telefono}");
        }
    }
}
