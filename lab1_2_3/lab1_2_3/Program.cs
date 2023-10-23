using System;

namespace lab1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;
            double x = 0;
            double i = -Math.PI;

            //while

            while (i < Math.PI)
            {
                y = 3 * Math.Pow(Math.Cos(2 * x + 1), 2);
                i += Math.PI / 8;
                Console.WriteLine(y);
            }
    }
}
