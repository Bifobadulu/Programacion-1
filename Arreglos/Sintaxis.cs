using System;

class program
{
    static void Main(string[] args)
    {   
        int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};
        //int numero = numeros[0];
        for (int i=0; i<numeros.Length; i++)
        {
            Console.WriteLine("iteracion: " +i+" - "+ numeros[i]);
        }
        foreach (var numero in numeros) // no hay que colocar condicion el solo para cuando se acaba los elementos del arreglo
        {
            Console.WriteLine(numero);
        }
    }

}