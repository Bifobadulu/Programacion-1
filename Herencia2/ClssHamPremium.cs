using System;

namespace ChimiMiBarriga.Models
{
    public class HamburguesaPremium : Hamburguesa
    {
        public HamburguesaPremium(string tipoCarne, double precioBase) 
            : base("Brioche", tipoCarne, precioBase)
        {
            IngredientesAdicionales.Add(new IngredienteAdicional("Papitas", 2.50));
            IngredientesAdicionales.Add(new IngredienteAdicional("Bebida", 1.80));
            LimiteIngredientes = 2;
        }

        public override void AgregarIngrediente(string nombre, double precio)
        {
            Console.WriteLine("¡No se pueden agregar más ingredientes a la hamburguesa Premium! Ya incluye papitas y bebida.");
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("\n--- Hamburguesa Premium ---");
            Console.WriteLine($"Pan: {TipoPan} (Premium)");
            Console.WriteLine($"Carne: {TipoCarne}");
            Console.WriteLine($"Precio Base: ${PrecioBase}");

            double total = PrecioBase;

            foreach (var ingrediente in IngredientesAdicionales)
            {
                Console.WriteLine($" * {ingrediente.Nombre} (incluido): ${ingrediente.Precio}");
                total += ingrediente.Precio;
            }

            Console.WriteLine($"TOTAL: ${total}");
        }
    }
}