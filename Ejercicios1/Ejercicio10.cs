//10.Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10 entonces mostrar en pantalla todos los enteros comprendidos entre el menor 
//y el mayor de los números leídos.

using System;

class program
{
    static void Main(string[] args)
    { 
         Console.WriteLine("Digite un número entero:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Digite un número entero :");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resta = Math.Abs(numero1 - numero2);
        if (resta <= 10 )
        {
            int menor = Math.Min(numero1, numero2);
            int mayor = Math.Max(numero1, numero2);
            
            Console.WriteLine($"\n Los numeros entre {menor} y {mayor} son:");
            for (int i = menor + 1; i < mayor; i = i+1)
            {
            Console.WriteLine($"{i}");
            }
        }
        else 
        {
            Console.WriteLine("La resta entre los numeros no es menor o igual a 10");
        }
        

            
    }
}