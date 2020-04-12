using System;

namespace Сylinders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество цилиндров:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту цилиндров:");
            double h = Convert.ToDouble(Console.ReadLine());
            double s = Math.PI * h * n * (n + 1) * (2 * n + 1) * 3 / 2;
            Console.WriteLine("Сумма объёмов: " + s);
        }
    }
}
