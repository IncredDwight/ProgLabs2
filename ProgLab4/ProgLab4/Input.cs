using System;
namespace ProgLab4
{
    public class Input
    {
        public Matrix GetMatrix()
        {
            int n;
            Matrix matrix;

            Console.WriteLine("Enter matrix n: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Error! Wrong format. Try again!");
            }

            Console.WriteLine("Enter r for random matrix or anything else for default: ");
            if (Console.ReadLine() == "r")
            {
                int minValue;
                Console.WriteLine("Enter min value: ");
                while (!int.TryParse(Console.ReadLine(), out minValue))
                {
                    Console.WriteLine("Error! Wrong format. Try again!");
                }
                int maxValue;
                Console.WriteLine("Enter max value: ");
                while (!int.TryParse(Console.ReadLine(), out maxValue))
                {
                    Console.WriteLine("Error! Wrong format. Try again!");
                }
                matrix = new Matrix(n, minValue, maxValue);
            }
            else
            {
                int value;
                Console.WriteLine("Enter matrix value: ");
                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Error! Wrong format. Try again!");
                }
                matrix = new Matrix(n, value);
            }

            return matrix;
        }
    }
}
