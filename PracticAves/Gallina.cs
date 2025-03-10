using System; 
public class Gallina : Ave
{
    public bool PoneHuevos { get; set; }
    public string TipoCresta { get; set; }

    public Gallina(string nombre, string color, bool poneHuevos, string tipoCresta)
        : base(nombre, color)
    {
        PoneHuevos = poneHuevos;
        TipoCresta = tipoCresta;
    }

    public override void Cantar()
    {
        Console.WriteLine("¡Co-co-co-co!");
    }

    public override void Volar()
    {
        Console.WriteLine("La gallina vuela poco y a baja altura.");
    }

    public void Picotear()
    {
        Console.WriteLine($"{Nombre} está picoteando el suelo.");
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Pone huevos: {(PoneHuevos ? "Sí" : "No")}");
        Console.WriteLine($"Tipo de cresta: {TipoCresta}");
    }
}