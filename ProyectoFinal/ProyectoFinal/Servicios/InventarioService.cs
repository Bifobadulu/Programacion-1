using System.Collections.Generic;
using InventarioPOO.Modelos;

namespace InventarioPOO.Servicios
{
    public class InventarioService
    {
        private List<Producto> inventario = new List<Producto>();

        public List<Producto> ObtenerInventario() => inventario;

        public void AgregarProducto(Producto producto)
        {
            inventario.Add(producto);
        }

        public void ModificarProducto(int index, Producto nuevoProducto)
        {
            if (index >= 0 && index < inventario.Count)
            {
                inventario[index] = nuevoProducto;
            }
        }

        public void EliminarProducto(int index)
        {
            if (index >= 0 && index < inventario.Count)
            {
                inventario.RemoveAt(index);
            }
        }
    }
}