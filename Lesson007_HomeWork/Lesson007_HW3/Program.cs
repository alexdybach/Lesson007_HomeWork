using System;
using System.Text;

namespace Lesson007_HW3
{
    class Program
    {
        static void Credit(int money, ref int arrears)
        {
            arrears += money;
            if (arrears < 0)
                Console.WriteLine($"Заборгованість становить : {arrears} грн.");
            else if (arrears > 0)
                Console.WriteLine($"Переплата становить : {arrears} грн.");
            else
                Console.WriteLine("Кредит повністю виплачено, борг відсутній!");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int arrears = -700;     //Заборгованість
            int numberOfPayments = 7;
            while (numberOfPayments > 0)
            {
                Console.WriteLine("Введіть суму платежу");
                int money = int.Parse(Console.ReadLine());
                numberOfPayments--;
                Credit(money, ref arrears);
                if (arrears >= 0)
                    break;
                Console.WriteLine($"Залишилося {numberOfPayments} платежів");
            }
        }
    }
}
