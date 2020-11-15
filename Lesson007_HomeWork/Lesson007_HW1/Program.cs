using System;
using System.Text;

namespace Lesson007_HW1
{
    class Program
    {
        static void Calculate(ref int a, ref int b, ref int c)
        {
            a /= 5;
            b /= 5;
            c /= 5;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть 3 числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Calculate(ref a, ref b, ref c);
            Console.WriteLine($"a = {a}\nb = {b}\nc = {c}");
        }
    }
}
