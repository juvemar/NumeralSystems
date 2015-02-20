//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter a negative short-type number bigger than {0}: ", short.MinValue);
        short number = short.Parse(Console.ReadLine());

        Console.WriteLine(Converter(number));
    }

    static string Converter(short number)
    {
        char[] b = new char[16];
        int pos = 15;
        int i = 0;

        while (i < 16)
        {
            if ((number & (1 << i)) != 0)
            {
                b[pos] = '1';
            }
            else
            {
                b[pos] = '0';
            }
            pos--;
            i++;
        }
        return new string(b);
    }
}
