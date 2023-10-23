
using System;

namespace lab1_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;
            double x = -0.5;

            // do while

            do
            {
                y = Math.Pow(x, 5) + 5 * Math.Pow(x, 4) - 2 * Math.Pow(x, 3) - 4 * Math.Pow(x, 2) + 7 * x - 3;
                x += 0.1;
                Console.WriteLine(y);
            } while (x <= 1.5);
        }
    }
}
