//  7. Leer 10 números enteros, almacenarlos en un arreglo y determinar a cuánto es igual el promedio entero de los datos del arreglo
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10]; // Declarar un arreglo de 10 enteros

        // Leer los 10 enteros desde la entrada del usuario
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine()); 
        }

        // Mostrar los números ingresados
        Console.WriteLine("\nNúmeros ingresados:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }

        // Calcular el promedio entero
        int promedio = promedioDatos(numeros);
        Console.WriteLine($"\nEl promedio de los datos del arreglo es {promedio}");
    }

    static int promedioDatos(int[] arreglo)
    {
        int suma = 0;
        foreach (int numero in arreglo)
        {
            suma += numero;
        }

        // Calcular el promedio como double y luego redondearlo a entero
        double promedioDecimal = (double)suma / arreglo.Length;
        int promedioEntero = (int)Math.Round(promedioDecimal); 

        return promedioEntero;
    }
}
