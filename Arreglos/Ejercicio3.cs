//     Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número primo leído.
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
        if (primo(mayor))
        {
          // Mostrar los números ingresados
        Console.WriteLine("\nNúmeros ingresados:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
        // Mostrar resultados
        Console.WriteLine($"\nEl número más grande primo es: {mayor}, en la posición: {posicion}");
        }
        else 
        {
            Console.WriteLine($"\nEl numero mas grande no es primo y es: {mayor}, en la posicion: {posicion}");
        }
    }
    static bool primo(int num)
    {
        if (num < 2) return false;
        if(num == 2) return true;
        if (num % 2 == 0) return false;

        for(int i = 3; i*i <= num; i+=2)
        {
            if (num % i ==0) return false;
        }
        return true;
    }
}