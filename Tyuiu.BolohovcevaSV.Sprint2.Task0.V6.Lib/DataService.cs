using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BolohovcevaSV.Sprint2.Task0.V6.Lib
{
    public class DataService : ISprint2Task0V6
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = (x * 7) + 5 == y;
            res[1] = x != y;
            res[2] = x < y;
            res[3] = x > y;
            res[4] = x <= y;
            res[5] = x >= y;

            return res;
        }
    }
}

// x = 107    y = 754  1t 2t 3t 4f 5t 6f