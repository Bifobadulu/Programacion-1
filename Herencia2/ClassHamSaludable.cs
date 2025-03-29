using System;

namespace ChimiMiBarriga.Models
{
    public class HamburguesaSaludable : Hamburguesa
    {
        public HamburguesaSaludable(string tipoCarne, double precioBase) 
            : base("Integral", tipoCarne, precioBase)
        {
            LimiteIngredientes = 6;
        }

        public override void AgregarIngrediente(string nombre, double precio)
        {
            if (IngredientesAdicionales.Count >= LimiteIngredientes)
            {
                Console.WriteLine($"¡No se pueden agregar más ingredientes! Límite saludable: {LimiteIngredientes}");
                return;
            }

            IngredientesAdicionales.Add(new IngredienteAdicional(nombre, precio));
            Console.WriteLine($"Ingrediente saludable {nombre} agregado por ${precio}");
        }
    }
}