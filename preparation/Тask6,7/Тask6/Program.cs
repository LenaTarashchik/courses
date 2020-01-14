using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тask6
{
    class Program
    {
        static void Main(string[] args)
        {
/*            Служба такси заказала вам программу, которая спрашивает количество
километров и количество минут простоя, а дальше считает так: первые
5 километров (или до 5 км) 20 гривен, каждый следующий километр 3
гривны, плюс простой 1 грн за 1 минуту. Программа должна посчитать
и сказать общую сумму оплаты за поездку.*/

            double grn;
            int a = 20; // цена за первые 5 км или до 5
            Console.WriteLine("Введите количество километров:");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество минут простоя:");
            double hv = Convert.ToDouble(Console.ReadLine());
            if (km <= 5)
            {
                grn = a + hv;
            }
            else
            {
                grn = a + (km - 5) * 3 + hv;
            }
            Console.WriteLine("Общая сумма:" + grn);
            Console.ReadLine();

//            Дано натуральное число. Выяснить, является ли оно простым, т.е.
//делится только на 1 и на само себя.
            Console.WriteLine("Введите натуральное число");
            int n = Convert.ToInt32(Console.ReadLine());
            int r=0;
            if (n > 1)
            {
                for (int i = 2; i <= n; i++)
                {
                    double ost;
                    ost = n % i;
                    if (ost == 0) r++;
                }
                if (r == 1)
                {
                    Console.WriteLine("Простое");
                }
                else
                {
                    Console.WriteLine("Составное");
                }
            }
            else Console.WriteLine("Число 1 не относится ни к простым, ни к составным числам");
            Console.ReadLine();
        }
    }
}
