using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 1;
            double a = -5;
            double b = 7;
            double f = 1.0;
            if (0 < x && x <= 1)
            {
                //Предположение

                double minEl = (x - a) / x;
                if (minEl < Math.Sqrt(a) + x)
                {
                    minEl = Math.Sqrt(a) + x;
                }

                if (minEl < Math.Sin(x))
                {
                    minEl = Math.Sin(x);
                }

                f = Math.Sin(x);

            }
            else if (x > 1)
            {

                //Предположение

                double maxEl = Math.Sqrt(a);

                if ( maxEl > a * x)
                {
                    maxEl = a * x;
                }

                f = maxEl;

            }
            else if (x <= 0)
            {
                //Предположение

                f = a * x + b;
            }

            Console.WriteLine(f);

            //Пауза
            Console.ReadLine();
        }
    }
}
