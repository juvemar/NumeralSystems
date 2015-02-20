//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class DecimalToHexadecimal
{
    static void Main()
    {
        Stack<object> result = new Stack<object>();
        int decim = 250;
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