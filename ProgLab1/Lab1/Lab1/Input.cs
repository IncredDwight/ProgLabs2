using System;
using System.Collections.Generic;
namespace InputOperations
{
    public class Input
    {
        public static List<string> InputFile()
        {
            List<string> text = new List<string>();

            Console.WriteLine("Enter text (enter end to stop input): ");
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                text.Add(input);
            }

            return text;
        }
    }
}
