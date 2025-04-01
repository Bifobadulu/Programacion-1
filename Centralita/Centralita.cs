// Clase que maneja la centralita
public class Centralita
{
    private List<Llamada> llamadas;
    public int TotalLlamadas { get; private set; }
    public double TotalFacturacion { get; private set; }

    public Centralita()
    {
        llamadas = new List<Llamada>();
    }

    public void RegistrarLlamada(Llamada llamada)
    {
        llamadas.Add(llamada);
        TotalLlamadas++;
        TotalFacturacion += llamada.CalcularCosto();
        MostrarLlamadas();
    }

    public void MostrarLlamadas()
    {
        Console.WriteLine("Resumen de Llamadas:");
        foreach (var llamada in llamadas)
        {
            Console.WriteLine($"Origen: {llamada.Origen}, Destino: {llamada.Destino}, " +
                              $"Duración: {llamada.Duracion} seg, Costo: {llamada.CalcularCosto():C}");
        }
        Console.WriteLine($"Total Llamadas: {TotalLlamadas}, Costo Total: {TotalFacturacion:C}");
    }
}