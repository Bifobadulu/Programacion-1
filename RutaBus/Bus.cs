using System;

namespace SistemaBus
{
    // Clase base que representa un bus
    public class Bus
    {
        // Propiedades
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public int AsientosOcupados { get; set; }
        public decimal PrecioPasaje { get; set; }
        public decimal Ventas { get; set; }

        // Constructor
        public Bus(string nombre, int capacidad, decimal precioPasaje)
        {
            Nombre = nombre;
            Capacidad = capacidad;
            PrecioPasaje = precioPasaje;
            AsientosOcupados = 0;
            Ventas = 0;
        }

        // Método para vender un pasaje
        public void VenderPasaje(int cantidad)
        {
            if (AsientosOcupados + cantidad <= Capacidad)
            {
                AsientosOcupados += cantidad;
                Ventas += cantidad * PrecioPasaje;
                Console.WriteLine($"{cantidad} pasaje(s) vendido(s) en {Nombre}.");
            }
            else
            {
                Console.WriteLine($"No hay suficientes asientos disponibles en {Nombre}.");
            }
        }

        // Método para mostrar información del bus
        public void MostrarInformacion()
        {
            Console.WriteLine($"{Nombre} - Pasajeros: {AsientosOcupados}, Ventas: {Ventas:C}, Asientos disponibles: {Capacidad - AsientosOcupados}");
        }
    }
}