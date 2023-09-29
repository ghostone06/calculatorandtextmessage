using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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

        // [INFO] Yukarıdaki Kodun Refaktör edilmiş halidir.
        //StringBuilder messageBuilder = new StringBuilder();
        //bool isNextUpper = true;

        //foreach (object item in messageArr)
        //{
        //    if (item is int number)
        //    {
        //        int digit = number % 10;
        //        int digitCount = number.ToString().Length;

        //        char letter = FindLetter(digit, digitCount - 1);
        //        messageBuilder.Append(isNextUpper ? char.ToUpper(letter) : letter);

        //        isNextUpper = false;
        //    }
        //    else if (item is char character && character == '#')
        //    {
        //        isNextUpper = true;
        //    }
        //}
        //string message = messageBuilder.ToString();
        //Console.WriteLine(message);
        //Console.ReadLine();
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

        //[INFO] Refaktör edilmiş kodun fonksiyon içeriği fonk return tipi char olmalı
        //char[][] message = new char[][]
        //{
        //    new char[] { ' ' },
        //    new char[] {  },
        //    new char[] { 'a', 'b','c' },
        //    new char[] { 'd','e', 'f'},
        //    new char[] { 'g', 'h', 'i'},
        //    new char[] { 'j', 'k', 'l' },
        //    new char[] { 'm', 'n', 'o' },
        //    new char[] { 'p', 'q', 'r', 's' },
        //    new char[] { 't', 'u', 'v' },
        //    new char[] { 'w', 'x', 'y', 'z'}
        //};

        return message[num][count];
    }
}