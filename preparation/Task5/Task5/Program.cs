﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели(1-7):");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1: Console.WriteLine("Понедельник");
                    break;
                case 2: Console.WriteLine("Вторник");
                    break;
                case 3: Console.WriteLine("Среда");
                    break;
                case 4: Console.WriteLine("Четверг");
                    break;
                case 5: Console.WriteLine("Пятница");
                    break;
                case 6: Console.WriteLine("Суббота");
                    break;
                case 7: Console.WriteLine("Воскресенье");
                    break;
                default: Console.WriteLine("Неправильный номер дня недели");
                    break;
            }
            Console.ReadLine();
            }
    }
}
