using System;
using ChimiMiBarriga.Models;

namespace ChimiMiBarriga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a Chimi MiBarriga del Sr. Billy Navaja!\n");

            // Ejemplo de hamburguesa clásica
            var hamburguesaClasica = new Hamburguesa("Blanco", "Res", 5.50);
            hamburguesaClasica.AgregarIngrediente("Lechuga", 0.50);
            hamburguesaClasica.AgregarIngrediente("Tomate", 0.75);
            hamburguesaClasica.AgregarIngrediente("Queso", 1.25);
            hamburguesaClasica.AgregarIngrediente("Bacon", 1.50);
            hamburguesaClasica.MostrarPrecio();

            // Ejemplo de hamburguesa saludable
            var hamburguesaSaludable = new HamburguesaSaludable("Pollo", 6.00);
            hamburguesaSaludable.AgregarIngrediente("Espinaca", 0.60);
            hamburguesaSaludable.AgregarIngrediente("Aguacate", 1.50);
            hamburguesaSaludable.AgregarIngrediente("Champiñones", 1.00);
            hamburguesaSaludable.MostrarPrecio();

            // Ejemplo de hamburguesa premium
            var hamburguesaPremium = new HamburguesaPremium("Angus", 8.50);
            hamburguesaPremium.AgregarIngrediente("Queso extra", 1.50); // No se permitirá
            hamburguesaPremium.MostrarPrecio();
        }
    }
}