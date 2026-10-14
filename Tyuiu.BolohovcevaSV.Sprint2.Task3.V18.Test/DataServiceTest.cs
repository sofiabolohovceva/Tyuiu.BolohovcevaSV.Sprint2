using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint2.Task3.V18.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint2.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 3;
            double expected = 72;

            double actual = ds.Calculate(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
