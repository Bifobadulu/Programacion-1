using System; 
public class Pato : Ave
{
    public bool SabeNadar { get; set; }
    public string TipoPico { get; set; }

    public Pato(string nombre, string color, bool sabeNadar, string tipoPico)
        : base(nombre, color)
    {
        SabeNadar = sabeNadar;
        TipoPico = tipoPico;
    }

    public override void Cantar()
    {
        Console.WriteLine("¡Cuac-cuac-cuac!");
    }

    public override void Volar()
    {
        Console.WriteLine("El pato vuela en formación V a alturas medias.");
    }

    public void Nadar()
    {
        Console.WriteLine($"{Nombre} está nadando en el estanque.");
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Sabe nadar: {(SabeNadar ? "Sí" : "No")}");
        Console.WriteLine($"Tipo de pico: {TipoPico}");
    }
}
