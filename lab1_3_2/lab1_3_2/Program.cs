using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 5;
            double b = -1;
            double c = 9;
            double h = 1.0;
            if (0 < x && x < 1)
            {

                //Предположение

                h = b * x + 1;
            }
            else if (x <= 0)
            {

                //Предположение

                double minEl = Math.Sqrt(Math.Abs(b * x));
                if (minEl < Math.Pow(x, 3))
                {
                    minEl = Math.Pow(x, 3);
                }

                h = Math.Pow(x, 3);

                if (minEl < x + b)
                {
                    minEl = x + b;
                }

                h = x + b;
            }
            else
            {

                double maxEl = x + c;
                if (maxEl > Math.Cos(b * x))
                {
                    maxEl = Math.Cos(b * x);
                }

                h = maxEl;
            }

            Console.WriteLine(h);

            //Пауза
            Console.ReadLine();
        }
    }
}
