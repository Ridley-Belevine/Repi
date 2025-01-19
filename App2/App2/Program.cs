using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину ребра октаэдра:");
        double a = double.Parse(Console.ReadLine());

        double s = 2 * Math.Sqrt(3) * Math.Pow(a, 2);
        double v = Math.Sqrt(2) * Math.Pow(a, 3) * 1 / 3;

        Console.WriteLine("Площадь поверхности октаэдра: " + Math.Round(s, 3));
        Console.WriteLine("Объем октаэдра: " + Math.Round(v, 3));

        Console.ReadKey();
    }
}
