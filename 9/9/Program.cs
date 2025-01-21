using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] banknotevalue = { 100, 200, 500, 2000, 5000 };
        int sum = 0;

        while (true)
        {
            Console.WriteLine("Введите сумму кратную 100 и не превышающую 50000");
            try
            {
                sum = int.Parse(Console.ReadLine());

                if (sum < 0 || sum % 100 != 0 || sum > 50000)
                {
                    Console.Write($"Сумма должна быть кратной 100 и не превышать 50000 рублей \n");
                    continue;
                }
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите корректное число");
            }
        }
        long ways = CountWays(banknotevalue, sum);
        Console.WriteLine($"Количество способов набрать сумму {sum} равно {ways}");
    }
    static long CountWays(int[] banknotevalue, int i)
    {
        long[] a = new long[i + 1];
        a[0] = 1;

        foreach (var coin in banknotevalue)
        {
            for (int j = coin; j <= i; j++)
            {
                a[j] += a[j - coin];
            }
        }
        return a[i];
    }
}