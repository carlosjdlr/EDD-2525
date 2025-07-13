using System;
using System.Collections.Generic;

class Torre
{
    public Stack<int> Discos { get; private set; }
    public string Nombre { get; private set; }

    public Torre(string nombre)
    {
        Nombre = nombre;
        Discos = new Stack<int>();
    }

    public void MoverDiscoA(Torre destino)
    {
        int disco = Discos.Pop();
        destino.Discos.Push(disco);
        Console.WriteLine($"Mover disco {disco} de {Nombre} a {destino.Nombre}");
    }
}

class TorresDeHanoi
{
    /// <summary>
    /// Resuelve el problema de las Torres de Hanoi usando recursión y pilas.
    /// </summary>
    public static void Resolver(int n, Torre origen, Torre auxiliar, Torre destino)
    {
        if (n == 1)
        {
            origen.MoverDiscoA(destino);
            return;
        }

        Resolver(n - 1, origen, destino, auxiliar);
        origen.MoverDiscoA(destino);
        Resolver(n - 1, auxiliar, origen, destino);
    }

    static void Main()
    {
        int numeroDeDiscos = 3;
        Torre origen = new Torre("Origen");
        Torre auxiliar = new Torre("Auxiliar");
        Torre destino = new Torre("Destino");

        for (int i = numeroDeDiscos; i >= 1; i--)
        {
            origen.Discos.Push(i);
        }

        Resolver(numeroDeDiscos, origen, auxiliar, destino);
    }
}
