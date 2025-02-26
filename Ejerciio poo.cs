using System;

namespace PracticaPOO
{
    class Motor
    {
        private int litros_de_aceite;
        private int potencia;

        public Motor(int potencia)
        {
            this.potencia = potencia;
            this.litros_de_aceite = 0;
        }

        public int GetLitrosDeAceite()
        {
            return litros_de_aceite;
        }

        public void SetLitrosDeAceite(int litros_de_aceite)
        {
            this.litros_de_aceite = litros_de_aceite;
        }

        public int GetPotencia()
        {
            return potencia;
        }

        public void SetPotencia(int potencia)
        {
            this.potencia = potencia;
        }
    }

    class Coche
    {
        private Motor motor;
        private string marca;
        private string modelo;
        private double precioAverias;

        public Coche(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precioAverias = 0;
            this.motor = new Motor(0);
        }

        public Motor GetMotor()
        {
            return motor;
        }

        public string GetMarca()
        {
            return marca;
        }

        public string GetModelo()
        {
            return modelo;
        }

        public double GetPrecioAverias()
        {
            return precioAverias;
        }

        public void AcumularAveria(double importe)
        {
            precioAverias += importe;
        }
    }

    class Garaje
    {
        private Coche coche;
        private string averia;
        private int numeroCochesAtendidos;

        public Garaje()
        {
            coche = null;
            averia = null;
            numeroCochesAtendidos = 0;
        }

        public bool AceptarCoche(Coche coche, string averia)
        {
            if (this.coche == null)
            {
                this.coche = coche;
                this.averia = averia;
                numeroCochesAtendidos++;
                return true;
            }
            return false;
        }

        public void DevolverCoche()
        {
            coche = null;
            averia = null;
        }
    }

    class PracticaPOO
    {
        static void Main(string[] args)
        {
            Garaje garaje = new Garaje();
            Coche coche1 = new Coche("Toyota", "Corolla");
            Coche coche2 = new Coche("Honda", "Civic");

            Random random = new Random();

            for (int i = 0; i < 2; i++)
            {
                if (garaje.AceptarCoche(coche1, "aceite"))
                {
                    double importe = random.NextDouble();
                    coche1.AcumularAveria(importe);
                    coche1.GetMotor().SetLitrosDeAceite(coche1.GetMotor().GetLitrosDeAceite() + 10);
                    garaje.DevolverCoche();
                }

                if (garaje.AceptarCoche(coche2, "mecanica"))
                {
                    double importe = random.NextDouble();
                    coche2.AcumularAveria(importe);
                    garaje.DevolverCoche();
                }
            }

            Console.WriteLine($"Coche 1 ({coche1.GetMarca()} {coche1.GetModelo()}): Precio acumulado de averías: {coche1.GetPrecioAverias()}, Litros de aceite: {coche1.GetMotor().GetLitrosDeAceite()}");
            Console.WriteLine($"Coche 2 ({coche2.GetMarca()} {coche2.GetModelo()}): Precio acumulado de averías: {coche2.GetPrecioAverias()}");
        }
    }
}