using System;

// Clase base Ave
public abstract class Ave
{
    // Propiedades
    public string Nombre { get; set; }
    public string Color { get; set; }
    

    // Constructor
    public Ave(string nombre, string color)
    {
        Nombre = nombre;
        Color = color;

    }

    // Métodos abstractos (polimórficos)
    public abstract void Cantar();
    public abstract void Volar();

    // Método virtual (polimórfico con implementación base)
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre Ave: {Nombre}");
        Console.WriteLine($"Color: {Color}");
    }
}







