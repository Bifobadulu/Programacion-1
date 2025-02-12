//  8. Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números negativos hay.
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

        int negativos = calculonegativos(numeros);
        Console.WriteLine($"\nLa cantidad de numeros negativos es: {negativos}");

    }

    static int calculonegativos(int[] arreglo)
    {
        int ContadorNegativos = 0;
        for (int i = 0; i<10; i++)
        {
            if (arreglo[i] < 0)
            {
            ContadorNegativos++;
            }

        }
    return ContadorNegativos;
    }
}