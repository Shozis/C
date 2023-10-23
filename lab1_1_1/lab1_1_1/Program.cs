using System;

namespace lab1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("h = (xy + sin x)/(|1-y|*In x)");
            Console.WriteLine("Введите x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            double h = (x * y + Math.Sin(x)) / (Math.Abs(1 - y) * Math.Log(x));

            double k = h;
            Console.WriteLine("результат вычислений =");
            Console.WriteLine(k);

            double n = Math.Truncate(h);
            Console.WriteLine("целая часть=");
            Console.WriteLine(n);
        }
    }
}
