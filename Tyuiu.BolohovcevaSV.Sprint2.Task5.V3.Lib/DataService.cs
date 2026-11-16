using System;
using tyuiu.cources.programming.interfaces.Sprint2;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.BolohovcevaSV.Sprint2.Task5.V3.Lib
{
    public class DataService : ISprint2Task5V3
    {
        public string FindDayName(int value)
        {
            switch (value)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: return "Такого дня недели нет";
            }
        }
    }
}
