using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
//           Пользователь вводит число 1 или 0 с помощью одной строки кода
//вывести на экран «Хорошо» если пользователь ввел 1 или «Плохо»
//если пользователь ввел 0
            
            Console.WriteLine("Введите 0 или 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x==0 ? "Плохо" : "Хорошо");
            Console.ReadLine();
        }
    }
}
