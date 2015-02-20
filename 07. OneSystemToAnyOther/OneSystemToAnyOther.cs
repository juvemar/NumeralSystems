//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter a number to be converted: ");
        string number = (Console.ReadLine()).ToUpper();
        Console.Write("Enter a system to convert From: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter a system to convert To: ");
        int d = int.Parse(Console.ReadLine());

        ConvertFromDecimal(ConvertToDecimal(number, s), d);
    }

    static string ConvertToDecimal(string number, int s)
    {
        int decim = 0;
        if (s > 10)
        {
            char remainder;
            int result = 0;
            for (int i = number.Length - 1, power = 1; i >= 0; i--, power *= 16)
            {
                remainder = number[i];
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
            return result.ToString();
        }
        else if (s < 10)
        {
            for (int i = number.Length - 1, k = 1; i >= 0; i--, k *= 2)
            {
                if (number[i] == 1)
                {
                    decim += k;
                }
            }
            return decim.ToString();
        }
        else return number;
    }

    static void ConvertFromDecimal(string number, int d)
    {
        if (d == 2)
        {
            int[] remainder = new int[12];
            int i = 11;
            int result = int.Parse(number);
            while (result > 0)
            {
                remainder[i] = result % 2;
                result /= 2;
                i--;
            }
            Console.WriteLine(string.Join("", remainder));
        }
        else if (d == 10)
        {
            Console.WriteLine(number);
        }
        else if (d == 16)
        {
            Stack<object> result = new Stack<object>();
            int decim = int.Parse(number);
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
            Console.WriteLine(string.Join("", result));
        }
    }
}