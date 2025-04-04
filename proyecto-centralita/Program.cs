using System.Diagnostics;

public class Programa
{
    public static void Main(string[] args)
    {
        Centralita centralita = new Centralita();

        Console.Write("Ingrese número de origen: ");
        string origen = Console.ReadLine();

        Console.Write("Ingrese número de destino: ");
        string destino = Console.ReadLine();

        Console.WriteLine("Seleccione el tipo de llamada: ");
        Console.WriteLine("1. Llamada Local");
        Console.WriteLine("2. Llamada Provincial");
        int tipoLlamada = int.Parse(Console.ReadLine());

        Llamada llamada;
        if (tipoLlamada == 2)
        {
            Console.WriteLine("Seleccione la franja horaria (0, 1 o 2): ");
            int franja = int.Parse(Console.ReadLine());
            llamada = new LlamadaProvincial { Origen = origen, Destino = destino, FranjaHoraria = franja };
        }
        else
        {
            llamada = new LlamadaLocal { Origen = origen, Destino = destino };
        }

        Console.WriteLine("Presione una tecla para iniciar la llamada...");
        Console.ReadKey();
        Stopwatch cronometro = new Stopwatch();
        cronometro.Start();

        Console.WriteLine("Llamada en curso... Presione otra tecla para colgar.");
        Console.ReadKey();
        cronometro.Stop();

        llamada.Duracion = (int)cronometro.Elapsed.TotalSeconds;

        centralita.RegistrarLlamada(llamada);
        Console.WriteLine("Llamada finalizada y guardada en la base de datos.");
    }
}
