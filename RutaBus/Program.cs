using System;
  // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de los buses
            PlatinumBus busPlatinum = new PlatinumBus();
            GoldBus busGold = new GoldBus();

            // Simular venta de pasajes
            busPlatinum.VenderPasaje(5);
            busGold.VenderPasaje(3);

            // Mostrar información actualizada
            busPlatinum.MostrarInformacion();
            busGold.MostrarInformacion();
        }
    }
