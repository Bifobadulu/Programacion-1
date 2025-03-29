 namespace ChimiMiBarriga.Models
{
    public class IngredienteAdicional
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public IngredienteAdicional(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}