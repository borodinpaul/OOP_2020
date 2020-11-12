using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input x (-1 < x < 1): ");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x < 1 && x > -1)
            {
                Console.Write($"ctg(x) - arccos(x^3) = { 1.0 / Math.Tan(x) - Math.Acos(Math.Pow(x, 3))} \n");
            }
            else Console.WriteLine("Your number is incorrect!");
        }
    }
}
