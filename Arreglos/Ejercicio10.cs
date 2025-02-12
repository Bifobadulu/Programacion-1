//  10.   Leer 10 números enteros, almacenarlos en un arreglo. Luego leer un entero y determinar cuántos divisores exactos tiene este último número entre los valores almacenados en el arreglo.10.   Leer 10 números enteros, almacenarlos en un arreglo. Luego leer un entero y determinar cuántos divisores exactos tiene este último número entre los valores almacenados en el arreglo.
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

        // Leer el número entero adicional
        Console.Write("\nIngrese un número entero para verificar sus divisores: ");
        int numeroVerificar = Convert.ToInt32(Console.ReadLine());

        // Contar cuántos números en el arreglo son divisores exactos del número ingresado
        int contadorDivisores = 0;
        for (int i = 0; i < 10; i++)
        {
            if (EsDivisorExacto(numeroVerificar, numeros[i]))
            {
                contadorDivisores++;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"\nEl número {numeroVerificar} tiene {contadorDivisores} divisores exactos en el arreglo.");
    }

    // Función para verificar si un número es divisor exacto de otro
    static bool EsDivisorExacto(int numero, int divisor)
    {
        if (divisor == 0) // Evitar división por cero
        {
            return false;
        }
        return numero % divisor == 0; // Verificar si el residuo es cero
    }
}//  10.   Leer 10 números enteros, almacenarlos en un arreglo. Luego leer un entero y determinar cuántos divisores exactos tiene este último número entre los valores almacenados en el arreglo.10.   Leer 10 números enteros, almacenarlos en un arreglo. Luego leer un entero y determinar cuántos divisores exactos tiene este último número entre los valores almacenados en el arreglo.
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

        // Leer el número entero adicional
        Console.Write("\nIngrese un número entero para verificar sus divisores: ");
        int numeroVerificar = Convert.ToInt32(Console.ReadLine());

        // Contar cuántos números en el arreglo son divisores exactos del número ingresado
        int contadorDivisores = 0;
        for (int i = 0; i < 10; i++)
        {
            if (EsDivisorExacto(numeroVerificar, numeros[i]))
            {
                contadorDivisores++;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"\nEl número {numeroVerificar} tiene {contadorDivisores} divisores exactos en el arreglo.");
    }

    // Función para verificar si un número es divisor exacto de otro
    static bool EsDivisorExacto(int numero, int divisor)
    {
        if (divisor == 0) // Evitar división por cero
        {
            return false;
        }
        return numero % divisor == 0; // Verificar si el residuo es cero
    }
}