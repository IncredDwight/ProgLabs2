using System;

namespace ProgLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            int pairAmount = input.GetPairsAmount();
            int maxTime = input.GetRandomMax("Enter max time: ");
            int maxPrice = input.GetRandomMax("Enter max price: ");
            Job[] jobs = new Job[pairAmount];

            for (int i = 0; i < pairAmount; i++)
            {
                jobs[i] = new Job(input.GenerateTime(maxTime), input.GenerateMoney(maxPrice));
                Console.WriteLine(jobs[i].Display());
                Console.WriteLine("Total job price: " + jobs[i].GetTotalPrice().Display());
            }
            
        }
    }
}
