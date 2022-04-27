using System;
using System.IO;
using System.Collections.Generic;
using InputOperations;
using FileOperations;

namespace ProgLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"/Users/yaroslavvalchyshen/Desktop/Study/Labs/Programming/Lab2/ProgLab2/InputFile.bat";
            string dayFilePath = @"/Users/yaroslavvalchyshen/Desktop/Study/Labs/Programming/Lab2/ProgLab2/DayFile.bat";
            string nightFilePath = @"/Users/yaroslavvalchyshen/Desktop/Study/Labs/Programming/Lab2/ProgLab2/NightFile.bat";

            List<Call> _dayCalls = new List<Call>();
            List<Call> _nightCalls = new List<Call>();

            bool isClearing = Input.GetFileMode();

            Call[] calls = Input.GetCalls().ToArray();

            MyFile.FillFile(inputFilePath, isClearing, calls);
            MyFile.DisplayFile(inputFilePath);

            for (int i = 0; i < calls.Length; i++)
            {
                if (calls[i].GetStartTime().IsDay() && calls[i].GetEndTime().IsDay())
                    _dayCalls.Add(calls[i]);
                else
                    _nightCalls.Add(calls[i]);
            }

            MyFile.FillFile(dayFilePath, isClearing, _dayCalls.ToArray());
            MyFile.DisplayFile(dayFilePath, "Day calls: ");
            MyFile.FillFile(nightFilePath, isClearing, _nightCalls.ToArray());
            MyFile.DisplayFile(nightFilePath, "Night calls: ");
        }
    }
}
