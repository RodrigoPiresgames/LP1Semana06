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
            int numFoes = Convert.ToInt32(aux);

            Foe[] foes = new Foe [numFoes];

            for (int x = 0; x < numFoes; x++)
            {
                Console.WriteLine("How will this one be called");
                Console.WriteLine(" ");
                aux = Console.ReadLine();

                foes[x] = new Foe(aux);
            }

            foreach (Foe baddie in foes)
            {
                Console.WriteLine($"Name: {baddie.GetName()}");
                Console.WriteLine($"Health: {baddie.GetHealth()}");
            }

            foes[1].PickUpPowerUp(PowerUp.Shield, 50);
            foes[2].TakeDamage(50);

            Console.WriteLine($"{foes[1].GetShield()}");
            Console.WriteLine($"{foes[2].GetHealth()}");
        }
    }
}
