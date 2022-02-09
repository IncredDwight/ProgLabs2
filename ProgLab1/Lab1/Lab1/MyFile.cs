using System;
using System.Collections.Generic;
using System.IO;

namespace FileOperations
{
    public class MyFile
    {
        public static List<string> GetChangedFile(StreamReader sr)
        {
            List<string> changedText = new List<string>();
            string line;
            int numbersAmount;

            for (int i = 0; (line = sr.ReadLine()) != null; i++)
            {
                numbersAmount = 0;

                for (int j = 0; j < line.Length; j++)
                    if (Char.IsNumber(line[j]))
                        numbersAmount++;

                if (i % 2 == 0)
                    line += " Digits amount: " + numbersAmount;

                changedText.Add(line);
            }
            return changedText;
        }

        public static void Fill(List<string> text, StreamWriter sw)
        {
            for (int i = 0; i < text.Count; i++)
            {
                sw.WriteLine(text[i]);
            }
        }

        public static void Display(StreamReader sr, string caption = "Original file")
        {
            sr.BaseStream.Position = 0;
            Console.WriteLine(caption);
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}

