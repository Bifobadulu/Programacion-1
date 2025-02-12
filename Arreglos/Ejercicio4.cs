//    Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números de los almacenados en dicho arreglo comienzan en dígito primo
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

        // Contar cuántos números comienzan con un dígito primo
        int contador = 0;
        foreach (int num in numeros)
        {
            int primerDigito = ObtenerPrimerDigito(num);
            if (EsPrimo(primerDigito))
            {
                contador++;
            }
        }

        Console.WriteLine($"\nCantidad de números que comienzan con un dígito primo: {contador}");
    }

    // Método para obtener el primer dígito de un número
    static int ObtenerPrimerDigito(int num)
    {
        while (num >= 10)
        {
            num /= 10;
        }
        return num;
    }

    // Método para verificar si un número es primo
    static bool EsPrimo(int num)
    {
        if (num < 2) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}
