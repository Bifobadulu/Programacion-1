// Clase derivada: LlamadaProvincial
public class LlamadaProvincial : Llamada
{
    private static readonly double[] CostosPorFranja = { 0.20, 0.25, 0.30 }; // Costos por franja
    public int FranjaHoraria { get; set; } // 0, 1 o 2 representan las franjas

    public override double CalcularCosto()
    {
        return Duracion * CostosPorFranja[FranjaHoraria];
    }
}