using System;

namespace ProgLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            BinaryTree tree = new BinaryTree();

            char charToFind;
            int charToFindAmount = 0;
            int space = 6;

            int nodesAmount = input.GetNodesAmount();

            for (int i = 0; i < nodesAmount; i++)
            {
                Console.WriteLine("Enter value: ");
                tree.Add(Console.ReadLine()[0]);
            }
            tree.Display(space);

            charToFind = input.GetCharToFind();
            tree.Find(charToFind, ref charToFindAmount);

            Console.WriteLine("Amount of finding chars:" + charToFindAmount);
        }
    }

    class Input
    {
        public int GetNodesAmount()
        {
            Console.WriteLine("Enter nodes amount: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public char GetCharToFind()
        {
            Console.WriteLine("Enter char to find: ");
            return Convert.ToChar(Console.ReadLine());
        }
    }
}
