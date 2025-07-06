
class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.AgregarAlFinal(10);
        lista.AgregarAlFinal(20);
        lista.AgregarAlFinal(30);
        lista.AgregarAlFinal(40);

        Console.WriteLine("Número de elementos en la lista: " + lista.ContarElementos());
    }
}
