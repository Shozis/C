using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("d = x * (y*y) - sqrt(abs((x*x) - 2,5 * pow(10 , -3) * y) / 2sin(x * y)");
            Console.WriteLine("Введите x=");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y=");
            double y = Convert.ToDouble(Console.ReadLine());

            double d = (x * Math.Pow(y, 2) - Math.Sqrt(Math.Abs(Math.Pow(x, 2)) - 2.5)) * (Math.Pow(10, -3) * y) / 2 * Math.Sin(x * y) + 0.5;

            double k = d;
            Console.WriteLine("результат вычислений =");
            Console.WriteLine(k);

            double l = Math.Truncate(d);
            Console.WriteLine("целая часть=");
            Console.WriteLine(l);
        }
    }
}
