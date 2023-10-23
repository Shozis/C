using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите x3:");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y3:");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double a1 = Formyl1(x1, y1, x2, y2);
            Console.WriteLine(a1);
            double a2 = Formyl1(x2, y2, x3, y3);
            Console.WriteLine(a2);
            double a3 = Formyl1(x1, y1, x3, y3);
            Console.WriteLine(a3);

        }

        static double Formyl1(double p1, double q1,double p2, double q2)
        {
            return (p1 * p2 + q1 * q2) / (Math.Sqrt(Math.Pow(p1 + p2, 2)) * Math.Pow(q1 + q2, 2));
        }
    }
}
