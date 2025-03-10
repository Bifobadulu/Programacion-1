using System;
public class Colibri : Ave
{
    public string TipoNectar { get; set; }
    public double VelocidadAleteo { get; set; }

    public Colibri(string nombre, string color, string tipoNectar, double velocidadAleteo)
        : base(nombre, color)
    {
        TipoNectar = tipoNectar;
        VelocidadAleteo = velocidadAleteo;
    }

    public override void Cantar()
    {
        Console.WriteLine("¡Tzit-tzit-tzit!");
    }

    public override void Volar()
    {
        Console.WriteLine("El colibrí puede volar en todas direcciones, incluso hacia atrás.");
    }

    public void LibarNectar()
    {
        Console.WriteLine($"{Nombre} está libando néctar de las flores.");
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Tipo de néctar preferido: {TipoNectar}");
        Console.WriteLine($"Velocidad de aleteo: {VelocidadAleteo} veces por segundo");
    }
}