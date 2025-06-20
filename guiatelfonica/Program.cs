
using System;
using System.Collections.Generic;

namespace PhoneBookApp
{
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"Nombre: {Name}, Teléfono: {PhoneNumber}";
        }
    }

    class PhoneBook
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(string name, string phoneNumber)
        {
            contacts.Add(new Contact(name, phoneNumber));
        }

        public void ShowContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("La agenda está vacía.");
                return;
            }

            Console.WriteLine("Contactos en la agenda:");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        public void SearchContact(string name)
        {
            var found = contacts.FindAll(c => c.Name.ToLower().Contains(name.ToLower()));
            if (found.Count == 0)
            {
                Console.WriteLine("No se encontraron contactos.");
            }
            else
            {
                Console.WriteLine("Contactos encontrados:");
                foreach (var contact in found)
                {
                    Console.WriteLine(contact);
                }
            }
        }

        public void DeleteContact(string name)
        {
            contacts.RemoveAll(c => c.Name.ToLower() == name.ToLower());
            Console.WriteLine("Contacto(s) eliminado(s) si existían.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nAgenda Telefónica");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Eliminar contacto");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Nombre: ");
                        string name = Console.ReadLine();
                        Console.Write("Teléfono: ");
                        string phone = Console.ReadLine();
                        phoneBook.AddContact(name, phone);
                        break;
                    case "2":
                        phoneBook.ShowContacts();
                        break;
                    case "3":
                        Console.Write("Nombre a buscar: ");
                        string searchName = Console.ReadLine();
                        phoneBook.SearchContact(searchName);
                        break;
                    case "4":
                        Console.Write("Nombre a eliminar: ");
                        string deleteName = Console.ReadLine();
                        phoneBook.DeleteContact(deleteName);
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
