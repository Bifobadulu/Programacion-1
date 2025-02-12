//  5. Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posición se encuentra el número primo con mayor cantidad de dígitos pares.
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10]; // Arreglo para almacenar los 10 números
        int posicionMayor = -1;      // Posición del número primo con más dígitos pares
        int maxPares = -1;           // Cantidad máxima de dígitos pares encontrados

        // Leer los 10 números enteros
        Console.WriteLine("Ingrese 10 números enteros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Recorrer el arreglo para encontrar el número primo con más dígitos pares
        for (int i = 0; i < 10; i++)
        {
            if (EsPrimo(numeros[i])) // Verificar si el número es primo
            {
                int cantidadPares = ContarDigitosPares(numeros[i]); // Contar dígitos pares

                // Actualizar si este número tiene más dígitos pares que el máximo actual
                if (cantidadPares > maxPares)
                {
                    maxPares = cantidadPares;
                    posicionMayor = i;
                }
            }
        }

        // Mostrar el resultado
        if (posicionMayor != -1)
        {
            Console.WriteLine($"El número primo con más dígitos pares es {numeros[posicionMayor]} en la posición {posicionMayor + 1}.");
        }
        else
        {
            Console.WriteLine("No se encontraron números primos en el arreglo.");
        }
    }

    // Función para verificar si un número es primo
    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false; // Los números menores a 2 no son primos

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
            {
                return false; // No es primo si es divisible por algún número
            }
        }
        return true; // Es primo
    }

    // Función para contar la cantidad de dígitos pares en un número
    static int ContarDigitosPares(int numero)
    {
        int contador = 0;
        numero = Math.Abs(numero); // Trabajar con el valor absoluto para evitar problemas con números negativos

        while (numero > 0)
        {
            int digito = numero % 10; // Obtener el último dígito
            if (digito % 2 == 0)      // Verificar si el dígito es par
            {
                contador++;
            }
            numero /= 10; // Eliminar el último dígito
        }
        return contador;
    }
}