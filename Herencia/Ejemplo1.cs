// EJEMPLO 1: HERENCIA BÁSICA
// Caso de uso: Sistema de empleados en una empresa

using System;

// Clase base
public class Empleado
{
    public string Nombre { get; set; }
    public string ID { get; set; }
    public double SalarioBase { get; set; }

    public Empleado(string nombre, string id, double salarioBase)
    {
        Nombre = nombre;
        ID = id;
        SalarioBase = salarioBase;
    }

    public virtual double CalcularSalario()
    {
        return SalarioBase;
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Empleado: {Nombre}, ID: {ID}, Salario: {CalcularSalario()}");
    }
}

// Clase derivada 1
public class Gerente : Empleado
{
    public double Bono { get; set; }

    public Gerente(string nombre, string id, double salarioBase, double bono)
        : base(nombre, id, salarioBase)
    {
        Bono = bono;
    }

    public override double CalcularSalario()
    {
        return SalarioBase + Bono;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Gerente: {Nombre}, ID: {ID}, Salario: {CalcularSalario()} (incluye bono de {Bono})");
    }
}

// Clase derivada 2
public class Desarrollador : Empleado
{
    public string Especialidad { get; set; }
    public int HorasExtra { get; set; }

    public Desarrollador(string nombre, string id, double salarioBase, string especialidad, int horasExtra)
        : base(nombre, id, salarioBase)
    {
        Especialidad = especialidad;
        HorasExtra = horasExtra;
    }

    public override double CalcularSalario()
    {
        return SalarioBase + (HorasExtra * 25);
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Desarrollador: {Nombre}, ID: {ID}, Especialidad: {Especialidad}, Salario: {CalcularSalario()} (incluye {HorasExtra} horas extra)");
    }
}