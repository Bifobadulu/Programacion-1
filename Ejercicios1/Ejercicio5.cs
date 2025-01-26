//5.Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito.

using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite un número entero de tres dígitos:");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        // Verificar si el número tiene dos dígitos
        if (numero1 > 99 && numero1 < 1000 || numero1 < -99 && numero1 > -1000)
        {
            int c = Math.Abs(numero1) % 10;      // Último dígito
            int n = Math.Abs(numero1 / 10);      // Parte entera menos el último dígito
            int b = n % 10;                      // Segundo dígito
            int a = n / 10;                      // Primer dígito
            if (a != b && a != c && b != c)
            {
                if (a > b)
                {
                    if (a > c)
                    {
                        Console.WriteLine($"El digito mayor es {a} y se encuentra en la posicion 1");
                    }
                    else
                    {
                        Console.WriteLine($"El digito mayor es {c} y se encuentra en la posicion 3");
                    }
                }
               else
                {
                    if (b > c)
                    {
                        Console.WriteLine($"El digito mayor es {b} y se encuentra en la posicion2");
                    }
                    else 
                    {
                        Console.WriteLine($"El digito mayor es {c} y se encuentra en la posicion 3");
                    }
                }
            }
            else 
            {
                Console.WriteLine("Los digitos del numero no son diferente, intentelo nuevamente ");
            }
        }   
        else
        {
            Console.WriteLine("El número ingresado no tiene tres dígitos. Intente nuevamente.");
        }


    }
}