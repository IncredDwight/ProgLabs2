using System;
namespace ProgLab5
{
    public class Input
    {
        public int GetPairsAmount()
        {
            int amount;

            Console.WriteLine("Enter pairs amount: ");

            while(!int.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Wrong input. Try again!");
            }

            return amount;
        }

        public int GetRandomMax(string title)
        {
            int randomMax;

            Console.WriteLine(title);

            while (!int.TryParse(Console.ReadLine(), out randomMax))
            {
                Console.WriteLine("Wrong input. Try again!");
            }

            return randomMax;

        }

        public TTime GenerateTime(int max)
        {
            Random rand = new Random();
            int minutes = rand.Next(0, 60);
            int hours = rand.Next(0, max);
            return new TTime(hours, minutes);
        }

        public TMoney GenerateMoney(int max)
        {
            Random rand = new Random();
            int number1 = rand.Next(0, max);
            int coins = rand.Next(0, 100);

            return new TMoney(number1, coins);
        }
    }
}
