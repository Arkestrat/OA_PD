using System;
using System.Diagnostics;

class Programm
{
    public static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        if (a != b)
        {
            if (a < b)
            {
                a = (a + b) / 2;
                b = (b * (a * 2 - b)) * 2;
                Console.WriteLine($"x больше {a} и {b}");
            }
            else
            {
                b = (a + b) / 2;
                a = (a * (b * 2 - a)) * 2;
                Console.WriteLine($"x больше {a} и {b}");
            }
        }
        else
        {
            Console.WriteLine("y больше");
        }
    }
}