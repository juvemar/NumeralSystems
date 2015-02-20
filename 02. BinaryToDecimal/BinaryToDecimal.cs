//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Linq;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a number in binary system:");
        int[] numbers = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();
        int decim = 0;

        for (int i = numbers.Length - 1, k = 1; i >= 0; i--, k *= 2)
        {
            if (numbers[i] == 1)
            {
                decim += k;
            }
        }

        Console.WriteLine(decim);
    }
}