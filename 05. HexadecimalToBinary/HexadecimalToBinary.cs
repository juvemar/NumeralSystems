//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexadecimalToBinary
{
    static void Main()
    {
        string hexa = "FA";
        
        Stack<object> binary = new Stack<object>();
        for (int i = hexa.Length - 1; i >= 0; i--)
        {
            switch (hexa[i])
            {
                case 'A': binary.Push(1010); break;
                case 'B': binary.Push(1011); break;
                case 'C': binary.Push(1100); break;
                case 'D': binary.Push(1101); break;
                case 'E': binary.Push(1110); break;
                case 'F': binary.Push(1111); break;
                default: binary.Push(hexa[i].ToString()); break;
            }
        }
        Console.WriteLine(string.Join("",binary));
    }
}