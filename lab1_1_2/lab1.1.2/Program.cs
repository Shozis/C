using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = -2;
            double y = 4;
            double c = -4;
            double d = 8;
            double e = 1.0;

            if (x * y > 3)
            {
                // Предположение

                double maxEl = Math.Log10(Math.Pow(x * y, c * d));
                if (maxEl > Math.Pow(x, 3))
                {
                    maxEl = Math.Pow(x, 3);
                }

                e = maxEl;
            }
            else if (0 < x * y && x * y < 3)
            {
                double maxEl = d * y;

                if (maxEl > c * x)
                {
                    maxEl = c * x;
                }

                // Предположение

                double minEl = x * 3;

                if (minEl < y)
                {
                    minEl = y;
                }

                if (minEl < maxEl)
                {
                    minEl = maxEl;
                }

                e = maxEl;
            }
            else if (x * y < 0)
            {
                e = Math.Pow(2, c * d) - x;
            }

            Console.WriteLine(e);

            // Пауза
            Console.ReadLine();

        }
    }
}
