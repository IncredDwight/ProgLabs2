using System;
using System.Collections.Generic;
using System.IO;
namespace InputOperations
{
    public class Input
    {
        public static List<Call> GetCalls()
        {
            List<Call> calls = new List<Call>();
            Console.WriteLine("Enter information about phone calls. To stop enter empty line \n(format: +**0********* HH:MM HH:MM): ");

            string input = Console.ReadLine();
            while (input != "")
            {
                Call call = CreateCall(input);

                if (call != null)
                    calls.Add(call);
                else
                {
                    Console.WriteLine("Error! Wrong format. Try again");
                }
                input = Console.ReadLine();
            }
            return calls;
        }

        public static bool GetFileMode()
        {
            string rewriteKey = "r";

            Console.WriteLine($"Enter file mode(To rewrite file enter '{rewriteKey}' or anything else to append):");
            return Console.ReadLine() == rewriteKey;     
        }

        private static Call CreateCall(string line)
        {
            string[] elements = line.Split(" ");


            if (elements.Length != 3)
                return null;
            if (!IsPhoneNumberFormatValid(elements[0]) || !IsTimeFormatValid(elements[1]) || !IsTimeFormatValid(elements[2]))
                return null;

            Time startTime = new Time(elements[1]);
            Time endTime = new Time(elements[2]);

            return new Call(elements[0], startTime, endTime);
        }

        private static bool IsPhoneNumberFormatValid(string number)
        {
            if (number.Length != 13 || number[0] != '+' || number[3] != '0')
                return false;

            for (int i = 1; i < number.Length; i++)
                if (!Char.IsDigit(number[i]))
                    return false;

            return true;
        }

        private static bool IsTimeFormatValid(string time)
        {
            if (time.Length != 5 || time[2] != ':')
                return false;

            for (int i = 0; i < time.Length; i++)
                if (!Char.IsDigit(time[i]) && i != 2)
                    return false;

            return true;
        }
    }

    public class Time
    {
        private int _hh;
        private int _mm;

        public Time(string time)
        {
            string[] splitted = time.Split(":");

            //if (Int32.TryParse(splitted[0], out int hours))
            SetHours(Convert.ToInt32(splitted[0]));
            //if (Int32.TryParse(splitted[1], out int minutes))
            SetMinutes(Convert.ToInt32(splitted[1]));
        }

        private void SetHours(int hours)
        {
            _hh = (hours > 23) ? 0 : hours;
        }

        private void SetMinutes(int minutes)
        {
            _mm = (minutes > 59) ? 0 : minutes;
        }

        public string GetTime()
        {
            string time = ((_hh < 10) ? "0" : "") + _hh + ":" + ((_mm < 10) ? "0" : "") + _mm;
            return time;
        }

        public bool IsDay()
        {
            return (_hh > 6 && _hh < 20);
        }

    }

    public class Call
    {
        private string _phoneNumber;
        private Time _startTime;
        private Time _endTime;

        public Call(string phoneNumber, Time startTime, Time endTime)
        {
            _phoneNumber = phoneNumber;
            _startTime = startTime;
            _endTime = endTime;
        }

        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public Time GetStartTime()
        {
            return _startTime;
        }

        public Time GetEndTime()
        {
            return _endTime;
        }

    }
}
