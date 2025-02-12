//  Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número leído.
using System;
using System.Linq; // Necesario para usar Max()

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
        // Encontrar el mayor número y su posicion
        int mayor = numeros.Max(); // Obtiene el número más grande
        int posicion = Array.IndexOf(numeros, mayor);
          // Mostrar los números ingresados
        Console.WriteLine("\nNúmeros ingresados:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
        // Mostrar resultados
        Console.WriteLine($"\nEl número más grande par es: {mayor}, en la posición: {posicion}");
        
       
       
    }
}