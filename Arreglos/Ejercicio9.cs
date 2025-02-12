//  9.       Leer 10 números enteros, almacenarlos en un arreglo y calcular la factorial a cada uno de los números leídos almacenándolos en otro arreglo
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];       // Arreglo para almacenar los 10 números
        long[] factoriales = new long[10]; // Arreglo para almacenar los factoriales

        // Leer los 10 números enteros
        Console.WriteLine("Ingrese 10 números enteros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calcular el factorial de cada número y almacenarlo en el arreglo de factoriales
        for (int i = 0; i < 10; i++)
        {
            factoriales[i] = CalcularFactorial(numeros[i]);
        }

        // Mostrar los resultados
        Console.WriteLine("\nFactoriales calculados:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Factorial de {numeros[i]} es: {factoriales[i]}");
        }
    }

    // Función para calcular el factorial de un número
    static long CalcularFactorial(int numero)
    {
        if (numero < 0) // Los factoriales no están definidos para números negativos
        {
            return -1; // Retornar -1 como indicador de error
        }

        long factorial = 1;
        for (int i = 2; i <= numero; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
