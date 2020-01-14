using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит два числа. Вывести на экран большее
            Console.WriteLine("Введите первое число:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int second = Convert.ToInt32(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine("Большее:" + first);
            }
            else Console.WriteLine("Большее:" + second); 
            Console.ReadLine();

  /*Пользователь вводит слово «мяу» или слово «гав» если слово
введенное пользователем «мяу» вывести на экран «Покорми кота» иначе «Погуляй с собакой»*/
            
            Console.WriteLine("Введите мяу или гав");
            string s = Console.ReadLine();
            if (s == "мяу")
            {
                Console.WriteLine("Покорми кота");
            }
            else if (s == "гав")
                Console.WriteLine("Погуляй с собакой");
            Console.ReadLine();
        }
    }
}
