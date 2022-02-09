using System;
using System.IO;
using System.Collections.Generic;
using InputOperations;
using FileOperations;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Дз\ОП\ProgLab1\File.txt";
            string changedFilePath = @"D:\Дз\ОП\ProgLab1\ChangedFile.txt";

            StreamWriter sw = new StreamWriter(filePath);
            MyFile.Fill(Input.InputFile(), sw);
            sw.Close();

            StreamReader sr = new StreamReader(filePath);
            List<string> changedFile = MyFile.GetChangedFile(sr);
            MyFile.Display(sr);

            sw = new StreamWriter(changedFilePath);
            MyFile.Fill(changedFile, sw);
            sw.Close();

            sr = new StreamReader(changedFilePath);
            MyFile.Display(sr, "Changed file");

        }

    }
}
