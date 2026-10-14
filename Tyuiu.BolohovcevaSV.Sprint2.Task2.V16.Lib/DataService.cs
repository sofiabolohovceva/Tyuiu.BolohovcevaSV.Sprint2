using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BolohovcevaSV.Sprint2.Task2.V16.Lib
{
    public class DataService : ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (y == 3 || y == 4)
                return (x >= 3 && x <= 5) || (x >= 13 && x <= 14);

            if (y == 5)
                return (x >= 3 && x <= 7) || (x >= 13 && x <= 14);

            if (y == 6)
                return (x >= 3 && x <= 9) || (x >= 13 && x <= 14);

            if (y == 7)
                return x >= 3 && x <= 14;

            if (y == 8)
                return (x >= 6 && x <= 9) || (x >= 13 && x <= 14);

            if (y == 9 || y == 10)
                return (x >= 6 && x <= 7) || (x >= 13 && x <= 14);

            if (y == 11)
                return x >= 3 && x <= 7;

            if (y == 12)
                return x == 3 || (x >= 7 && x <= 10);

            if (y == 13)
                return x == 3 || (x >= 10 && x <= 12);

            return false;
        }
    }
}
