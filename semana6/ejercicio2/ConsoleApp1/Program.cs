using System;

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.AgregarAlFinal(10);
        lista.AgregarAlFinal(20);
        lista.AgregarAlFinal(30);
        lista.AgregarAlFinal(40);

        Console.WriteLine("Lista original:");
        lista.Imprimir();

        Console.WriteLine("Número de elementos: " + lista.ContarElementos());

        lista.Invertir();

        Console.WriteLine("Lista invertida:");
        lista.Imprimir();
    }
}
