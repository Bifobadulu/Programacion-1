//8.Leer un número entero de cinco dígitos y determinar si es un número Capicúa. Ej. 15651, 59895.

using System;

class program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Digite un número entero de cinco dígitos:");
            string numero = Console.ReadLine();

            // Verificar si tiene 5 dígitos
            if (numero.Length == 5 && int.TryParse(numero, out int numeroEntero))
            {
                // Verificar si es capicúa comparando dígitos
                if (numero[0] == numero[4] && numero[1] == numero[3])
                {
                    Console.WriteLine($"El número {numero} es capicúa");
                }
                else
                {
                    Console.WriteLine($"El número {numero} no es capicúa");
                }
            }
            else
            {
                Console.WriteLine("El número debe tener exactamente 5 dígitos.");
            }

    }
}