//  6.Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posiciones se encuentran los números con más de 3 dígitos
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10]; // Arreglo para almacenar los 10 números

        // Leer los 10 números enteros
        Console.WriteLine("Ingrese 10 números enteros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Recorrer el arreglo y mostrar las posiciones de los números con más de 3 dígitos
        Console.WriteLine("\nPosiciones de los números con más de 3 dígitos:");
        for (int i = 0; i < 10; i++)
        {
            if (Math.Abs(numeros[i]).ToString().Length > 3) // Verificar si tiene más de 3 dígitos
            {
                Console.WriteLine($"Posición {i + 1}: {numeros[i]}");
            }
        }
    }
}

