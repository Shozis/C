using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // По условию AB = 3, AD = 5, DB = 4, DC = √35, ВС = √19, AC = 5

            Console.WriteLine("Введите AB:");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double AB = Pol(a1);

            Console.WriteLine("Введите AD:");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double AD = Pol(a2);

            Console.WriteLine("Введите BD:");
            double a3 = Convert.ToDouble(Console.ReadLine());
            double BD = Pol(a3);

            Console.WriteLine("Введите BC:");
            double a4 = Convert.ToDouble(Console.ReadLine());
            a4 = Math.Sqrt(a4);
            double BC = Pol(a4);

            Console.WriteLine("Введите AC:");
            double a5 = Convert.ToDouble(Console.ReadLine());
            double AC = Pol(a5);

            Console.WriteLine("Введите DC:");
            double a6 = Convert.ToDouble(Console.ReadLine());
            a6 = Math.Sqrt(a6);
            double DC = Pol(a6);

            double Per1 = Perimetr(AB, BD, AD);
            double Per2 = Perimetr(BC, BD, DC);
            double Per3 = Perimetr(AD, DC, AC);
            double Per4 = Perimetr(AB, BC, AC);

            double S1 = Ploshadi(Per1, AB, BD, AD);
            Console.WriteLine("Площадь 1 треугольника =" + S1);
            double S2 = Ploshadi(Per2, BC, BD, DC);
            Console.WriteLine("Площадь 2 треугольника =" + S2);
            double S3 = Ploshadi(Per3, AD, DC, AC);
            Console.WriteLine("Площадь 3 треугольника =" + S3);
            double S4 = Ploshadi(Per4, AB, BC, AC);
            Console.WriteLine("Площадь 4 треугольника =" + S4);


            Console.ReadLine();
        }

        static double Pol(double q)
        {
            return Math.Abs(q);
        }

        static double Perimetr(double a, double b, double c)
        {
            return a + b + c;
        }

        static double Ploshadi(double d, double a, double b, double c)
        {
            return Math.Sqrt(d * (d - a) *(d - b) * (d - c));
        }

    }
}
