//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        int[] remainder = new int[16];
        int i = 15;
        int decim = 230;
        int result = decim;
        while(result > 0)
        {
            remainder[i] = result % 2;
            result /= 2;
            i--;
        }
        Console.WriteLine(string.Join("",remainder));
    }
}