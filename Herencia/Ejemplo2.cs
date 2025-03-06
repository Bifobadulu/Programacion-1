// EJEMPLO 2: HERENCIA MULTINIVEL
// Caso de uso: Vehículos

public class Vehiculo
{
    public string Marca { get; set; }
    public int Año { get; set; }

    public Vehiculo(string marca, int año)
    {
        Marca = marca;
        Año = año;
    }

    public virtual void Arrancar()
    {
        Console.WriteLine("Vehículo arrancando");
    }
}

public class Automovil : Vehiculo
{
    public int NumeroPuertas { get; set; }

    public Automovil(string marca, int año, int numeroPuertas)
        : base(marca, año)
    {
        NumeroPuertas = numeroPuertas;
    }

    public override void Arrancar()
    {
        Console.WriteLine($"Automóvil {Marca} arrancando con llave");
    }
}

public class AutomovilElectrico : Automovil
{
    public int CapacidadBateria { get; set; }

    public AutomovilElectrico(string marca, int año, int numeroPuertas, int capacidadBateria)
        : base(marca, año, numeroPuertas)
    {
        CapacidadBateria = capacidadBateria;
    }

    public override void Arrancar()
    {
        Console.WriteLine($"Automóvil eléctrico {Marca} arrancando con botón - batería al {CapacidadBateria}%");
    }

    public void Cargar()
    {
        Console.WriteLine($"Cargando batería del automóvil eléctrico {Marca}");
    }
}