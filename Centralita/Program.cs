using System;
using System.Collections.Generic;

// Ejemplo de uso
public class Practica2
{
    public static void Main(string[] args)
    {
        Centralita centralita = new Centralita();

        // Registrando diferentes tipos de llamadas
        centralita.RegistrarLlamada(new LlamadaLocal { Origen = "123", Destino = "456", Duracion = 60 });
        centralita.RegistrarLlamada(new LlamadaProvincial { Origen = "789", Destino = "012", Duracion = 120, FranjaHoraria = 1 });
    }
}
