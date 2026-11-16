using System;
using Tyuiu.BolohovcevaSV.Sprint2.Task6.V1.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint2.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 2 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 2                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание №6                                                              *");
            Console.WriteLine("* Вариант №1                                                              *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По данному номеру месяца определить количество дней в месяце.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            Console.WriteLine("Введите номер месяца:");
            int month = Convert.ToInt32(Console.ReadLine());

            int result = ds.FindMonthDaysCount(month);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество дней: " + result);

            Console.ReadLine();
        }
    }
}