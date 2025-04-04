// Clase base
public abstract class Llamada
{
    public string Origen { get; set; }
    public string Destino { get; set; }
    public int Duracion { get; set; }
    public abstract double CalcularCosto();
}
