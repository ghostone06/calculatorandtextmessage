using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        object[] messageArr = new object[] { 22, '#', 33, 777, 55 };
        GetMessage(messageArr);
    }
    public static void GetMessage(object[] messageArr)
    {
        bool isUpper = false;
        string Message = "";
        foreach (object number in messageArr)
        {
            if (!(number is int))
                if ((char)number == '#')
                {
                    isUpper = true;
                    continue;
                }

            int num = (int)number;
            int digit = (int)number % 10;
            int digitCount = 0;
            while (num > 0)
            {
                num /= 10;
                digitCount++;
            }

            if (Message == "")
            {
                Message += FindLetter(digit, digitCount - 1).ToUpper();
                continue;
            }

            Message += isUpper ? FindLetter(digit, digitCount - 1).ToUpper() : FindLetter(digit, digitCount - 1);
            isUpper = false;
        }
        Console.WriteLine(Message);
        Console.ReadLine();
    }
    static string FindLetter(int num, int count)
    {
        string[][] message = new string[][]
        {
            new string[] { " "},
            new string[] { "" },
            new string[] { "a", "b","c" },
            new string[] { "d","e", "f" },
            new string[] { "g", "h", "ı" },
            new string[] { "j", "k", "l" },
            new string[] { "m", "n", "o" },
            new string[] { "p", "q", "r","s" },
            new string[] { "t", "u", "v" },
            new string[] { "w", "x", "y", "z" }
        };

        return message[num][count];
    }
}