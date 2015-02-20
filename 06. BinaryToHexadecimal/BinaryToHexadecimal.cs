//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a number in binary system:");
        int[] numbers = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();
        int decim = 0;
        int j = 1;

        for (int i = numbers.Length - 1, k = 1; i >= 0; i--, k *= 2)//from binary to decimal
        {
            if (numbers[i] == 1)
            {
                decim += k;
            }
        }

        Stack<object> result = new Stack<object>();//from decimal to hexadecimal
        while (decim > 0)
        {
            switch (decim % 16)
            {
                case 10: result.Push('A'); break;
                case 11: result.Push('B'); break;
                case 12: result.Push('C'); break;
                case 13: result.Push('D'); break;
                case 14: result.Push('E'); break;
                case 15: result.Push('F'); break;
                default: result.Push(decim % 16); break;
            }
            decim /= 16;
        }

        Console.WriteLine(string.Join("",result));
    }
}