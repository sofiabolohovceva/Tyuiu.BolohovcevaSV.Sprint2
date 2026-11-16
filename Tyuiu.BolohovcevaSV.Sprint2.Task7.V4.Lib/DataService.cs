using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BolohovcevaSV.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool result = (y >= 0) &&
                          (x * x + y * y <= 1) &&
                          (x < 0 || x * x + y * y >= 0.09);

            return result;
        }
    }
}
