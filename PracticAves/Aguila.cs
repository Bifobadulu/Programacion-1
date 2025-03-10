using System;
public class Aguila : Ave
{
    public double EnvergaduraAlas { get; set; }
    public string TipoVision { get; set; }

    public Aguila(string nombre, string color, double envergaduraAlas, string tipoVision)
        : base(nombre, color)
    {
        EnvergaduraAlas = envergaduraAlas;
        TipoVision = tipoVision;
    }

    public override void Cantar()
    {
        Console.WriteLine("¡Kriiiiiiiii!");
    }

    public override void Volar()
    {
        Console.WriteLine("El águila vuela a gran altura y puede planear por horas.");
    }

    public void Cazar()
    {
        Console.WriteLine($"{Nombre} está cazando desde las alturas.");
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Envergadura de alas: {EnvergaduraAlas} metros");
        Console.WriteLine($"Tipo de visión: {TipoVision}");
    }
}
