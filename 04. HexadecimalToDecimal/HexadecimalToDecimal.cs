using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HexadecimalToDecimal
{
    static void Main()
    {
        string hexa = "FA";
        char remainder;
        int result = 0;
        for (int i = hexa.Length - 1, power = 1; i >= 0; i--, power*=16)
        {
            remainder = hexa[i];
            switch (remainder)
            {
                case 'A': result += 10 * power; break;
                case 'B': result += 11 * power; break;
                case 'C': result += 12 * power; break;
                case 'D': result += 13 * power; break;
                case 'E': result += 14 * power; break;
                case 'F': result += 15 * power; break;
                default: result += power * remainder; break;
            }
        }
        Console.WriteLine(result);
    }
}