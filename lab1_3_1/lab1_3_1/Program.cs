using System;

namespace lab1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("b = pow(x + y / 0,2 * x) , (1.0 / 3.0) * sin(tg x * x");

            Console.WriteLine("Введите x=");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y=");
            double y = Convert.ToDouble(Console.ReadLine());

            double b = (Math.Cbrt(x + y / 0.2 * x)) * Math.Sin(Math.Tan(Math.Pow(x, 2)));

            double i = b;
            Console.WriteLine("результат вычислений =");
            Console.WriteLine(i);

            double j = Math.Truncate(b);
            Console.WriteLine("целая часть=");
            Console.WriteLine(j);
        }
    }
}
