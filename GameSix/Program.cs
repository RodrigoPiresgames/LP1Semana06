using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many foes would u like?");
            Console.WriteLine(" ");
            string aux = Console.ReadLine();
            int numFoes = Convert.ToInt16(aux);

            Foe[] foes;
            for (int x = 0; x < numFoes; x++)
            {
                Console.WriteLine("How will this one be called");
                Console.WriteLine(" ");
                aux = Console.ReadLine();

                Foe enemy = new Foe(aux);

                foes.Append(enemy);
            }

            foreach (Foe baddie in foes)
                baddie.GetHealth;
        }
    }
}
