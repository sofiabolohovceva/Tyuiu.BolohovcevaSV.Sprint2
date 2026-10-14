
using System;
using Tyuiu.BolohovcevaSV.Sprint2.Task3.V18.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint2.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 2 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 2                                                                *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание №3                                                              *");
            Console.WriteLine("* Вариант №18                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение функции Y при заданном значении X.                   *");
            Console.WriteLine("* Использовать вложенные операторы if-else.                               *");
            Console.WriteLine("* Результат округлить до трех знаков после запятой.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Y = " + y.ToString("F3"));

            Console.ReadLine();
        }
    }
}
