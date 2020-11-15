using System;
using System.Text;

namespace Lesson007_HW4
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n > 0)
            {
                return n * Factorial(n - 1);
            }
            else
                return 1;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть кількість клієнтів: \n N = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial = {Factorial(n)}");
        }
    }
}
