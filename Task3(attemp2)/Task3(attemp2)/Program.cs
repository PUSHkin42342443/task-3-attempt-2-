using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_attemp2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите х:");
            var x = double.Parse(Console.ReadLine());
            double h = 2 / x * x + 25;
            double m = Math.Sqrt(x * x * x * x + 1);
            double g = h + Cos(x);
            double k = (Math.Sin(x) + Cos(x)) / 2;
            double d = m + k;
            double y = g / d;
            Console.WriteLine($"y = {y:F3}");
            Console.ReadKey();
        }
        static double Cos(double cosinus)
        {
            return Math.Cos(cosinus);



        }
    }
}
