using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;


            //for

            for (double x = -4; x <= 4; x += 0.5)
            {
                if (x <= 0){

                    y = Math.Pow(x, 2) - 1;
                }

                else if (0 <x && x <= 1.5){

                    y = Math.Cos(x);
                }

                else if (x > 1.5){

                    y = Math.Sin(x - 1);

                    Console.WriteLine(y);
                }
            }
        }
    }
}
