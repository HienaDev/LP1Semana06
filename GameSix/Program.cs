using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Foe Loki = new Foe("Loki");

            Console.WriteLine(Loki.GetName());

            Loki.SetName("   Grindalokki  ");

            Console.WriteLine(Loki.GetName());
        }
    }
}
