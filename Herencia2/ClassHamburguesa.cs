using System;
using System.Collections.Generic;

namespace ChimiMiBarriga.Models
{
    public class Hamburguesa
    {
        protected string TipoPan { get; set; }
        protected string TipoCarne { get; set; }
        protected double PrecioBase { get; set; }
        protected List<IngredienteAdicional> IngredientesAdicionales { get; set; }
        protected int LimiteIngredientes { get; set; }

        public Hamburguesa(string tipoPan, string tipoCarne, double precioBase)
        {
            TipoPan = tipoPan;
            TipoCarne = tipoCarne;
            PrecioBase = precioBase;
            IngredientesAdicionales = new List<IngredienteAdicional>();
            LimiteIngredientes = 4;
        }

        public virtual void AgregarIngrediente(string nombre, double precio)
        {
            if (IngredientesAdicionales.Count >= LimiteIngredientes)
            {
                Console.WriteLine($"¡No se pueden agregar más ingredientes! Límite: {LimiteIngredientes}");
                return;
            }

            IngredientesAdicionales.Add(new IngredienteAdicional(nombre, precio));
            Console.WriteLine($"Ingrediente {nombre} agregado por ${precio}");
        }

        public virtual void MostrarPrecio()
        {
            Console.WriteLine("\n--- Detalle de la Hamburguesa ---");
            Console.WriteLine($"Pan: {TipoPan}");
            Console.WriteLine($"Carne: {TipoCarne}");
            Console.WriteLine($"Precio Base: ${PrecioBase}");

            double total = PrecioBase;

            foreach (var ingrediente in IngredientesAdicionales)
            {
                Console.WriteLine($" + {ingrediente.Nombre}: ${ingrediente.Precio}");
                total += ingrediente.Precio;
            }

            Console.WriteLine($"TOTAL: ${total}");
        }
    }
}