
// Clase derivada: LlamadaLocal
public class LlamadaLocal : Llamada
{
    private const double CostoPorSegundo = 0.15;

    public override double CalcularCosto()
    {
        return Duracion * CostoPorSegundo;
    }
}