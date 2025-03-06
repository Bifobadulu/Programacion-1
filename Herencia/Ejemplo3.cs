// EJEMPLO 3: HERENCIA CON CLASES ABSTRACTAS
// Caso de uso: Figuras geométricas

public abstract class FiguraGeometrica
{
    public string Color { get; set; }

    protected FiguraGeometrica(string color)
    {
        Color = color;
    }

    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();

    public void MostrarInformacion()
    {
        Console.WriteLine($"Figura de color {Color}");
        Console.WriteLine($"Área: {CalcularArea()}");
        Console.WriteLine($"Perímetro: {CalcularPerimetro()}");
    }
}

public class Circulo : FiguraGeometrica
{
    public double Radio { get; set; }

    public Circulo(string color, double radio)
        : base(color)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
}

public class Rectangulo : FiguraGeometrica
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Rectangulo(string color, double ancho, double alto)
        : base(color)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public override double CalcularArea()
    {
        return Ancho * Alto;
    }

    public override double CalcularPerimetro()
    {
        return 2 * (Ancho + Alto);
    }
}