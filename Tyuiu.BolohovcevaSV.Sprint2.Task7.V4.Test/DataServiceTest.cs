using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint2.Task7.V4.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint2.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidPoint_ReturnsTrue()
        {

            double x = 0.5;
            double y = 0.5;

            bool result = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void PointBelowAxis_ReturnsFalse()
        {
            double x = 0;
            double y = -0.5;

            bool result = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(false, result);
        }
    }
}
