using System; 

public class Pinguino : Ave
{
    public bool ResisteFrio { get; set; }
    public double VelocidadNado { get; set; }

    public Pinguino(string nombre, string color, bool resisteFrio, double velocidadNado)
        : base(nombre, color)
    {
        ResisteFrio = resisteFrio;
        VelocidadNado = velocidadNado;
    }

    public override void Cantar()
    {
        Console.WriteLine("¡Cuak-gruuuahk!");
    }

    public override void Volar()
    {
        Console.WriteLine("El pingüino no puede volar, pero nada excelentemente.");
    }

    public void Deslizarse()
    {
        Console.WriteLine($"{Nombre} se desliza sobre el hielo.");
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Resiste frío: {(ResisteFrio ? "Sí" : "No")}");
        Console.WriteLine($"Velocidad de nado: {VelocidadNado} km/h");
    }
}