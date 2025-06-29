public class Asignatura
{
    public string Nombre { get; set; }

    public Asignatura(string nombre)
    {
        Nombre = nombre;
    }

    public override string ToString()
    {
        return Nombre;
    }
}
