//4.Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.

using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite un número entero de dos dígitos:");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        // Verificar si el número tiene dos dígitos
        if (numero1 > 9 && numero1 < 100 || numero1 < -9 && numero1 > -100)
        {
            int a = numero1 / 10;  // Primer dígito (decenas)
            int b = numero1 % 10;  // Segundo dígito (unidades)
        }
        else
        {
            Console.WriteLine("El número ingresado no tiene dos dígitos. Intente nuevamente.");
        } 
        Console.WriteLine("Digite otro número entero de dos dígitos:");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        // Verificar si el número tiene dos dígitos
        if (numero2 > 9 && numero2 < 100 || numero2 < -9 && numero2 > -100)
        {
            int a = numero2 / 10;  // Primer dígito (decenas)
            int b = numero2 % 10;  // Segundo dígito (unidades)
        }
        else
        {
            Console.WriteLine("El número ingresado no tiene dos dígitos. Intente nuevamente.");
        }
        int suma = numero1 + numero2;
        Console.WriteLine($"La suma de los numeros {numero1} y {numero2} es: {suma}");
        if (suma % 2 == 0)
        {
            Console.WriteLine($"El numero {suma} es par");
        }
        else
        {
            Console.WriteLine($"El numero {suma} no es par");
        }


    }
}