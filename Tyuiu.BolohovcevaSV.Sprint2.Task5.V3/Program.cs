using System;
using Tyuiu.BolohovcevaSV.Sprint2.Task5.V3.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint2.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Болоховцева С.В. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Болоховцева С.В. | СМАРТб-26-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По порядковому номеру дня недели определить его название.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите номер дня недели:                                               *");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("* " + ds.FindDayName(number));
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}