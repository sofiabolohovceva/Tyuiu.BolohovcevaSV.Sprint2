using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint2.Task5.V3.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint2.Task.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidNumber()
        {
            DataService ds = new DataService();

            string[] days =
            {
                "Понедельник",
                "Вторник",
                "Среда",
                "Четверг",
                "Пятница",
                "Суббота",
                "Воскресенье"
            };

            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(days[i], ds.FindDayName(i + 1));
            }
        }
    }
}