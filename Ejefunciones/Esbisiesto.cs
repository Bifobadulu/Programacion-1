//Crear un programa en C# que utilice funciones para determinar si un año es bisiesto.
using System;
using System.Reflection.Metadata;

class Project 

    {
        static void Main(string[] args)
            {
                Console.WriteLine("Ingrese un año");
                int anoingresado = Convert.ToInt32(Console.ReadLine());
                bool resultado = Esbisiesto(anoingresado);
                if (resultado)
                {
                    Console.WriteLine($"El año {anoingresado} es bisiesto");
                }
                else 
                {
                    Console.WriteLine($"El año {anoingresado} no es bisiesto");
                }

               
               

            }
                // static void mensaje(), no retorna ningun valor 
               // {

               // }
                 static bool Esbisiesto(int ano) //asi podemos utilizar cualquier valor que queramos.  La estructura es static, el tipo, variab;e
               {
                if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
                {
                    return true;
                }
                else 
                {
                    return false; 
                }
                
                
               }


            

    }