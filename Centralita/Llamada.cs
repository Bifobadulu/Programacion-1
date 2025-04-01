// Clase base
public abstract class Llamada
{
    public string Origen { get; set; }
    public string Destino { get; set; }
    public int Duracion { get; set; } // Duración en segundos

    public abstract double CalcularCosto(); // Método abstracto para calcular el costo
}