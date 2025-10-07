using System;
using Tyuiu.SokolovaHS.Sprint2.Task5.V7.Lib;
namespace Tyuiu.SokolovaHS.Sprint2.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFinMonthName()
        {
            DataService ds = new DataService();
            Assert.AreEqual("январь", ds.FindMonthName(1990, 0));
            Assert.AreEqual("февраль", ds.FindMonthName(1990, 1));
            Assert.AreEqual("март", ds.FindMonthName(1990, 2));
            Assert.AreEqual("апрель", ds.FindMonthName(1990, 3));
            Assert.AreEqual("май", ds.FindMonthName(1990, 4));
            Assert.AreEqual("июнь", ds.FindMonthName(1990, 5));
            Assert.AreEqual("июль", ds.FindMonthName(1990, 6));
            Assert.AreEqual("август", ds.FindMonthName(1990, 7));
            Assert.AreEqual("сентябрь", ds.FindMonthName(1990, 8));
            Assert.AreEqual("октябрь", ds.FindMonthName(1990, 9));
            Assert.AreEqual("ноябрь", ds.FindMonthName(1990, 10));
            Assert.AreEqual("декабрь", ds.FindMonthName(1990, 11));
        }
    }
}
