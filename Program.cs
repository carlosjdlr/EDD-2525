 class Estudiante
 {
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos = new string[3];
    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombres} {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
 }
 class Program
 {
    static void Main()
    {
        Estudiante estudiante = new Estudiante();
        estudiante.Id = 1;
        estudiante.Nombres = "Carlos";
        estudiante.Apellidos = "Ramírez";
        estudiante.Direccion = "Av. Alvaro Noboa";
        estudiante.Telefonos[0] = "099999999";
        estudiante.Telefonos[1] = "098888888";
        estudiante.Telefonos[2] = "097777777";
        estudiante.MostrarInformacion();
    }
 }
