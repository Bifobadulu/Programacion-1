using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de las clases derivadas
        Gallina gallina = new Gallina("Robert", "Marrón", true, "Roja");
        Pato pato = new Pato("Francisco", "Blanco", true, "Plano");
        Aguila aguila = new Aguila("Edwin", "Marrón y blanco", 2.1, "Aguda");
        Pinguino pinguino = new Pinguino("Lixon", "Negro y blanco", true, 36.0);
        Colibri colibri = new Colibri("Nehomar", "Verde", "Flor de campanilla", 80.0);

        // Crear un array de aves (demostración de polimorfismo)
        Ave[] aves = { gallina, pato, aguila, pinguino, colibri };

        // Mostrar información y comportamientos polimórficos
        foreach (Ave ave in aves)
        {
            ave.MostrarInformacion();
            ave.Cantar();
            ave.Volar();

            // Utilizando operador 'is' para comprobar el tipo y acceder a métodos específicos
            if (ave is Gallina g)
                g.Picotear();
            else if (ave is Pato p)
                p.Nadar();
            else if (ave is Aguila a)
                a.Cazar();
            else if (ave is Pinguino pin)
                pin.Deslizarse();
            else if (ave is Colibri c)
                c.LibarNectar();

            Console.WriteLine("------------------------------");
        }
    }
}