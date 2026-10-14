using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint2.Task1.V24.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint2.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void validGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 325;
            int b = 325;
            int c = 242;
            int d = 324;

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            bool[] wait = { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
