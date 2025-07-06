public class ListaEnlazada
{
    public Nodo Cabeza;

    public ListaEnlazada()
    {
        Cabeza = null;
    }

    public void AgregarAlFinal(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (Cabeza == null)
        {
            Cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }
