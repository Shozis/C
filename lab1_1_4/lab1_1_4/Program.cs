using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_1_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите n1:");
            double n1 = Math.Abs( Convert.ToDouble(Console.ReadLine()))     ;

            double a1 = storona(n1);
            Console.WriteLine(" 1 сторона " + a1);

            double p1 = Ploshadi(n1, a1);
            
            Console.WriteLine("1 Площадь " + p1);

            Console.WriteLine("Введите n2:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double a2 = storona(n2);
            Console.WriteLine(" 2 сторона " + a2);


            double p2 = Ploshadi(n2, a2);
            Console.WriteLine("2 Площадь " + p2);

            Console.WriteLine("Введите n3:");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double a3 = storona(n3);
            Console.WriteLine(" 3 сторона " + a3);

            double p3 = Ploshadi(n3, a3);
            Console.WriteLine("3 Площадь " + p3);


            Console.ReadLine();

        }

        static double storona(double p)
        {
            double R = 15;

            return 2 * R * Math.Sin(180 / p);
        }

        static double Ploshadi(double q, double g)
        {
            return q * g;
        }
    }
}
