using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint2.Task4.V28.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint2.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 10;

            double expected = 13;
            double actual = ds.Calculate(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InValidCalculate()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 3;

            double expected = 1.108;
            double actual = ds.Calculate(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
