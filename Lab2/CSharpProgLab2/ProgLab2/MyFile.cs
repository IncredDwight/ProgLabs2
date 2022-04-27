using System;
using System.Collections.Generic;
using System.IO;
using InputOperations;

namespace FileOperations
{
    public class MyFile
    {
        public static void FillFile(string path, bool isClearing, Call[] data)
        {
            if (isClearing)
                File.Delete(path);

            BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Append));
            for (int i = 0; i < data.Length; i++)
            {
                binaryWriter.Write(data[i].GetPhoneNumber());
                binaryWriter.Write(data[i].GetStartTime().GetTime());
                binaryWriter.Write(data[i].GetEndTime().GetTime());
            }
            binaryWriter.Close();
        }

        public static Call[] ReadFile(string path)
        {
            List<Call> calls = new List<Call>();
            BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open));
            while(binaryReader.PeekChar() > -1)
            {
                string phoneNumber = binaryReader.ReadString();
                Time startTime = new Time(binaryReader.ReadString());
                Time endTime = new Time(binaryReader.ReadString());

                Call call = new Call(phoneNumber, startTime, endTime);
                calls.Add(call);
            }
            binaryReader.Close();

            return calls.ToArray();
        }

        public static void DisplayFile(string path, string caption = "File: ")
        {
            BinaryReader binaryReader = new BinaryReader(File.Open(path, FileMode.Open));

            Console.WriteLine(caption);

            while (binaryReader.PeekChar() > -1)
            {
                string phoneNumber = binaryReader.ReadString();
                Time startTime = new Time(binaryReader.ReadString());
                Time endTime = new Time(binaryReader.ReadString());

                Console.WriteLine(phoneNumber + " " + startTime.GetTime() + " " + endTime.GetTime());
            }
            binaryReader.Close();
        }
    }
}
