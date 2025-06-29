using System;
using System.Collections.Generic;

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

        Console.WriteLine("¿Deseas agregar otra asignatura? (s/n)");
        string respuesta = Console.ReadLine()?.ToLower();

        while (respuesta == "s")
        {
            Console.Write("Ingresa el nombre de la asignatura: ");
            string nuevaAsignatura = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nuevaAsignatura))
            {
                asignaturas.Add(new Asignatura(nuevaAsignatura));
            }

            Console.WriteLine("¿Deseas agregar otra asignatura? (s/n)");
            respuesta = Console.ReadLine()?.ToLower();
        }

        asignaturas.Sort((a, b) => a.Nombre.CompareTo(b.Nombre));

    }
}
