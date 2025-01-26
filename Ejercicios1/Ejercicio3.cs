//3.    Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.
//2, 3, 5, 7, 
using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite un número entero de dos dígitos:");
        int numero = Convert.ToInt32(Console.ReadLine());
        // Verificar si el número tiene dos dígitos
        if (numero > 9 && numero < 100 || numero < -9 && numero > -100)
        {
            int a = numero / 10;  // Primer dígito (decenas)
            int b = numero % 10;  // Segundo dígito (unidades)
           if ((a == 2 || a == 3 || a == 5 || a == 7) && (b == 2 || b == 3 || b == 5 || b == 7))
           {
                Console.WriteLine("Ambos digitos son primos ");
           }
           else
           {
                if (a == 2 || a == 3 || a == 5 || a == 7)
                {
                    Console.WriteLine($"El digito {a} es primo");
                }
                else if (b == 2 || b == 3 || b == 5 || b == 7)
                {
                    Console.WriteLine($"El digito {b} es primo");
                }
                else
                {
                    Console.WriteLine("Ningun Digito es primo");
                }
           }

           
        }
        else
        {
            Console.WriteLine("El número ingresado no tiene dos dígitos. Intente nuevamente.");
        }
    }
}